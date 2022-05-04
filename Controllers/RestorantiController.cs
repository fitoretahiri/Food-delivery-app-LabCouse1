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

        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Restoranti obj)
        {
            _db.Restoranti.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        */

        [HttpPost]
        public JsonResult Post(Restoranti restoranti)
        {
            string query = @"
                    insert into dbo.Restoranti 
                    (emri,qyteti,adresa,nr_kontaktues,data_regjistrimit)
                    values 
                    (
                    '" + restoranti.emri + @"'
                    ,'" + restoranti.qyteti + @"'
                    ,'" + restoranti.adresa + @"'
                    ,'" + restoranti.nr_kontaktues + @"'
                    ,'" + restoranti.data_regjistrimit + @"'
                    )
                    ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader); 

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }
    }
}
