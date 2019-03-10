// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UMCRealisticGraspEditor : ModuleRules
{
	public UMCRealisticGraspEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
        bEnableUndefinedIdentifierWarnings = false;

        PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"UMCGrasp/Private",
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
                "UMCGrasp",
                "CoreUObject",
                "SkeletalMeshEditor",
                "SkeletonEditor",
                "StaticMeshEditor",
                "MainFrame",
                "Engine",
                "InputCore"
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
            "Projects",
            "UMCGrasp",
            "InputCore",
            "UnrealEd",
            "LevelEditor",
            "CoreUObject",
            "MainFrame",
            "AnimGraphRuntime",
            "Slate",
            "SlateCore",
            "Persona",
            "HeadMountedDisplay",
            "Core",
            "AnimGraph",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
