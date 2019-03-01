using PoeHUD.Controllers;
using PoeHUD.Plugins;
using PoeHUD.Poe.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIO
{
    public class Validations
    {
        public static bool CanRender()
        {
            if (BaseSettingsPlugin<Settings>.API.GameController.IsLoading)
                return false;
            if (!BaseSettingsPlugin<Settings>.API.GameController.Game.IngameState.ServerData.IsInGame)
                return false;
            if (!IsPlayerValid())
                return false;
            if (BaseSettingsPlugin<Settings>.API.GameController.Game.IngameState.IngameUi.AtlasPanel.IsVisible)
                return false;
            if (BaseSettingsPlugin<Settings>.API.GameController.Game.IngameState.IngameUi.TreePanel.IsVisible)
                return false;
            return true;
        }

        public static bool IsPlayerValid()
        {
            if (BaseSettingsPlugin<Settings>.API.GameController.Player == null || BaseSettingsPlugin<Settings>.API.GameController.Player.Address != 0 ||
                BaseSettingsPlugin<Settings>.API.GameController.Player.IsAlive || BaseSettingsPlugin<Settings>.API.GameController.Player.IsValid)
            {
                return true;
            }
            return false;
        }
    }
}
