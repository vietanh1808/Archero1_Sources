using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2149 : SkillAloneBase
{
	private float duration;

	private float atkRate;

	private int buffId;

	private const string LaserRun = "LaserRun";

	private const int shieldBulletId = 9056;

	private Dictionary<int, int> GetLaserWeaponDict;

	private int originalWeaponId;

	private EntityHero m_hero;

	private bool isCannon;

	private float preChangeWeaponTime;

	private float preAttackTime;

	private GameObject LaserFx;

	private SkillAlone2149EffectCtrl laserFxCtrl;

	private Transform laserSpawn;

	private AnimationCtrlBase.AniClass preAnimClass;

	protected override void OnInstall()
	{
	}

	protected virtual void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected void OnUpdate(float delta)
	{
	}

	private void OnSuperSkill(bool flag)
	{
	}

	private bool OnCheckSuperSkill()
	{
		return false;
	}

	private bool CanSuperSkill()
	{
		return false;
	}

	private void OnLanceChangeState(bool isInCannon)
	{
	}

	private void OnAttack()
	{
	}

	private void OnDisableMoveWithAttack(bool flag)
	{
	}

	private void RunningLaserAttack()
	{
	}

	private float GetAttackInterval()
	{
		return 0f;
	}

	private void ShowLaserFx(bool isShow)
	{
	}

	private void OnCanMoveWithAttackAndRotateToTarget(bool flag)
	{
	}
}
