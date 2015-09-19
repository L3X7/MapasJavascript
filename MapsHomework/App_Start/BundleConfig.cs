using System.Web;
using System.Web.Optimization;

namespace MapsHomework.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/contenido/js").Include(
               "~/js/bootstrap.min.js",
               "~/js/jquery-1.11.3.min.js"));

            bundles.Add(new StyleBundle("~/contenido/css").Include(
                "~/css/bootstrap.min.css",
                "~/css/style.css",
                "~/css/font-awesome.min.css"
                ));
        }
    }
}