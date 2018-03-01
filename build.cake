Task("Pack").Does(() => {
    DotNetCorePack("src/AwesomeTool", new DotNetCorePackSettings {
        OutputDirectory = "publish"
    });
});

var target = Argument("target", "Pack");
RunTarget(target);