using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace UploadLocationAPI.Controllers
{
    [RoutePrefix("api/UploadLocation")]
    public class UploadLocationController : ApiController
    {
        public class LocationData
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public double accuracy { get; set; }
            public DateTime date { get; set; }
        }


        [Route("Post")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] LocationData location)
        {
            if(location == null)
            {
                return BadRequest("Invalid Location");
            }

            return Ok(location);
        }

        [Route("Get")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(123);
        }
    }

}
