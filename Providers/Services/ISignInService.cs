using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Models.DataModels;
using Models.Responses;

namespace Providers.Services;

/// <summary>
/// SignInManager<TUser> 래핑 클래스
/// </summary>
public interface ISignInService<in TUser> where TUser : User
{
    /// <summary>
    /// 사인 아웃
    /// </summary>
    /// <returns></returns>
    Task SignOutAsync();

    /// <summary>
    /// 유저정보로 강제로그인
    /// </summary>
    /// <param name="user">The user to sign-in.</param>
    /// <param name="isPersistent">Flag indicating whether the sign-in cookie should persist after the browser is closed.</param>
    /// <param name="authenticationMethod">Name of the method used to authenticate the user.</param>
    /// <returns>The task object representing the asynchronous operation.</returns>
    Task SignInAsync(TUser user, bool isPersistent, string? authenticationMethod = null);

    /// <summary>
    /// Returns true if the principal has an identity with the application cookie identity
    /// </summary>
    /// <param name="httpContext">The <see cref="T:System.Security.Claims.ClaimsPrincipal" /> instance.</param>
    /// <returns>True if the user is logged in with identity.</returns>
    Task<Response> IsSignedIn(HttpContext httpContext);
}