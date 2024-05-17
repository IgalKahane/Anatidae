using UnrealBuildTool;

public class AnatidaeClientTarget : TargetRules
{
	public AnatidaeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Anatidae");
	}
}
