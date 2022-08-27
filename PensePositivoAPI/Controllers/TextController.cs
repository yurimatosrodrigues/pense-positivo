using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PensePositivoAPI.Data;
using PensePositivoAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PensePositivoAPI.Controllers
{
    [ApiController]
    [Route(template:"v1")]
    public class TextController : ControllerBase
    {
        [HttpGet]
        [Route(template: "texts")]
        public async Task<IActionResult> GetAsync([FromServices] AppDbContext context)
        {
            var texts = await context
                .Texts
                .Include(c => c.Category)
                .Include(a => a.Author)
                .ToListAsync();

            return Ok(texts);
        }

        [HttpGet]
        [Route(template: "texts/{id}")]
        public async Task<IActionResult> GetByIdAsync([FromServices] AppDbContext context,
            [FromRoute]int id)
        {
            var text = await context
                .Texts
                .AsNoTracking()
                .FirstOrDefaultAsync(x=>x.Id == id);
            return text is null 
                ? NotFound() 
                : Ok(text);
        }

        [HttpGet]
        [Route(template: "random-texts")]
        public async Task<IActionResult> GetRandomTextsAsync([FromServices] AppDbContext context)
        {
            var randomText = new Random();           

            var text = await context
                .Texts
                .AsNoTracking()
                .ToListAsync();
                        
            return text is null
                ? NotFound()
                : Ok(text[randomText.Next(text.Count)].Description);
        }
    }
}