// Copyright Necther Louie Souribio

using UnrealBuildTool;
using System.Collections.Generic;

public class AuraFrameworkTarget : TargetRules
{
	public AuraFrameworkTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "AuraFramework" } );
	}
}
