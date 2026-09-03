using DG.Tweening;
using UnityEngine;

public class SkillAlone2244 : SkillAlonePetBase
{
	private float getMaxHPShieldPercent;

	private float getShieldMaxPercent;

	private float shieldLastTime;

	private float getMaxHPShieldPercentPerLevel;

	private float getShieldMaxPercentPerLevel;

	public const int SkillEffectID = 2244;

	private GameObject shield;

	private Tween delayCall;

	private float RealGetMaxHpShieldPercent => 0f;

	private float RealGetShieldMaxPercent => 0f;

	protected bool HavePhoenixShield => false;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnPetAppear(BattlePetVO battlePetData)
	{
	}

	protected virtual void OnPetDisAppear(BattlePetVO battlePetData)
	{
	}

	protected virtual void OnPetStartDisappear(LocalSave.PetOne petOne)
	{
	}

	protected virtual void SkillStart()
	{
	}

	protected virtual void SkillEnd()
	{
	}

	protected virtual void SkillClear(bool doDisappear = true)
	{
	}

	protected virtual void LoadShield()
	{
	}

	private void RecycleShield(bool doDisappear = true)
	{
	}

	protected virtual void OnPhoenixShieldAppear()
	{
	}

	protected virtual void OnPhoenixShieldDisAppear()
	{
	}
}
