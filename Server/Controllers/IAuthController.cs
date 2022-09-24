using CrudAssessment.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudAssessment.Server.Controllers
{
    public interface IAuthController
    {
        Task<IActionResult> Login(UserInfo request);
        Task<IActionResult> Register(UserInfo parameters);
        Task<IActionResult> Logout();
        UserInfo CurrentUserInfo();
    }
}
