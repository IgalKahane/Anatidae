using UnrealBuildTool;

public class AnatidaeServerTarget : TargetRules
{
	public AnatidaeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Anatidae");
	}
}
