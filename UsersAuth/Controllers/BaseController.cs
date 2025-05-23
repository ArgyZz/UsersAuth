using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public abstract class BaseController<TService> : Controller
	{
		private readonly TService _service;
		protected async Task<IActionResult> Process<TRequest, TResult>(TRequest request, Func<TService, Task<TResult>> action)
			where TRequest : class where TResult : class
		{
			var instantCode = Guid.NewGuid();
			try
			{
				//To-Do add logs
				var response = Ok(await action(_service));

				return response;
			}
			catch (Exception ex)
			{
				//To-Do add logs
				return Problem(ex.ToString());

			}
		}
	}
}
