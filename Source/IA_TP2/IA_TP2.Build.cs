// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class IA_TP2 : ModuleRules
{
	public IA_TP2(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"IA_TP2",
			"IA_TP2/Variant_Platforming",
			"IA_TP2/Variant_Platforming/Animation",
			"IA_TP2/Variant_Combat",
			"IA_TP2/Variant_Combat/AI",
			"IA_TP2/Variant_Combat/Animation",
			"IA_TP2/Variant_Combat/Gameplay",
			"IA_TP2/Variant_Combat/Interfaces",
			"IA_TP2/Variant_Combat/UI",
			"IA_TP2/Variant_SideScrolling",
			"IA_TP2/Variant_SideScrolling/AI",
			"IA_TP2/Variant_SideScrolling/Gameplay",
			"IA_TP2/Variant_SideScrolling/Interfaces",
			"IA_TP2/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
