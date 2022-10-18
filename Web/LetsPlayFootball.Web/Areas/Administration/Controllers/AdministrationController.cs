namespace LetsPlayFootball.Web.Areas.Administration.Controllers
{
    using LetsPlayFootball.Common;
    using LetsPlayFootball.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
