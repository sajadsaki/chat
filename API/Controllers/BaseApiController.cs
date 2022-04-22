namespace API.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

   [ApiController]
   [Route("[controller]")]
    public class BaseApiController:ControllerBase
    {
          private   IMediator _mediator;
          protected IMediator Mediator=>_mediator ??= HttpContext.RequestServices.GetService<IMediator>(); 
    }
}