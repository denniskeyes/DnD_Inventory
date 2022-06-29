using DnD_Inventory.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnD_Inventory.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class Controller : ControllerBase
    {
        // Temporary sample data
        private Weapon DragonAxe = new Weapon
        {
            Name = "Dragon-Kindled Bonesword",
            Attack = new Attack
            {
                Type = "STR",
                Modifier = 3,
                Proficient = true,
                Range = "15 ft",
                MagicBonus = null,
                CritRange = 15
            },
            Damage1 = new Damage
            {
                DmgRoll = "3d4",
                DmgModType = "STR",
                DmgExtra = 1,
                Type = "Shadow+Slashing",
                CritVal = null
            },
            SavingThrow = null,
            SavingThrowDc = null,
            SaveEffect = null,
            Description = null
        };
        private Weapon BlackRazor = new Weapon
        {
            Name = "Black Razor",
            Attack = new Attack
            {
                Type = "STR",
                Modifier = null,
                Proficient = true,
                Range = null,
                MagicBonus = 3,
                CritRange = 15
            },
            Damage1 = new Damage
            {
                DmgRoll = "2d6",
                DmgModType = "STR",
                DmgExtra = null,
                Type = "Slashing",
                CritVal = null
            },
            SavingThrow = null,
            SavingThrowDc = null,
            SaveEffect = null,
            Description = null
        };
        private Weapon HeavensEdge = new Weapon
        {
            Name = "Heaven's Edge",
            Attack = new Attack
            {
                Type = "STR",
                Modifier = 3,
                Proficient = true,
                Range = null,
                MagicBonus = null,
                CritRange = 15
            },
            Damage1 = new Damage
            {
                DmgRoll = "2d6",
                DmgModType = "STR",
                DmgExtra = 3,
                Type = "Slashing",
                CritVal = null
            },
            SavingThrow = null,
            SavingThrowDc = null,
            SaveEffect = null,
            Description = null
        };

        private Gear BlueNecklace = new Gear
        {
            Name = "Necklace of Blue Health",
            Description = "+3 CON, proficiency/expertise in con saves (already done in char stats)"
        };
        private Gear FeatherRing = new Gear
        {
            Name = "Ring of Feather Fall",
            Description = "Reaction to cast Feather Fall(1 / Day)"
        };
        private Gear EnlargeRing = new Gear
        {
            Name = "Ring of Enlarge",
            Description = "Enlarge spell (3/Day)"
        };

        private Gear ElvesPlate = new Gear
        {
            Name = "Half-Plate of the Elves",
            Description = @"-17+2DEX AC,
                            Medium Armor - Action - The armor begins to shiftcolors and meld into the surroundings, you gain Advantage on Stealth Checks, and enemies receive Disadvantage on Perception Checks, while trying to Hide. (Lasts 1 Min)"
        };
        private Gear RedScaleCloak = new Gear
        {
            Name = "Red Scale Cloak of Brimstone",
            Description = @"1/Day Dimension Door as an Action 
                            1/Day Sprout Red Dragon Wings for 1 Min"
        };
        private Gear LeapingBoots = new Gear
        {
            Name = "Boots of Leaping",
            Description = @"+5 movement 
                            Leap and Crush(1 / day): DC 16 DEX or Knocked Prone, Bonus Action Weapon Attack"
        };

        private List<Weapon> Weapons;
        private List<Gear> Accessories;
        private List<Gear> Armor;

        public Controller()
        {
            Weapons = new List<Weapon> { DragonAxe, BlackRazor, HeavensEdge };
            Accessories = new List<Gear> { BlueNecklace, FeatherRing, EnlargeRing };
            Armor = new List<Gear> { ElvesPlate, RedScaleCloak, LeapingBoots };
        }

        [HttpGet("get-weapons/{character}")]
        public IEnumerable<Weapon> GetWeapons(string character)
        {
            return Weapons;
        }

        [HttpGet("get-armor/{character}")]
        public IEnumerable<Gear> GetArmor(string character)
        {
            return Armor;
        }

        [HttpGet("get-accessories/{character}")]
        public IEnumerable<Gear> GetAccessories(string character)
        {
            return Accessories;
        }

        // POST api/<Controller>/add-weapon
        [HttpPost("add-weapon")]
        public void AddWeapon([FromBody] string value)
        {
        }

        // POST api/<Controller>/add-armor
        [HttpPost("add-armor")]
        public void AddArmor([FromBody] string value)
        {
        }

        // POST api/<Controller>/add-weapon
        [HttpPost("add-weapon")]
        public void AddAccessory([FromBody] string value)
        {
        }

        // PUT api/<Controller>/update
        [HttpPut("update")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Controller>/delete
        [HttpDelete("delete")]
        public void Delete(int id)
        {
        }
    }
}
