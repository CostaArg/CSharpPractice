jscolor-nuget
=============

NuGet Package for **JSColor: JavaScript / HTML Color Picker**

This is just the source for [JSColor](http://jscolor.com/), and I just packed the sources and assets to work with ASP.NET MVC projects.

## Usage Instructions ##

Just add a reference to `/Scripts/jscolor.js`, directly or via bundling: 

**Direct Example**

    <script type="text/javascript" src="jscolor/jscolor.js"></script>

**Bundling Example**

At `/App_Start/BundleConfig.cs`:

    public static void RegisterBundles(BundleCollection bundles)
    {
        ...
    
        bundles.Add(new ScriptBundle("~/bundles/general").Include(
                    "~/Scripts/jscolor.js"));

        ...
    }