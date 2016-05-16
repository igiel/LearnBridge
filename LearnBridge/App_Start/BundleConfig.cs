using System.Web;
using System.Web.Optimization;

namespace LearnBridge
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/vendor/jquery-1.9.1.min.js",
                        "~/Scripts/vendor/bootstrap.min.js",
                        "~/Scripts/vendor/modernizr-2.6.2-respond-1.1.0.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/main").Include("~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/Content/site").Include(
                      "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/styles").Include(
                     "~/Content/Template/css/bootstrap.min.css",
                     "~/Content/Template/css/bootstrap-responsive.min.css",
                     "~/Content/Template/css/font-awesome.min.css",
                     "~/Content/Template/css/main.css",
                     "~/Content/Template/css/sl-slide.css"
                     ));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include
                ("~/Scripts/angular.min.js",
                "~/js/main.js"));
        }
    }
}
