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
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration, ApplicationDbContext db)
        {
            _configuration = configuration;
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Useri>>> GetUsers()
        {
            return await _db.Useri.Include("roli").ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Useri>> GetUser(int id)
        {
            return await _db.Useri.FindAsync(id);
        }

        [HttpPost]
        public JsonResult addUser(Useri user){
                _db.Useri.Add(user);
                _db.SaveChanges();
                return new JsonResult("Perdoruesi u shtua me sukses");
        }

        [HttpPut]
        public JsonResult updateUser(Useri user)
        {
<<<<<<< Updated upstream
            _db.Useri.Update(user);
            _db.SaveChanges();
=======
            string query = @"
                    update dbo.Useri set 
                    emri = '" + user.emri + @"'
                    ,mbiemri = '" + user.mbiemri + @"'
                    ,photoProfile = '" + user.photoProfile + @"'
                    ,password='"+ user.password +@"'
                    ,confirmPsw= '"+ user.confirmPsw+@"'
                    where userID = " + user.userID + @" 
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
>>>>>>> Stashed changes

            return new JsonResult("Perdoruesi u perditesua me sukses");
        }

        [HttpDelete("{id}")]
        public JsonResult deleteUser(int id)
        {
           var user = _db.Useri.Find(id);
           _db.Remove(user);
           _db.SaveChanges();

            return new JsonResult("Perdoruesi u fshi me sukses");
        }
    }
}
