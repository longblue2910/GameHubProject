using GameHub.DAL.Implement;
using GameHub.DAL.Interface;
using GameHub.Domain.Request.Social;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameHub.API.Installers
{
    public class FacebookAuthInstaller
    {
        public void InstallerServices(IServiceCollection services, IConfiguration configuration)
        {
            var facebookAuthSettings = new FacebookAuthSettings();
            configuration.Bind(nameof(FacebookAuthSettings), facebookAuthSettings);
            services.AddSingleton(facebookAuthSettings);

            services.AddHttpClient();
            services.AddSingleton<ISocialRepository, SocialRepository>();
        }
    }
}
