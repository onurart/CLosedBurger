﻿using Microsoft.Extensions.Options;
using ClosedBurger.Infrasturcture.Authentication;

namespace ClosedBurger.WebApi.OptionsSetup
{
    public sealed class JwtOptionsSetup : IConfigureOptions<JwtOptions>
    {
        private const string Jwt = nameof(Jwt);
        private readonly IConfiguration _configuration;
        public JwtOptionsSetup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void Configure(JwtOptions options)
        {
            _configuration.GetSection(Jwt).Bind(options);
        }
    }
}
