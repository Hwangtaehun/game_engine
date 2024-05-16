// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "deleteproject/deleteprojectGameModeBase.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodedeleteprojectGameModeBase() {}
// Cross Module References
	DELETEPROJECT_API UClass* Z_Construct_UClass_AdeleteprojectGameModeBase_NoRegister();
	DELETEPROJECT_API UClass* Z_Construct_UClass_AdeleteprojectGameModeBase();
	ENGINE_API UClass* Z_Construct_UClass_AGameModeBase();
	UPackage* Z_Construct_UPackage__Script_deleteproject();
// End Cross Module References
	void AdeleteprojectGameModeBase::StaticRegisterNativesAdeleteprojectGameModeBase()
	{
	}
	UClass* Z_Construct_UClass_AdeleteprojectGameModeBase_NoRegister()
	{
		return AdeleteprojectGameModeBase::StaticClass();
	}
	struct Z_Construct_UClass_AdeleteprojectGameModeBase_Statics
	{
		static UObject* (*const DependentSingletons[])();
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_AdeleteprojectGameModeBase_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_AGameModeBase,
		(UObject* (*)())Z_Construct_UPackage__Script_deleteproject,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_AdeleteprojectGameModeBase_Statics::Class_MetaDataParams[] = {
		{ "Comment", "/**\n * \n */" },
		{ "HideCategories", "Info Rendering MovementReplication Replication Actor Input Movement Collision Rendering Utilities|Transformation" },
		{ "IncludePath", "deleteprojectGameModeBase.h" },
		{ "ModuleRelativePath", "deleteprojectGameModeBase.h" },
		{ "ShowCategories", "Input|MouseInput Input|TouchInput" },
	};
#endif
	const FCppClassTypeInfoStatic Z_Construct_UClass_AdeleteprojectGameModeBase_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<AdeleteprojectGameModeBase>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_AdeleteprojectGameModeBase_Statics::ClassParams = {
		&AdeleteprojectGameModeBase::StaticClass,
		"Game",
		&StaticCppClassTypeInfo,
		DependentSingletons,
		nullptr,
		nullptr,
		nullptr,
		UE_ARRAY_COUNT(DependentSingletons),
		0,
		0,
		0,
		0x009002ACu,
		METADATA_PARAMS(Z_Construct_UClass_AdeleteprojectGameModeBase_Statics::Class_MetaDataParams, UE_ARRAY_COUNT(Z_Construct_UClass_AdeleteprojectGameModeBase_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_AdeleteprojectGameModeBase()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_AdeleteprojectGameModeBase_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(AdeleteprojectGameModeBase, 497982080);
	template<> DELETEPROJECT_API UClass* StaticClass<AdeleteprojectGameModeBase>()
	{
		return AdeleteprojectGameModeBase::StaticClass();
	}
	static FCompiledInDefer Z_CompiledInDefer_UClass_AdeleteprojectGameModeBase(Z_Construct_UClass_AdeleteprojectGameModeBase, &AdeleteprojectGameModeBase::StaticClass, TEXT("/Script/deleteproject"), TEXT("AdeleteprojectGameModeBase"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(AdeleteprojectGameModeBase);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
