using UnrealBuildTool;

public class GDS212_TemplateTarget : TargetRules
{
	public GDS212_TemplateTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("GDS212_Template");
	}
}
