using UnrealBuildTool;

public class AnatidaeTarget : TargetRules
{
	public AnatidaeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Anatidae");
	}
}
