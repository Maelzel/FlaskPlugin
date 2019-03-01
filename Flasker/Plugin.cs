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
        private Validations validations = new Validations();

        public override void Initialise()
        {
            base.Initialise();
            PluginName = "Flasker";
        }

        public override void Render()
        {
            base.Render();
            Menu.DrawMenu();
        }
    }
}
