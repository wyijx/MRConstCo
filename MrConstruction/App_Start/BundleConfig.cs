﻿using System.Web;
using System.Web.Optimization;

namespace MrConstruction {
    public class BundleConfig {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      /*"~/Content/site.css"*/
                      "~/Content/navbar.css",
                      "~/Content/landing.css",
                      "~/Content/about.css",
                      "~/Content/login.css",
                      "~/Content/project-list.css",
                      "~/Content/project-details.css",
                      "~/Content/new-project.css",
                      "~/Content/contractorlist.css",
                      "~/Content/portfolioPage.css",
                      "~/Content/task-details.css",
                      "~/Content/modals.css",
                      "~/Content/upload.css",
                      "~/Content/animator.css"));

            bundles.Add(new ScriptBundle("~/angular/core").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-route.js",
                      "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                      "~/Scripts/angular-animate.js"));

            bundles.Add(new ScriptBundle("~/angular/app")
                .Include("~/Presentation/ngApp/app.js")
                .IncludeDirectory("~/Presentation/ngApp", "*.js", true));
        }
    }
}
