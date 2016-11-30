using Mono.Addins;

[assembly:Addin ("FileNesting",
	Namespace = "MonoDevelop",
	Version = "0.1",
	Category = "IDE extensions")]

[assembly:AddinName ("FileNesting")]
[assembly:AddinDescription ("Adds File Nesting support.")]

[assembly:AddinDependency ("Core", "7.0")]
[assembly:AddinDependency ("Ide", "7.0")]
