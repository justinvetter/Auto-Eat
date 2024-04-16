using StardewModdingAPI;

namespace AutoEat
{
    public class ModConfig
    {
        public float StaminaThreshold { get; set; } = 8.0f;
        public bool EnableStamina { get; set; } = true;
        public float HealthThreshold { get; set; } = 32.0f;
        public bool EnableHealth { get; set; } = true;
        public bool DynamicStaminaThreshold { get; set; } = false;
        public bool PreferHigherInventory { get; set; } = true;
        public bool EnableCoffee { get; set; } = false;
    }
}
