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
        // Enable
        public static ToggleNode AutoFlask { get; set; }
        // Health & Mana
        public static RangeNode<int> HealthPercent { get; set; }
        public static RangeNode<int> ManaPercent { get; set; }
        // Removers 
        public static ToggleNode RemovesFreeze { get; set; }
        public static ToggleNode RemovesBurning { get; set; }
        public static ToggleNode RemovesPoison { get; set; }
        public static ToggleNode RemovesShock { get; set; }
        public static ToggleNode RemovesBleeding { get; set; }
        public static ToggleNode RemovesCurses { get; set; }
        // Instant
        public static ToggleNode UseInstantHealth { get; set; }
        public static RangeNode<int> InstantHealthPercent { get; set; }
        public static ToggleNode UseInstantMana { get; set; }
        public static RangeNode<int> InstantManaPercent { get; set; }
        // Offensive
        public static ToggleNode UseOffensive { get; set; }
        public static RangeNode<int> OffensiveHealthPercent { get; set; }
        public static RangeNode<int> OffensiveEnergyPercent { get; set; }
        // Defensive
        public static ToggleNode UseDefensive { get; set; }
        public static RangeNode<int> DefensiveHealthPercent { get; set; }
        public static RangeNode<int> DefensiveEnergyPercent { get; set; }
        // Movement
        public static ToggleNode UseMovement { get; set; }
        public static ToggleNode UseMovementEverytime { get; set; }
        public static RangeNode<int> ReserveCharges { get; set; }
        public static RangeNode<int> EverySeconds { get; set; }

        public Settings()
        {
            // Enable
            AutoFlask = false;
            // Health & Mana
            HealthPercent = new RangeNode<int>(75, 0, 100);
            ManaPercent = new RangeNode<int>(75, 0, 100);
            // Removers
            RemovesFreeze = false;
            RemovesBurning = false;
            RemovesPoison = false;
            RemovesShock = false;
            RemovesBleeding = false;
            RemovesCurses = false;
            // Instant
            UseInstantHealth = false;
            InstantHealthPercent = new RangeNode<int>(35, 0, 100);
            UseInstantMana = false;
            InstantManaPercent = new RangeNode<int>(35, 0, 100);
            // Offensive
            UseOffensive = false;
            OffensiveHealthPercent = new RangeNode<int>(35, 0, 100);
            OffensiveEnergyPercent = new RangeNode<int>(35, 0, 100);
            // Defensive
            UseDefensive = false;
            DefensiveHealthPercent = new RangeNode<int>(35, 0, 100);
            DefensiveEnergyPercent = new RangeNode<int>(35, 0, 100);
            // Movement
            UseMovement = false;
            UseMovementEverytime = false;
            ReserveCharges = new RangeNode<int>(0, 0, 50);
            EverySeconds = new RangeNode<int>(0, 0, 10);
        }
    }
}
