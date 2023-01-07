
using Newtonsoft.Json;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;
using Application = System.Windows.Forms.Application;
using Color = System.Drawing.Color;

public class LogitechBattery
{
    static readonly NotifyIcon notifyIconHeadset = new NotifyIcon();
    static readonly NotifyIcon notifyIconMouse = new NotifyIcon();
    static readonly ContextMenu contextMenu1 = new ContextMenu();
    static readonly MenuItem menuItem1 = new MenuItem();

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        contextMenu1.MenuItems.AddRange(new MenuItem[] { menuItem1 });

        menuItem1.Index = 0;
        menuItem1.Text = "E&xit";
        menuItem1.Click += new EventHandler(menuItem1_Click);

        notifyIconHeadset.ContextMenu = contextMenu1;
        notifyIconMouse.ContextMenu = contextMenu1;

        notifyIconHeadset.Text = "Headset";
        notifyIconMouse.Text = "Mouse";

        notifyIconHeadset.Visible = true;
        notifyIconMouse.Visible = true;

        ShowText(GetBatteryLevels().Item1, SystemFonts.DefaultFont, Color.LightPink, notifyIconHeadset);
        ShowText(GetBatteryLevels().Item2, SystemFonts.DefaultFont, Color.LightBlue, notifyIconMouse);

        Timer timer1 = new Timer();
        timer1.Interval = (int)TimeSpan.FromMinutes(5).TotalMilliseconds;
        timer1.Tick += new EventHandler(timer1_Tick);
        timer1.Start();

        Application.Run();
    }

    private static void menuItem1_Click(object sender, EventArgs e)
    {
        var menuItem = (MenuItem)sender;
        menuItem.Dispose();
        Application.Exit();
    }

    private static void timer1_Tick(object sender, EventArgs e)
    {
        ShowText(GetBatteryLevels().Item1, SystemFonts.DefaultFont, Color.LightPink, notifyIconHeadset);
        ShowText(GetBatteryLevels().Item2, SystemFonts.DefaultFont, Color.LightBlue, notifyIconMouse);
    }

    public static void ShowText(string text, Font font, Color col, NotifyIcon notifyIcon)
    {
        Brush brush = new SolidBrush(col);
        Bitmap bitmap = new Bitmap(16, 16);
        Graphics graphics = Graphics.FromImage(bitmap);
        graphics.DrawString(text, font, brush, 0, 0);
        Icon icon = Icon.FromHandle(bitmap.GetHicon());

        notifyIcon.Icon = icon;
    }

    private static (string, string) GetBatteryLevels()
    {
        var db = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\LGHUB\settings.db";

        var headsetPercentage = "?";
        var mousePercentage = "?";

        var conn = new SQLiteConnection($"Data Source={db}; Version = 3; New = False; Read Only=True; ");

        conn.Open();
        var command = conn.CreateCommand();
        command.CommandText = "SELECT FILE FROM DATA";

        using (var reader = command.ExecuteReader())
        {
            reader.Read();
            string myreader = reader.GetString(0);
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myreader);
            var headset = myDeserializedClass.BatteryG733Percentage;
            var mouse = myDeserializedClass.BatteryProwirelessmousePercentage;

            if (headset != null)
            {
                int percentage = (int)headset.percentage;
                headsetPercentage = percentage.ToString();
            }

            if (mouse != null)
            {
                int percentage2 = (int)mouse.percentage;
                mousePercentage = percentage2.ToString();
            }
        }

        conn.Close();
        return (headsetPercentage, mousePercentage);
    }
}