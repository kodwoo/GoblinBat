using System.Linq;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ShareInvest
{
    public class Startup
    {
        public IConfiguration Configuration
        {
            get;
        }
        public void ConfigureServices(IServiceCollection services) => services.AddDbContext<CoreAPI.CoreApiDbContext>(o => o.UseSqlServer(Configuration[connection])).AddControllersWithViews(o => o.InputFormatters.Insert(0, GetJsonPatchInputformatter())).AddMvcOptions(o => o.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Latest);
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) => app.UseMvc();
        public Startup(IConfiguration configuration) => Configuration = configuration;
        static NewtonsoftJsonInputFormatter GetJsonPatchInputformatter() => new ServiceCollection().AddLogging().AddMvc().AddNewtonsoftJson().Services.BuildServiceProvider().GetRequiredService<IOptions<MvcOptions>>().Value.InputFormatters.OfType<NewtonsoftJsonPatchInputFormatter>().First();
        const string connection = "Data:CommandAPIConnection:ConnectionString";
    }
}