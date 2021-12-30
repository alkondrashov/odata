using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using OData.Models;
using OData.Data;

namespace OData.Controllers
{
    public class CarsController : ODataController
    {
        private ODataContext _context;
        private readonly ILogger<CarsController> _logger;

        public CarsController(ODataContext context, ILogger<CarsController> logger) {
            _context = context;
            _logger = logger;

            if (_context.Cars.Count() == 0)
            {
                foreach (var b in DataSource.GetCars())
                {
                    _context.Cars.Add(b);
                }
                _context.SaveChanges();
            }
        }


        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_context.Cars);
        }

        [EnableQuery]
        public IActionResult Get(int key)
        {
            return Ok(_context.Cars.FirstOrDefault(c => c.Id == key));
        }
    }
}