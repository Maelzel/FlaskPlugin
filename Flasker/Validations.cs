using PoeHUD.Controllers;
using PoeHUD.Plugins;
using PoeHUD.Poe.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Controllers;
using PoeHUD.Poe.Components;
using SharpDX;

namespace Flasker
{
    public class Validations
    {
        private static Life life = BaseSettingsPlugin<Settings>.API.GameController.Game.IngameState.Data.LocalPlayer.GetComponent<Life>();
        private static Player player = BaseSettingsPlugin<Settings>.API.GameController.Game.IngameState.Data.LocalPlayer.GetComponent<Player>();
        private static Flask flask = BaseSettingsPlugin<Settings>.API.GameController.Game.IngameState.Data.LocalPlayer.GetComponent<Flask>();
        private static List<PoeHUD.Poe.RemoteMemoryObjects.Buff> buffs = BaseSettingsPlugin<Settings>.API.GameController.Game.IngameState.Data.LocalPlayer.GetComponent<Life>().Buffs.ToList();
        private static GameController gameController = BaseSettingsPlugin<Settings>.API.GameController;

        public static bool CanRender()
        {
            if (gameController.IsLoading)
                return false;
            if (!gameController.Game.IngameState.ServerData.IsInGame)
                return false;
            if (!IsPlayerValid())
                return false;
            if (gameController.Game.IngameState.IngameUi.AtlasPanel.IsVisible)
                return false;
            if (gameController.Game.IngameState.IngameUi.TreePanel.IsVisible)
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
            BaseSettingsPlugin<Settings>.API.LogMessage("Player is not valid", 5);
            return false;
        }

        public static bool CanUseHealthPotion()
        {
        
            if ()
            {
                return true;
            }
            return false;
        }
    }
}
