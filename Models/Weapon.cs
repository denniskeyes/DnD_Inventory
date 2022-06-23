namespace DnD_Inventory.Models
{
    public class Weapon
    {
        public string Name { get; set; }
        public Attack? Attack { get; set; }
        public Damage? Dmg1 { get; set; }
        public Damage? Dmg2 { get; set; }
        public string? SavingThrow { get; set; }
        public string? SavingThrowDc { get; set; }
        public string? SaveEffect { get; set; }
        public string? Description { get; set; }
    }

    public class Attack
    {
        public string? Type { get; set; }
        public int? Modifier { get; set; }
        public bool? Proficient { get; set; }
        public string? Range { get; set; }
        public int? MagicBonus { get; set; }
        public int? CritRange { get; set; }
    }

    public class Damage
    {
        public string? DmgRoll { get; set; }
        public string? DmgModType { get; set; }
        public int? DmgExtra { get; set; }
        public string? Type { get; set; }
        public int? CritVal { get; set; }
    }
}
