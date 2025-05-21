using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		[HttpGet(Name = "GetUser")]


		[HttpGet(Name = "GetAllUsers")]

		[HttpPut(Name = "UpdateUser")]

		[HttpDelete(Name = "DeleteUser")]


	}
}
