namespace EasyPTC.Web.Controllers
{
	using EasyPTC.Web.Infrastructure.Filters;
	using System.Web.Http;

	[Authorize(Roles = "Admin")]
	[Log]
    public abstract class AdminController : BaseController
    {

    }
}