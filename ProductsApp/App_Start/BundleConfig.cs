using System.Web.Optimization;

namespace ProductsApp.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs").Include(
                "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include("~/Content/Site.css",
                "~/Content/bootstrap.min.css",
                "~/Content/bootstrap-responsive.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/customjs").Include(
           "~/Scripts/CustomScript.js"));

        }
    }
}