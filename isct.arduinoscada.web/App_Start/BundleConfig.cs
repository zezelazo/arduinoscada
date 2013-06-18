using System.Web.Optimization;

namespace isct.arduinoscada.web.App_Start {
    public class BundleConfig {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.IgnoreList.Clear();
            AddDefaultIgnorePatterns(bundles.IgnoreList);
        }

        private static void AddDefaultIgnorePatterns(IgnoreList ignoreList) {
            throw new System.NotImplementedException();
        }
    }
}