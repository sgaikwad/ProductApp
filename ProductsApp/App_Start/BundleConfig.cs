using System.Web.Optimization;

namespace ProductsApp.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
           // bundles.IgnoreList.Clear();

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/Site.css",
                "~/Content/bootstrap.min.css",
                "~/Content/bootstrap-responsive.min.css",
                "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                "~/Scripts/jquery-1.10.2.js",
                "~/Scripts/angular.js",
           "~/Scripts/bootstrap.js",
           "~/Scripts/angular-route.js"));

            
            bundles.Add(new ScriptBundle("~/bundles/Appjs").Include(
                "~/app/Run.js",
                "~/app/Directive/CustomDirective.js",
                "~/app/Controller/Search.js",
                "~/app/Controller/Details.js",
           "~/app/AppRoute.js",
           "~/app/Service/productService.js"
           ));
        }
    }
}


//C:\ProjectWork\Practise\ProductApp\ProductsApp\app\Run.js