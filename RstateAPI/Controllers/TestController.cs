using Microsoft.AspNetCore.Mvc;

namespace RstateAPI.Controllers
{
    [ApiController] 
    [Route("api/[controller]")]
    public class TestController:ControllerBase
    {
        public TestController()
        {
            
        }
        [HttpGet]
        public string GetData(){
            return "ghjbk";
        }
    }
}