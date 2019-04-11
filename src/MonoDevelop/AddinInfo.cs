using Mono.Addins;

[assembly:Addin ("FileNesting",
	Namespace = "MonoDevelop",
	Version = "0.1.2",
	Category = "IDE extensions")]

[assembly:AddinName ("FileNesting")]
[assembly:AddinDescription ("Adds File Nesting support.")]

[assembly:AddinDependency ("Core", "8.0")]
[assembly:AddinDependency ("Ide", "8.0")]
