using UnrealBuildTool;

public class AnatidaeEditorTarget : TargetRules
{
	public AnatidaeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Anatidae");
	}
}
