using UnrealBuildTool;

public class MidTermAssignmentTarget : TargetRules
{
	public MidTermAssignmentTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("MidTermAssignment");
	}
}
