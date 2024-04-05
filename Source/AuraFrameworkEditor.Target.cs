// Copyright Necther Louie Souribio

using UnrealBuildTool;
using System.Collections.Generic;

public class AuraFrameworkEditorTarget : TargetRules
{
	public AuraFrameworkEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "AuraFramework" } );
	}
}
