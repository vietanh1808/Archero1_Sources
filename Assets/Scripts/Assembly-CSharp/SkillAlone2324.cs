using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone2324 : SkillAlonePetBase
{
	private int jumpCount;

	private float aoeDamagePercent;

	private float aoeRadius;

	private float lastJumpAoeDamagePercent;

	private float lastJumpAoeRadius;

	private float clearBulletRadius;

	private int returnDamageBuffId;

	private float damageBuffDuration;

	private float jumpInterval;

	private float atkPercent;

	private float deltaAtkPercent;

	private int bulletDebuffId;

	private float criteRatePercent;

	private float baseCustomCritValuePercent;

	private float critValuePercent;

	private int mutationLevel;

	private float mutationEnergyRestore;

	private float heroHitEnergyRestore;

	private float heroAttackSpeedRatio;

	private long _appliedPetAttackSpeedDelta;

	private SequencePool sequencePool;

	private Vector3 originPos;

	private int currentJumpIndex;

	private HashSet<int> usedTargets;

	private bool isInterrupted;

	private float skillAnimSpeedDiff;

	private string currentJumpAnimName;

	private bool _isJumping;

	private bool isJumping
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private EntityBase PlayerEntity => null;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void WriteEntityAttributes()
	{
	}

	private void OnPetAppear(BattlePetVO battlePetData)
	{
	}

	private void OnPetDisappear(BattlePetVO battlePetData)
	{
	}

	private void OnPetSkillStatusChange(PetEnergyVO.PetSkillStatus status)
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void ExecuteJumpSequence()
	{
	}

	private void StartSingleJump(int jumpIndex)
	{
	}

	private void PlayLandEffect(int jumpIndex, Vector3 targetPos)
	{
	}

	private void OnJumpMoveComplete(int jumpIndex)
	{
	}

	private void OnJumpSequenceComplete()
	{
	}

	private EntityBase SelectJumpTarget()
	{
		return null;
	}

	private void DealAoeDamage(Vector3 center, int jumpIndex)
	{
	}

	private long GetAoeDamage(int jumpIndex)
	{
		return 0L;
	}

	private void ClearEnemyBulletsInRange(Vector3 center, float radius)
	{
	}

	private void OnPetBulletHitEnemy(EntityBase target, HitStruct hs, HittedData data)
	{
	}

	private void OnHeroTakeDamageForEnergy(EntityBase attacker, long damage, HitStruct hs)
	{
	}

	private void OnHeroAttackSpeedChanged(int heroAttackSpeedValue)
	{
	}

	private void ApplyHeroAttackSpeedToPet()
	{
	}

	private void RevertPetAttackSpeed()
	{
	}
}
