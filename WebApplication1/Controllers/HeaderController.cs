using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HeaderController : ControllerBase
    {
        TDEMDbContext db;
        public HeaderController(TDEMDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult GetHeaders()
        {
            return new JsonResult(db.Header);
        }

        [HttpPost]
        public IActionResult AddOrUpdateHeader([FromBody]Header header)
        {            
            if (db.Header.Any(p => p.FileName == header.FileName))
            {
                db.Update(header);
            }
            else db.Header.Add(header);
            
            db.SaveChanges();
            return new JsonResult(header);
        }
    }
}