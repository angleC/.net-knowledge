using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Example03
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            ////强制使用https跳转
            //app.UseHttpsRedirection();
            ////使用静态文件
            //app.UseStaticFiles();
            ////使用cookie代理
            //app.UseCookiePolicy();
            ////权限
            //app.UseAuthentication();
            ////session，调用在CookiePolicy之后，在MVC之前
            //app.UseSession();
            ////mvc请求管道
            //app.UseMvc();

            app.Map("/map1", HandlerMapTest1);

            app.Use(async (context, next) =>
            {
                context.Response.ContentType = "text/plain; charset=utf-8";//更改响应内容为utf8解码，解决中文字符串乱码问题
                await context.Response.WriteAsync("before::第一个委托\r\n");
                //调用管道中的下一个委托
                await next();
                await context.Response.WriteAsync("\r\nafter::第一个委托\r\n");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("\r\nbefore::第二个委托\r\n");
                //调用管道中的下一个委托
                await next();
                await context.Response.WriteAsync("\r\nafter::第二个委托\r\n");
            });

            app.Map("/map2", HandlerMapTest2);

            app.MapWhen(context => context.Request.Query.ContainsKey("branch"), HandlerMapTest3);

            app.Map("/level1", level1App =>
            {
                level1App.Map("/level2a", HandlerMapTest4);
                level1App.Map("/level2b", level2BApp =>
                {
                    // "/level1/level2b" processing
                });
            });

            app.Map("/map1/seg1", HandlerMapTest5);

            app.Run(async context =>
            {
                //context.Response.ContentType = "text/plain; charset=utf-8";//该行代码不应该再次使用，因为会引发后续中间组件委托无法调用
                await context.Response.WriteAsync("\r\n进入第三个委托\r\n");
                await context.Response.WriteAsync("\r\nHello from 2nd delegate.\r\n");
                await context.Response.WriteAsync("\r\n结束第三个委托\r\n");
            });
        }

        public static void HandlerMapTest1(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                context.Response.ContentType = "text/plain; charset=utf-8";
                await context.Response.WriteAsync("\r\nbefore::MapTest1第二个委托\r\n");
                //调用管道中的下一个委托
                await next();
                await context.Response.WriteAsync("\r\nafter::MapTest1第二个委托\r\n");
            });

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Map Test 1");
            });
        }

        public static void HandlerMapTest2(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Map Test 2");
            });
        }

        public static void HandlerMapTest3(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                var branchVer = context.Request.Query["branch"];
                await context.Response.WriteAsync($"Branch used = {branchVer}");
            });
        }

        public static void HandlerMapTest4(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("/level1/level2a");
            });
        }

        public static void HandlerMapTest5(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("/map1/seg1");
            });
        }
    }
}
