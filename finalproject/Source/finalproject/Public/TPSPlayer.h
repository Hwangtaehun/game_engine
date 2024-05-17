// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"
#include "TPSPlayer.generated.h"

UCLASS()
class FINALPROJECT_API ATPSPlayer : public ACharacter
{
	GENERATED_BODY()

public:
	// Sets default values for this character's properties
	ATPSPlayer();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

	// Called to bind functionality to input
	virtual void SetupPlayerInputComponent(class UInputComponent* PlayerInputComponent) override;

public:
	UPROPERTY(VisibleAnywhere, Category=Camera)
	class USpringArmComponent* springArmComp;
	UPROPERTY(VisibleAnywhere, BlueprintReadOnly, Category=Camera)
	class UCameraComponent* tpsCamComp;
	UPROPERTY(EditAnywhere, Category=PlayerSetting)
	float walkSpeed = 200.0f;
	UPROPERTY(EditAnywhere, Category=PlayerSetting)
	float runSpeed = 600.0f;
	UPROPERTY(VisibleAnywhere, Category=GunMesh)
	class USkeletalMeshComponent* gunMeshComp;
	UPROPERTY(EditDefaultsOnly, Category=BulletFactory)
	TSubclassOf<class ABullet> bulletFactory;
	UPROPERTY(VisibleAnywhere, Category=GunMesh)
	class UStaticMeshComponent* sniperGunComp;
	UPROPERTY(EditDefaultsOnly, Category=SniperUI)
	TSubclassOf<class UUserWidget> sniperUIFactory;
	UPROPERTY(EditAnywhere, Category=BulletEffect)
	class UParticleSystem* bulletEffectFactory;
	UPROPERTY(EditDefaultsOnly, Category = SniperUI)
	TSubclassOf<class UUserWidget> crosshairUIFactory;
	UPROPERTY(EditDefaultsOnly, Category = CameraMotion)
	TSubclassOf<class UCameraShakeBase> cameraShake;
	UPROPERTY(EditDefaultsOnly, Category = Sound)
	class USoundBase* bulletSound;
	class UUserWidget* _sniperUI;
	class UUserWidget* _crosshairUI;
	FVector direction;
	bool bUsingGrenadeGun = true;
	bool bSniperAim = false;

	void Turn(float value);
	void LookUp(float value);
	void InputHorisontal(float value);
	void InputVertical(float value);
	void InputJump();
	void Move();
	void InputFire();
	void ChangeToGrenadeGun();
	void ChangeToSniperGun();
	void SniperAim();
	void InputRun();

private:
	void checkEnemy(FHitResult hitInfo, float damage);
};
