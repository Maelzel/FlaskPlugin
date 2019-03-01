using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImGuiNET;
using PoeHUD.Controllers;
using PoeHUD.Plugins;
using SharpDX;
using TreeSharp;
using TreeRoutine.Menu;

namespace Flasker
{
    public partial class Menu
    {
        public static void DrawMenu()
        {
            TreeNodeFlags collapsingHeaderFlags = TreeNodeFlags.CollapsingHeader;

            if (ImGui.TreeNodeEx("Plugin Options",collapsingHeaderFlags))
            {
                if (Validations.CanRender())
                {
                    if (ImGui.TreeNodeEx("Health and Mana", collapsingHeaderFlags))
                    {
                        Settings.AutoFlask.Value = ImGuiExtension.Checkbox("Enable", Settings.AutoFlask);

                        ImGuiExtension.SpacedTextHeader("Settings");
                        ImGuiExtension.SpacedTextHeader("Health Flask");
                        Settings.HealthPercent.Value = ImGuiExtension.IntSlider("Min Life % Auto HP Flask", Settings.HealthPercent);
                        
                        ImGuiExtension.SpacedTextHeader("Mana Flask");
                        ImGui.Spacing(); Settings.ManaPercent.Value = ImGuiExtension.IntSlider("Min Mana % Auto Mana Flask", Settings.ManaPercent);
                        ImGui.TreePop();
                    }
                }
            }
        }
    }
}
