using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Action
    {
        public string actionId { get; set; }
        public ErroneousParameters erroneousParameters { get; set; }
        public string integrationId { get; set; }
        public Parameters parameters { get; set; }
    }

    public class Analytics
    {
        public string hostId { get; set; }
        public PendingUserPrompt pendingUserPrompt { get; set; }
        public string versionNumber { get; set; }
    }

    public class Application
    {
        public string applicationId { get; set; }
        public List<CategoryColor> categoryColors { get; set; }
        public List<Command> commands { get; set; }
        public string databaseId { get; set; }
        public string lastRunTime { get; set; }
        public string name { get; set; }
        public int version { get; set; }
        public string applicationFolder { get; set; }
        public string applicationPath { get; set; }
        public bool? isInstalled { get; set; }
        public string posterTitlePosition { get; set; }
        public string posterUrl { get; set; }
        public List<Application> applications { get; set; }
    }

    public class ArxControlAuthentication
    {
    }

    public class Assignment
    {
        public string cardId { get; set; }
        public string slotId { get; set; }
    }

    public class BatteryG733Warning
    {
        public string deviceId { get; set; }
        public string level { get; set; }
        public double percentage { get; set; }
        public string time { get; set; }
    }

    public class BatteryProwirelessmouseWarning
    {
        public string deviceId { get; set; }
        public string level { get; set; }
        public double percentage { get; set; }
        public string time { get; set; }
    }

    public class BatteryG733Percentage
    {
        public string isCharging { get; set; }
        public string millivolts { get; set; }
        public double percentage { get; set; }
        public string time { get; set; }
    }

    public class BatteryProwirelessmousePercentage
    {
        public string isCharging { get; set; }
        public string millivolts { get; set; }
        public double percentage { get; set; }
        public string time { get; set; }
    }

    public class BlueVoiceSettings
    {
        public Description description { get; set; }
        public Settings settings { get; set; }
    }

    public class Brightness
    {
        public string mode { get; set; }
        public int value { get; set; }
    }

    public class CameraSettings
    {
        public string audioMode { get; set; }
        public Exposure exposure { get; set; }
        public Focus focus { get; set; }
        public int fov { get; set; }
        public bool hdr { get; set; }
        public Iris iris { get; set; }
        public Pan pan { get; set; }
        public string priority { get; set; }
        public Roll roll { get; set; }
        public Tilt tilt { get; set; }
        public Zoom zoom { get; set; }
    }

    public class Card
    {
        public string attribute { get; set; }
        public Equalizer equalizer { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public bool readOnly { get; set; }
        public string applicationId { get; set; }
        public string category { get; set; }
        public Macro macro { get; set; }
        public string profileId { get; set; }
        public ProEqualizer proEqualizer { get; set; }
        public CameraSettings cameraSettings { get; set; }
        public VideoSettings videoSettings { get; set; }
        public BlueVoiceSettings blueVoiceSettings { get; set; }
        public List<Card> cards { get; set; }
    }

    public class CategoryColor
    {
        public string hex { get; set; }
        public string tag { get; set; }
    }

    public class Color
    {
        public string mode { get; set; }
    }

    public class Command
    {
        public string cardId { get; set; }
        public string category { get; set; }
        public string name { get; set; }
    }

    public class Compressor
    {
        public int attack { get; set; }
        public bool enabled { get; set; }
        public int makeup { get; set; }
        public int ratio { get; set; }
        public int release { get; set; }
        public int threshold { get; set; }
    }

    public class Contrast
    {
        public string mode { get; set; }
        public int value { get; set; }
    }

    public class CrashReporting
    {
        public bool userPrompted { get; set; }
        public string versionNumber { get; set; }
    }

    public class DeEsser
    {
        public int attack { get; set; }
        public bool enabled { get; set; }
        public int frequency { get; set; }
        public int ratio { get; set; }
        public int release { get; set; }
        public int threshold { get; set; }
    }

    public class DePopper
    {
        public bool enabled { get; set; }
        public int frequency { get; set; }
    }

    public class Description
    {
        public string name { get; set; }
        public string slotPrefix { get; set; }
        public string tag { get; set; }
    }

    public class DevicesG733PersistentData
    {
        public DeviceSplashShown deviceSplashShown { get; set; }
    }

    public class DevicesKnown
    {
        public List<KnownList> knownList { get; set; }
    }

    public class DeviceSplashShown
    {
        public bool value { get; set; }
    }

    public class Equalizer
    {
        public List<double> advanced { get; set; }
        public string deviceType { get; set; }
        public string name { get; set; }
        public List<int> simple { get; set; }
        public string type { get; set; }
    }

    public class ErroneousParameters
    {
        public string app_selection { get; set; }
    }

    public class Expander
    {
        public int attack { get; set; }
        public int attenuationMax { get; set; }
        public bool enabled { get; set; }
        public int hysteresis { get; set; }
        public int ratio { get; set; }
        public int release { get; set; }
        public int threshold { get; set; }
        public int thresholdAutoSensibility { get; set; }
    }

    public class Exposure
    {
        public string mode { get; set; }
        public int value { get; set; }
    }

    public class Focus
    {
        public string mode { get; set; }
    }

    public class Gain
    {
        public string mode { get; set; }
        public int value { get; set; }
    }

    public class Gamma
    {
        public string mode { get; set; }
    }

    public class High
    {
        public int frequency { get; set; }
        public double gain { get; set; }
        public int width { get; set; }
    }

    public class Hue
    {
        public string mode { get; set; }
        public int value { get; set; }
    }

    public class IntegrationManagerSettings
    {
        public bool allowLedSdk { get; set; }
    }

    public class Iris
    {
        public string mode { get; set; }
    }

    public class Keystroke
    {
        public int code { get; set; }
        public List<int> modifiers { get; set; }
    }

    public class KnownList
    {
        public string modelId { get; set; }
        public string serialNumber { get; set; }
        public string timestamp { get; set; }
        public string type { get; set; }
    }

    public class LightingCustomPalette
    {
    }

    public class Limiter
    {
        public int attack { get; set; }
        public double boost { get; set; }
        public int release { get; set; }
    }

    public class Low
    {
        public int frequency { get; set; }
        public double gain { get; set; }
        public int width { get; set; }
    }

    public class Macro
    {
        public string actionName { get; set; }
        public Keystroke keystroke { get; set; }
        public string type { get; set; }
        public Action action { get; set; }
    }

    public class Mid
    {
        public int frequency { get; set; }
        public double gain { get; set; }
        public int width { get; set; }
    }

    public class NoiseReduction
    {
        public int attenuationMax { get; set; }
        public int bias { get; set; }
        public bool enabled { get; set; }
        public int release { get; set; }
        public int sensitivity { get; set; }
    }

    public class Pan
    {
        public string mode { get; set; }
    }

    public class Parameters
    {
        public string app_selection { get; set; }
        public string command_selection { get; set; }
    }

    public class PendingUserPrompt
    {
    }

    public class Persistent
    {
        public string id { get; set; }
    }

    public class ProEqualizer
    {
        public List<int> bands { get; set; }
        public string deviceType { get; set; }
        public string name { get; set; }
        public string tag { get; set; }
        public string type { get; set; }
    }

    public class Profile
    {
        public bool activeForApplication { get; set; }
        public string applicationId { get; set; }
        public List<Assignment> assignments { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public List<Profile> profiles { get; set; }
    }

    public class Roll
    {
        public string mode { get; set; }
    }

    public class Root
    {
        [JsonProperty("/devices/g733/persistent_data")]
        public DevicesG733PersistentData DevicesG733PersistentData { get; set; }
        public Analytics analytics { get; set; }
        //public Applications applications { get; set; }
        public ArxControlAuthentication arx_control_authentication { get; set; }
        public string arx_control_service_guid { get; set; }
        public bool autostart { get; set; }

        [JsonProperty("battery/g733/warning")]
        public BatteryG733Warning BatteryG733Warning { get; set; }

        [JsonProperty("battery/prowirelessmouse/warning")]
        public BatteryProwirelessmouseWarning BatteryProwirelessmouseWarning { get; set; }


        [JsonProperty("battery/g733/percentage")]
        public BatteryG733Percentage BatteryG733Percentage { get; set; }

        [JsonProperty("battery/prowirelessmouse/percentage")]
        public BatteryProwirelessmousePercentage BatteryProwirelessmousePercentage { get; set; }


        public bool blue_voice_advanced_controls_enabled { get; set; }
        public string brand { get; set; }
        //public Cards cards { get; set; }
        public CrashReporting crash_reporting { get; set; }
        public DateTime created { get; set; }

        [JsonProperty("devices/known")]
        public DevicesKnown DevicesKnown { get; set; }
        public string home_layout { get; set; }
        public List<string> installed_integrations { get; set; }
        public IntegrationManagerSettings integration_manager_settings { get; set; }
        public string language { get; set; }
        public string last_run_version { get; set; }
        public LightingCustomPalette lighting_custom_palette { get; set; }
        public bool lighting_rgb_to_custom_migration_done { get; set; }
        public bool lighting_sleep { get; set; }
        public bool lock_notifications_enabled { get; set; }
        public bool low_battery_notifications_enabled { get; set; }
        public bool migration_shown { get; set; }
        public bool mouse_buttons_swapped { get; set; }
        public List<object> non_interactive_prompted { get; set; }
        public bool notifications_enabled { get; set; }
        public bool onboarding_shown { get; set; }
        public Persistent persistent { get; set; }
        //public Profiles profiles { get; set; }
        public string release_notes_build_id { get; set; }
        public List<string> seen_coach_marks { get; set; }
        public bool settings_transferred { get; set; }
    }

    public class Saturation
    {
        public string mode { get; set; }
        public int value { get; set; }
    }

    public class Settings
    {
        public Compressor compressor { get; set; }
        public DeEsser deEsser { get; set; }
        public DePopper dePopper { get; set; }
        public Expander expander { get; set; }
        public double inputGain { get; set; }
        public Limiter limiter { get; set; }
        public NoiseReduction noiseReduction { get; set; }
        public VoiceEq voiceEq { get; set; }
        public double volume { get; set; }
    }

    public class Sharpness
    {
        public string mode { get; set; }
        public int value { get; set; }
    }

    public class Tilt
    {
        public string mode { get; set; }
    }

    public class VideoSettings
    {
        public int antiFlicker { get; set; }
        public Brightness brightness { get; set; }
        public Color color { get; set; }
        public Contrast contrast { get; set; }
        public Gain gain { get; set; }
        public Gamma gamma { get; set; }
        public Hue hue { get; set; }
        public Saturation saturation { get; set; }
        public Sharpness sharpness { get; set; }
        public WhiteBalance whiteBalance { get; set; }
    }

    public class VoiceEq
    {
        public bool enabled { get; set; }
        public High high { get; set; }
        public Low low { get; set; }
        public Mid mid { get; set; }
    }

    public class WhiteBalance
    {
        public string mode { get; set; }
        public int value { get; set; }
    }

    public class Zoom
    {
        public string mode { get; set; }
        public int value { get; set; }
    }


}