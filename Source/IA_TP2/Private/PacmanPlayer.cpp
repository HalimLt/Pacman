// Fill out your copyright notice in the Description page of Project Settings.


#include "Public/PacmanPlayer.h"

// Sets default values
APacmanPlayer::APacmanPlayer()
{
 	// Set this pawn to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void APacmanPlayer::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called to bind functionality to input

void APacmanPlayer::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	PlayerInputComponent->BindAxis("MoveX", this, &APacmanPlayer::MoveX);
	PlayerInputComponent->BindAxis("MoveY", this, &APacmanPlayer::MoveY);
}

void APacmanPlayer::MoveX(float Value) { CurrentDirection.X = FMath::Clamp(Value, -1.f, 1.f); }
void APacmanPlayer::MoveY(float Value) { CurrentDirection.Y = FMath::Clamp(Value, -1.f, 1.f); }

void APacmanPlayer::Tick(float Delta)
{
	Super::Tick(Delta);
	if(!CurrentDirection.IsNearlyZero())
	{
		FVector NewLoc = GetActorLocation() + (CurrentDirection.GetSafeNormal() * MoveSpeed * Delta);
		SetActorLocation(NewLoc, true);
	}
}
