using System;
using System.IO;
using Newtonsoft.Json;

namespace AshmawyX
{
    public static class SettingsManager
    {
        private static readonly string SettingsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings");
        private static readonly string SettingsFile = Path.Combine(SettingsFolder, "Settings.json");

        // ---------------------------------------------------------
        // LOAD SETTINGS
        // ---------------------------------------------------------
        public static AppSettings Load()
        {
            try
            {
                // Ensure folder exists
                if (!Directory.Exists(SettingsFolder))
                    Directory.CreateDirectory(SettingsFolder);

                // If file missing → create default
                if (!File.Exists(SettingsFile))
                {
                    AppSettings defaultSettings = new AppSettings();
                    Save(defaultSettings);
                    return defaultSettings;
                }

                string json = File.ReadAllText(SettingsFile);
                var settings = JsonConvert.DeserializeObject<AppSettings>(json);

                if (settings == null)
                    return new AppSettings();

                return settings;
            }
            catch
            {
                // Auto‑repair corrupted JSON
                AppSettings repaired = new AppSettings();
                Save(repaired);
                return repaired;
            }
        }

        // ---------------------------------------------------------
        // SAVE SETTINGS
        // ---------------------------------------------------------
        public static void Save(AppSettings settings)
        {
            try
            {
                if (!Directory.Exists(SettingsFolder))
                    Directory.CreateDirectory(SettingsFolder);

                string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText(SettingsFile, json);
            }
            catch
            {
                // If save fails, do nothing (never crash)
            }
        }
    }
}
