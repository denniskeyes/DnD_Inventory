using Microsoft.AspNetCore.Mvc;

namespace DnD_Inventory.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class Controller : ControllerBase
    {
        // Temporary sample data
        private List<string> Weapons = new List<string> { "Black Razor", "Heaven's Edge", "Dragon-Kindled Bonesword" };
        private List<string> Accessories = new List<string> { "Necklace of Blue Health", "Ring of Feather Fall", "Ring of Enlarge" };
        private List<string> Armor = new List<string> { "Half-Plate of the Elves", "Red Scale Cloak of Brimstone", "Boots of Leaping" };

        [HttpGet("get-weapons/{character}")]
        public IEnumerable<string> GetWeapons(string character)
        {
            return Weapons;
        }

        [HttpGet("get-armor/{character}")]
        public IEnumerable<string> GetArmor(string character)
        {
            return Armor;
        }

        [HttpGet("get-accessories/{character}")]
        public IEnumerable<string> GetAccessories(string character)
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
