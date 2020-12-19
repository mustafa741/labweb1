using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lab2.Domain;
using lab2.Domain.Entities;

namespace lab2.Controllers
{
    [Route("api/TodoItems")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TodoItemsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceItem>>> GetServiceItems()
        {
            return await _context.ServiceItems.ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceItem>> GetServiceItem(Guid id)
        {
            var serviceItem = await _context.ServiceItems.FindAsync(id);

            if (serviceItem == null)
            {
                return NotFound();
            }

            return serviceItem;
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServiceItem(Guid id, ServiceItem serviceItem)
        {
            if (id != serviceItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(serviceItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TodoItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ServiceItem>> PostServiceItem(ServiceItem serviceItem)
        {
            _context.ServiceItems.Add(serviceItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServiceItem", new { id = serviceItem.Id }, serviceItem);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceItem>> DeleteServiceItem(Guid id)
        {
            var serviceItem = await _context.ServiceItems.FindAsync(id);
            if (serviceItem == null)
            {
                return NotFound();
            }

            _context.ServiceItems.Remove(serviceItem);
            await _context.SaveChangesAsync();

            return serviceItem;
        }

        private bool ServiceItemExists(Guid id)
        {
            return _context.ServiceItems.Any(e => e.Id == id);
        }
    }
}
