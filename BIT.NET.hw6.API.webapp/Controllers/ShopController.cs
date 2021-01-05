using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BIT.NET.hw6.API.webapp.Data;
using BIT.NET.hw6.API.webapp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BIT.NET.hw6.API.webapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ShopController<T> : ControllerBase where T : Item
    {
        private readonly IShopService<T> _service;

        public ShopController(IShopService<T> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<T>> GetAllItems()
        {
            return _service.GetAllItems().ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<T>> GetItem(int id)
        {
            var record = _service.GetItem(id);

            if (record == null)
                return NotFound();

            return Ok(record);
        }

        [HttpPost]
        public async Task<ActionResult<T>> CreateItem(T item)
        {
            _service.CreateItem(item);
            await _service.SaveAsync();

            return CreatedAtAction("GetItem", new { id = item.Id }, item);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<T>> DeleteItem(int id)
        {
            var item = _service.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }

            _service.DeleteItem(id);
            await _service.SaveAsync();

            return item;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, T item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _service.UpdateItem(item);

            await _service.SaveAsync();

            return NoContent();
        }
    }
}
