using Microsoft.AspNetCore.Mvc;

namespace DnD_Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        // GET: api/<Controller>
        [HttpGet("get-all")]
        public IEnumerable<string> GetAllInventory()
        {
            return new string[] {  };
        }

        // GET api/<Controller>/character
        [HttpGet("{character}")]
        public string GetCharacterInventory(string character)
        {
            return "value";
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
