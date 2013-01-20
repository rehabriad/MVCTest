using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using AttributeRouting;

[assembly: WebActivator.PreApplicationStartMethod(typeof(SocialFruits.App_Start.AttributeRouting), "PreStart")]
[assembly: WebActivator.PostApplicationStartMethod(typeof(SocialFruits.App_Start.AttributeRouting), "PostStart")]

namespace SocialFruits.App_Start
{
    public static class AttributeRouting
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //
            routes.IgnoreRoute("elmah.axd");
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });
            //Skip static files
            routes.IgnoreRoute("{*staticfile}", new { staticfile = @".*\.(jpg|gif|jpeg|png|css|js)$" });


            // See http://github.com/mccalltd/AttributeRouting/wiki/3.-Configuration for more options.
            // To debug routes locally using the built in ASP.NET development server, go to /routes.axd
            routes.MapAttributeRoutes(config =>
            {
                config.ScanAssembly(Assembly.GetExecutingAssembly());
                config.AutoGenerateRouteNames = true; //Essential for duplicate actions with GET and POST or same action with both GET POST
                //IMPORTANT: don't use the following or else it will do redirects and remove port number which won't work with AppHarbor
                config.UseLowercaseRoutes = false;
                config.AddDefaultRouteConstraint(@"^id$", new RegexRouteConstraint(@"^\d+$"));
            });

            //
            //                                   DON'T   DELETE   THE     FOLLOWING
            //
            //This is essential for:
            // -Letting domain.com open default action
            // -When generating urls with T4MVC for actions that contain parameters but we expect the path to be empty
            //  Example:
            //      For MyController.GetUpdates(long id), Url.Action(MVC.My.GetUpdates()) will result in an empty string instead of "/my/getupdates"
            //      It doesnt matter if the controller is decorated with [GET("GetUpdates/{id}")] or [POST("GetUpdates/{id}")]


            //routes.MapRoute(
            //    "Default_app", // Route name
            //    "App/{pageid}/{controller}/{action}/{id}", // URL with parameters
            //   new { pageid = "0", controller = "Home", action = "index", id = UrlParameter.Optional },
            //   new string[] {"SocialFruits.Controllers"} // Parameter defaults
            //);




            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                MVC.Home.Index(),
                new { id = UrlParameter.Optional }, // Parameter defaults
                new string[] { "SocialFruits.Controllers" }
            );

            ////Catch reamining routes
            //routes.MapRoute("catch-all", "{*catchall}", MVC.Error.NotFound(),
            //    new string[] { "SocialFruits.Controllers" }
            //    );


        }

        public static void PreStart()
        {
            RegisterRoutes(RouteTable.Routes);

        }


        public static void PostStart()
        {
            AreaRegistration.RegisterAllAreas();

        }
    }
}
