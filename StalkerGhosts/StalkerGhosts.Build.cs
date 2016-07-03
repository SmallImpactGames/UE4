// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class StalkerGhosts : ModuleRules
{
	public StalkerGhosts(TargetInfo Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" , "UMG", "Slate", "SlateCore"});
	}
}
