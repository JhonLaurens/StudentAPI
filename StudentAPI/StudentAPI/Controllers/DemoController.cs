using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {

        [HttpGet]
        public ActionResult<string> Greetings()
        {
            return "Hello World";
        }
        

        //CRUD - Create, Read, Update, Delete
        //Create - A a new record - POST
        //Read - retrieve a single record or a list of records - GET
        //Update - modify an existing record - PUT or PATCH
        //Delete - remove an existing record - DELETE

        //HTTP Verbs
        //GET - Read
        //POST - Create
        //PUT or PATCH - Update
        //DELETE - Delete


    }
}
