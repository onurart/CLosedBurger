using Client.Core.Service.Model.Login;
using ClosedBurger.Client.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace ClosedBurger.Client.Controllers
{
    public class WebLoginController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        public WebLoginController(IHttpClientFactory httpClientFactory, IConfiguration configuration = null)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }
        public IActionResult SignIn()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(LoginCommand model)
        {
            var apiBaseUrl = _configuration["ApiSettings:BaseUrl"];
            var apiUrl = $"{apiBaseUrl}/Auth/Login";

            try
            {
                if (ModelState.IsValid)
                {
                    var client = _httpClientFactory.CreateClient();
                    var content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonData = await response.Content.ReadAsStringAsync();
                        var tokenModel = await response.Content.ReadFromJsonAsync<TokenRefreshTokenDto>();

                        if (tokenModel != null && tokenModel.data != null && tokenModel.data.token != null)
                        {
                            var token = new JwtSecurityToken(tokenModel.data.token.token);
                            var claims = token.Claims.ToList();
                            claims.Add(new Claim("token", tokenModel.data.token.token));

                            if (tokenModel.data.mainRole == "ADMIN")
                            {
                                claims.Add(new Claim(ClaimTypes.Role, "ADMIN"));
                                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                                var authProps = new AuthenticationProperties
                                {
                                    IsPersistent = true,
                                };

                                HttpContext.Session.SetString("Token", tokenModel.data.token.token);

                                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);

                                return RedirectToAction("Admin", "Admin");
                            }
                            else
                            {
                                claims.Add(new Claim(ClaimTypes.Role, "USER"));
                                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                                var authProps = new AuthenticationProperties
                                {
                                    IsPersistent = true,
                                };

                                HttpContext.Session.SetString("Token", tokenModel.data.token.token);

                                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);

                                return RedirectToAction("Index", "Home");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Sunucu yanıtı başarısız: " + response.ReasonPhrase);
                    }
                }

                return View(model);
            }
            catch (Exception ex)
            {
                return View("Error"); // Hata sayfasına yönlendirme yapabilirsiniz
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(LoginCommand model)
        {
            var apiBaseUrl = _configuration["ApiSettings:BaseUrl"];
            var apiUrl = $"{apiBaseUrl}/Auth/Login";
            try
            {
                if (ModelState.IsValid)
                {
                    var client = _httpClientFactory.CreateClient();

                    var content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(apiUrl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonData = await response.Content.ReadAsStringAsync();
                        var tokenModel = await response.Content.ReadFromJsonAsync<TokenRefreshTokenDto>();

                        var sss = tokenModel;
                        if (tokenModel != null && tokenModel.data.token != null)
                        {
                            var token = new JwtSecurityToken(tokenModel.data.token.token);
                            var claims = token.Claims.ToList();
                            claims.Add(new Claim("token", tokenModel.data.token.token));

                            // Diğer rolleri ekleyebilirsiniz
                            if (tokenModel.data.mainRole == "ADMIN")
                            {
                                claims.Add(new Claim(ClaimTypes.Role, "ADMIN"));
                            }
                            else
                            {
                                claims.Add(new Claim(ClaimTypes.Role, "USER"));
                            }

                            var claimsIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
                            var authProps = new AuthenticationProperties
                            {
                                IsPersistent = true,
                            };

                            HttpContext.Session.SetString("Token", tokenModel.data.token.token);

                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);

                            // Kullanıcının rolüne göre yönlendirme
                            if (tokenModel.data.mainRole == "ADMIN")
                            {
                                return RedirectToAction("Index", "Home");
                            }
                            else
                            {
                                return RedirectToAction("Index", "Home");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı");
                    }
                }
                return View(model);


                //return null;
            }
            catch (Exception ex)
            {
                return View("Error"); // Hata sayfasına yönlendirme yapabilirsiniz
            }
        }
        public async Task<IActionResult> Logout()
        {
            // Çıkış işlemi gerçekleştir
             HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme).Wait();
            return Ok();
        }
    }
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> SignIn(LoginCommand model)
    //{
    //    var apiBaseUrl = _configuration["ApiSettings:BaseUrl"];
    //    var apiUrl = $"{apiBaseUrl}/Auth/Login";

    //    try
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var client = _httpClientFactory.CreateClient();
    //            var content = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
    //            var response = await client.PostAsync(apiUrl, content);

    //            if (response.IsSuccessStatusCode)
    //            {
    //                var jsonData = await response.Content.ReadAsStringAsync();
    //                var tokenModel = await response.Content.ReadFromJsonAsync<TokenRefreshTokenDto>();

    //                if (tokenModel != null && tokenModel.data != null && tokenModel.data.token != null)
    //                {
    //                    var token = new JwtSecurityToken(tokenModel.data.token.token);
    //                    var claims = token.Claims.ToList();
    //                    claims.Add(new Claim("token", tokenModel.data.token.token));

    //                    // Diğer rolleri ekleyebilirsiniz
    //                    if (tokenModel.data.mainRole == "ADMIN")
    //                    {
    //                        claims.Add(new Claim(ClaimTypes.Role, "ADMIN"));
    //                    }
    //                    else
    //                    {
    //                        claims.Add(new Claim(ClaimTypes.Role, "USER"));
    //                    }

    //                    var claimsIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
    //                    var authProps = new AuthenticationProperties
    //                    {
    //                        IsPersistent = true,
    //                    };

    //                    HttpContext.Session.SetString("Token", tokenModel.data.token.token);

    //                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);

    //                    // Kullanıcının rolüne göre yönlendirme
    //                    return RedirectToAction("Index", "Home");
    //                }
    //                else
    //                {
    //                    ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı");
    //                }
    //            }
    //            else
    //            {
    //                ModelState.AddModelError(string.Empty, "Sunucu yanıtı başarısız: " + response.ReasonPhrase);
    //            }
    //        }

    //        return View(model);
    //    }
    //    catch (Exception ex)
    //    {
    //        return View("Error"); // Hata sayfasına yönlendirme yapabilirsiniz
    //    }
    //}

}


