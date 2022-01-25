#region
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using REAccess.Mobile.Api.Controllers.Attributes;
using REAccess.Mobile.Api.Extensions;
using REAccess.Mobile.Common.Utils;
using REAccess.Mobile.Database.Models;
using REAccess.Mobile.Database.Utils;
#endregion

namespace REAccess.Mobile.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>();

            services.AddControllers();

            NativeInjectorBootStrapper.RegisterServices(services);

            #region CORS
            services.AddCors(c =>
            {
                c.AddPolicy("cors", policy =>
                {
                    policy
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });
            #endregion

            #region 添加Swagger
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1.0.0",
                    Title = "REAccess Mobile API",
                    Description = "框架说明文档",
                    Contact = new OpenApiContact
                    {
                        Name = "John Jiang",
                        Email = "1033596188@qq.com",
                    }
                });
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);//获取应用程序所在目录
                var xmlPath = Path.Combine(basePath, "Swagger.xml");
                options.IncludeXmlComments(xmlPath);
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime appLife)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseForwardedHeaders(new ForwardedHeadersOptions { ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiHelp V1");
            });

            //这是添加的扩张方法
            //设置访问文件
            app.UseStaticFiles(new StaticFileOptions
            {
                //配置除了默认的wwwroot文件中的静态文件以外的文件夹提供 Web 根目录外的文件 ,
                //经过此配置以后，就可以访问非wwwroot文件下的文件
                FileProvider = new PhysicalFileProvider(
                  Path.Combine(Directory.GetCurrentDirectory(), "RealTimeInfoImgs")),
                RequestPath = "/RealTimeInfoImgs",
            });

            app.UseCors();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            appLife.ApplicationStarted.Register(() =>
            {
                //app启动后运行的程序
                //将静态数据加载至静态类作为缓存使用
                StaticCache.RefreshCache(null);
                //app启动后运行的程序
                //将大于500kb的资讯图片 压缩处理
                ImageHelper.MagickImage();

                Console.Write("ApplicationStarted");
            });
        }
    }
}
