﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CheckIn2019.Startup))]
namespace CheckIn2019
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
