using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;
using SharpDX;

namespace Flasker
{
    public class Settings : SettingsBase
    {
        public static RangeNode<int> HealthPercent { get; set; }
        public static RangeNode<int> ManaPercent { get; set; }
        public static ToggleNode AutoFlask { get; set; }

        public Settings()
        {
            HealthPercent = new RangeNode<int>(75, 0, 100);
            ManaPercent = new RangeNode<int>(75, 0, 100);
            AutoFlask = false;
        }
    }
}
