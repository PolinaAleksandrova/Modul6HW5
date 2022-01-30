using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Basket.Host.Controllers;

[ApiController]
[Authorize(Policy = AuthPolicy.AllowClientPolicy)]
[Scope("basket.basketitem")]
[Route(ComponentDefaults.DefaultRoute)]

    public class BasketItemController : ControllerBase
{

    }

