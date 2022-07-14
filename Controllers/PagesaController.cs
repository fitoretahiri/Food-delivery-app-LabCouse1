using Food_delivery_app_LabCouse1.Data;
using Food_delivery_app_LabCouse1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Food_delivery_app_LabCouse1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesaController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IConfiguration _configuration;

        public PagesaController(IConfiguration configuration, ApplicationDbContext db)
        {
            _configuration = configuration;
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pagesa>>> GetPagesat()
        {
            return await _db.Pagesa.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pagesa>> GetPagesa(int id)
        {
            return await _db.Pagesa.FindAsync(id);
        }

        [HttpPost]
        public JsonResult addPagesa(Pagesa pagesa)
        {
            _db.Pagesa.Add(pagesa);
            _db.SaveChanges();
            return new JsonResult("Pagesa u regjistrua me sukses");
        }

        [HttpPut]
        public JsonResult updatePagesa(Pagesa pagesa)
        {
            _db.Pagesa.Update(pagesa);
            _db.SaveChanges();

            return new JsonResult("Pagesa u perditesua me sukses");
        }

        [HttpDelete("{id}")]
        public JsonResult deletePagesa(int id)
        {
            var pagesa = _db.Pagesa.Find(id);
            _db.Remove(pagesa);
            _db.SaveChanges();

            return new JsonResult("Pagesa u fshi me sukses");
        }
    }
}
