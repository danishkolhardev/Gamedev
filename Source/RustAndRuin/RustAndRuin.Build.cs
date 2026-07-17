using UnrealBuildTool;

public class RustAndRuin : ModuleRules
{
	public RustAndRuin(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { 
			"Core", 
			"CoreUObject", 
			"Engine", 
			"InputCore", 
			"EnhancedInput", 
			"Paper2D" 
		});

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
