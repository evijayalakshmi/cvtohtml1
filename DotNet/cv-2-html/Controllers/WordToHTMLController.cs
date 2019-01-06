using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cv_2_html.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordToHTMLController : ControllerBase
    {
        [HttpGet("[action]")]
        public bool Convert() {
            return true;
        }
    }
}