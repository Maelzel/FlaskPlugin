using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImGuiNET;
using PoeHUD.Controllers;
using PoeHUD.Plugins;
using SharpDX;

namespace Flasker
{
    public partial class Menu
    {
        public static void DrawMenu(string pluginVersion)
        {
            ImGui.BulletText("v"+ pluginVersion);


        }
    }
}
