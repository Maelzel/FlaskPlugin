using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Models;
using PoeHUD.Plugins;

namespace Flasker
{
    public class Plugin : BaseSettingsPlugin<Settings>
    {
        private string pluginVersion;

        public override void Initialise()
        {
            base.Initialise();
            PluginName = "Flasker";
            pluginVersion = "v1";
        }

        public override void Render()
        {
            base.Render();
        }

        public override void DrawSettingsMenu()
        {
            base.DrawSettingsMenu();
            Menu.DrawMenu(pluginVersion);
        }
    }
}
