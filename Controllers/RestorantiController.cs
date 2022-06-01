using Food_delivery_app_LabCouse1.Data;
using Food_delivery_app_LabCouse1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Food_delivery_app_LabCouse1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestorantiController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IConfiguration _configuration;

        public RestorantiController(IConfiguration configuration, ApplicationDbContext db)
        {
            _configuration = configuration;
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Restoranti>>> GetRestorantet()
        {
            return await _db.Restoranti.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Restoranti>> GetRestoranti(int id)
        {
            return await _db.Restoranti.FindAsync(id);
        }

        [HttpPost]
        public JsonResult addRestoranti(Restoranti restoranti){
                _db.Restoranti.Add(restoranti);
                _db.SaveChanges();
                return new JsonResult("Restoranti u shtua me sukses");
        }

        [HttpPut]
        public JsonResult updateRestoranti(Restoranti restoranti)
        {
            _db.Restoranti.Update(restoranti);
            _db.SaveChanges();

            return new JsonResult("Restoranti u perditesua me sukses");
        }

        [HttpDelete("{id}")]
        public JsonResult deleteRestoranti(int id)
        {
           var restoranti = _db.Restoranti.Find(id);
           _db.Remove(restoranti);
           _db.SaveChanges();

            return new JsonResult("Restoranti u fshi me sukses");
        }
    }
}
