using GameHub.Domain.Request.Social;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Installer
{
    public class FacebookAuthInstaller
    {
        public void InstallerServices(IServiceCollection services, IConfiguration configuration)
        {
            var facebookAuthSettings = new FacebookAuthSettings();
            configuration.Bind(nameof(FacebookAuthSettings), facebookAuthSettings);
            services.AddSingleton(facebookAuthSettings);

            services.AddHttpClient();
            //services.AddSingleton<ISocialRepository, SocialRepository>();
        }
    }
}
