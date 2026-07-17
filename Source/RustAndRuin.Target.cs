using UnrealBuildTool;
using System.Collections.Generic;

public class RustAndRuinTarget : TargetRules
{
	public RustAndRuinTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("RustAndRuin");
	}
}
