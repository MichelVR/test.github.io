using System.Web;
using System.Web.Optimization;

namespace IdentitySample
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                   "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                   "~/Content/vendor/font-awesome/css/font-awesome.min.css",
                   "~/Content/vendor/datatables/dataTables.bootstrap4.css",
                   "~/Content/css/sb-admin.css",
                    "~/Content/estilo.css",
                      "~/Content/estilosRegistrar.css"

                   ));


            bundles.Add(new StyleBundle("~/bundles/js").Include(
                "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                "~/Content/vendor/jquery/jquery.min.js",
                  "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                  "~/Content/vendor/chart.js/Chart.min.js",
                  "~/Content/vendor/datatables/jquery.dataTables.js",
                  "~/Content/vendor/datatables/dataTables.bootstrap4.js",
                  "~/Content/js/sb-admin.min.js",
                  "~/Content/js/sb-admin-datatables.min.js",
                  "~/Content/js/sb-admin-charts.min.js"

                  ));
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
        }
    }
}
