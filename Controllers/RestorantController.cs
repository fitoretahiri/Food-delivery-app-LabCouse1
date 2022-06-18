﻿using Food_delivery_app_LabCouse1.Data;
using Food_delivery_app_LabCouse1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
=======
using System.Collections.Generic;
>>>>>>> login_functionality_branch
using System.Threading.Tasks;

namespace Food_delivery_app_LabCouse1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IConfiguration _configuration;
<<<<<<< HEAD
        private string path;

        private string placeholder;
=======
>>>>>>> login_functionality_branch

        public RestaurantController(IConfiguration configuration, ApplicationDbContext db)
        {
            _configuration = configuration;
            _db = db;
<<<<<<< HEAD
           /* path = Environment.CurrentDirectory;
            path = path.Replace(@"\API", @"\Photos\");*/
        }


       /* [HttpGet]

        public async Task<List<Restauranti>> getRestaurants()
        {

            var restaurants = _db.Restauranti;

            foreach (var rest in restaurants)
            {
                rest.Foto = getImage(rest.RestaurantID.ToString());
            }
            return await restaurants.ToListAsync();
        }

        [HttpGet("getImage")]
        public string getImage(string id)
        {
            try
            {
                byte[] test = System.IO.File.ReadAllBytes(path + id + ".png");
                return Convert.ToBase64String(test);
            }

            catch (Exception)
            {
                return placeholder;
            }
        }*/




         [HttpGet]
         public async Task<ActionResult<List<Restauranti>>> GetRestorantet()
         {
             return await _db.Restauranti.Include("Qyteti").ToListAsync();
         }


        //metoda per kerkim te restauranteve nga search bar
        [HttpGet("search/{str}")]
        public async Task<ActionResult<List<Restauranti>>> GetSearchAsync(string str)
        {
            var result = await _db.Restauranti.FromSqlRaw("SELECT * FROM dbo.Restauranti where emri like '" + str + "%'").ToListAsync();
            if(result.Count()<1)
            {
                return new JsonResult("Kerkimi juaj nuk u gjend!");
            }
            return result;
        }

        //metoda per te filtruar sipas qyteteve
        [HttpGet("filter/{id}")]
        public async Task<ActionResult<List<Restauranti>>> GetFiltersAsync(int id)
        {
            var result = await _db.Restauranti.FromSqlRaw("SELECT * FROM dbo.Restauranti where qytetiID like '" + id + "%'").ToListAsync();
            return result;
        }


        [HttpPost]
        public JsonResult addRestoranti(Restauranti restoranti){
                _db.Restauranti.Add(restoranti);
=======
        }

        [HttpGet]
        public async Task<ActionResult<List<Restaurant>>> GetRestorantet()
        {
            return await _db.Restaurant.Include("perdoruesi").ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurant>> GetRestoranti(int id)
        {
            return await _db.Restaurant.FindAsync(id);
        }

        [HttpPost]
        public JsonResult addRestoranti(Restaurant restoranti){
                _db.Restaurant.Add(restoranti);
>>>>>>> login_functionality_branch
                _db.SaveChanges();
                return new JsonResult("Restoranti u shtua me sukses");
        }

        [HttpPut]
<<<<<<< HEAD
        public JsonResult updateRestoranti(Restauranti restoranti)
        {
            _db.Restauranti.Update(restoranti);
=======
        public JsonResult updateRestoranti(Restaurant restoranti)
        {
            _db.Restaurant.Update(restoranti);
>>>>>>> login_functionality_branch
            _db.SaveChanges();

            return new JsonResult("Restoranti u perditesua me sukses");
        }

        [HttpDelete("{id}")]
        public JsonResult deleteRestoranti(int id)
        {
<<<<<<< HEAD
           var restoranti = _db.Restauranti.Find(id);
=======
           var restoranti = _db.Restaurant.Find(id);
>>>>>>> login_functionality_branch
           _db.Remove(restoranti);
           _db.SaveChanges();

            return new JsonResult("Restoranti u fshi me sukses");
        }
    }
}
