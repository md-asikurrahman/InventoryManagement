using InventoryManagement.API.ApplicationUserFolder.ApplicationUseModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;

namespace InventoryManagement.API.ApplicationUserFolder
{
    [ApiController]
    [Route("api/[controller]")]

    public class ApplicationUsersController : ControllerBase
    {
        [HttpPost]
        //[SwaggerOperation(
        //Summary = "Update brand",
        //Description = "Update a brand using id",
        //OperationId = "Brand.Update")]
        [Route("Create-User")]
        public async Task<IActionResult> RegisterUser([FromBody] CreateUser createUser)
        {
            return Ok();
        }
    }
}
