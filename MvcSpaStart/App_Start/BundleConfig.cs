﻿using System.Web.Optimization;

namespace MvcSpaStart
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
                "~/Scripts/DataTables/jquery.dataTables.js",
                "~/Scripts/DataTables/dataTables.bootstrap.js",
                "~/Scripts/DataTables/dataTables.buttons.js",
                "~/Scripts/DataTables/buttons.html5.js",
                "~/Scripts/DataTables/buttons.print.js",
                "~/Scripts/DataTables/buttons.colVis.js",
                "~/Scripts/DataTables/dataTables.fixedColumns.js"));

            bundles.Add(new StyleBundle("~/Content/DataTables/css/dataTables").Include(
                "~/Content/DataTables/css/jquery.dataTables.css",
                "~/Content/DataTables/css/buttons.dataTables.css",
                "~/Content/DataTables/css/fixedColumns.bootstrap.css"));
        }
    }
}
