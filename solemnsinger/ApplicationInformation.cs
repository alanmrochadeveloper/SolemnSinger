using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solemnsinger
{
    public class ApplicationInformation
    {
        public ApplicationInformation(IConfiguration configuration)
        {
            Configuration = configuration;
            Name = Configuration["ApplicationInformation:Name"];
            URL = Configuration["ApplicationInformation:URL"];
        }
        private IConfiguration Configuration { get; }
        public string Name { get; }
        public string URL { get; }
    }
}
