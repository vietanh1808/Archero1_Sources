using DG.Tweening;
using UnityEngine;

public class SkillAlone2075 : SkillAlonePetBase
{
	private int sendFlySwordCount;

	protected int sendFlySwordBulletID;

	protected float sendFlySwordInterval;

	private float sendExponent;

	private float sendMax;

	private float flySwordRatio;

	private float sendFlySwordLastTime;

	private long? clockindex;

	private Tween delayCall;

	private bool isSkillOver;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void UninstallTimeClock()
	{
	}

	private void OnPetAppear(BattlePetVO battlePetData)
	{
	}

	private void OnPetDisAppear(BattlePetVO battlePetData)
	{
	}

	private void OnPetStartDisappear(LocalSave.PetOne petOne)
	{
	}

	private void SkillEnd()
	{
	}

	private void CheckCastSkill()
	{
	}

	protected virtual BulletBase CreateFlySword(Vector3 startpos, float angle)
	{
		return null;
	}

	private void LoadSkill()
	{
	}

	private void OnAttackSpeedUpdate(int value)
	{
	}

	private bool IsFlySword(int id)
	{
		return false;
	}

	private float CalcCreateInterval(float curInterval)
	{
		return 0f;
	}
}
