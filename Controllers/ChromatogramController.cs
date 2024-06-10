using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IonChromatogramApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChromatogramController : ControllerBase
    {
        [HttpGet("{ion}")]
        public IEnumerable<ChromatogramPoint> Get(string ion)
        {
            // Dummy data for demonstration purposes
            return new List<ChromatogramPoint>
            {
                new ChromatogramPoint { Time = 0, Intensity = 0 },
                new ChromatogramPoint { Time = 1, Intensity = 10 },
                new ChromatogramPoint { Time = 2, Intensity = 20 },
                new ChromatogramPoint { Time = 3, Intensity = 15 },
                new ChromatogramPoint { Time = 4, Intensity = 5 },
                new ChromatogramPoint { Time = 5, Intensity = 0 }
            };
        }

        public class ChromatogramPoint
        {
            public double Time { get; set; }
            public double Intensity { get; set; }
        }
    }
}