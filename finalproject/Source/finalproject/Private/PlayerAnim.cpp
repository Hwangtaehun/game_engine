// Fill out your copyright notice in the Description page of Project Settings.


#include "PlayerAnim.h"
#include "TPSPlayer.h"

void UPlayerAnim::NativeUpdateAnimation(float DeltaSends)
{
	Super::NativeUpdateAnimation(DeltaSends);

	auto ownerPawn = TryGetPawnOwner();
	auto player = Cast<ATPSPlayer>(ownerPawn);

	if (player) {
		FVector velocity = player->GetVelocity();
		FVector forwardVector = player->GetActorForwardVector();
		speed = FVector::DotProduct(forwardVector, velocity);
	}
}
