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
        public JsonResult Post(Useri user)
        {
            string query = @"
                    insert into dbo.Useri 
                    (emri,mbiemri,photoProfile,password,confirmPsw,roliID)
                    values 
                    (
                    '" + user.emri + @"'
                    ,'" + user.mbiemri + @"'
                    ,'" + user.photoProfile + @"'
                    ,'" + user.password + @"'
                    ,'" + user.confirmPsw +@"'
                    ,'" + user.roliID +@"')
                    ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    //Duhet me handle ni exception qe nese sosht nja prej numrave me qit error
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Put(Useri user)
        {
            string query = @"
                    update dbo.Useri set 
                    emri = '" + user.emri + @"'
                    ,mbiemri = '" + user.mbiemri + @"'
                    ,photoProfile = '" + user.photoProfile + @"'
                    ,password='"+ user.password +@"'
                    ,confirmPsw= '"+ user.confirmPsw+@"'
                    ,roliID= '"+ user.roli.role+ @"'
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

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                    delete from dbo.Useri
                    where userID = " + id + @" 
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

            return new JsonResult("Deleted Successfully");
        }
    }
}
