using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1170 : SkillAloneBase
{
	private float m_fRate;

	private int m_nBuffId;

	private float m_fRebornTime;

	private Dictionary<BulletBase, long> m_dicCatBullets;

	private float mRebornStartTime;

	private AnimationCurve mRebornCurve;

	private const float mRebornAllTime = 1.5f;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	protected virtual bool CanReborn()
	{
		return false;
	}

	protected virtual void Reborn(long hp, Vector3 pos)
	{
	}

	protected virtual void SetFlag()
	{
	}

	protected bool IsHaveCatBullet()
	{
		return false;
	}

	private void RebornUpdate()
	{
	}

	private void OnRebornUpdate(float delta)
	{
	}

	private void OnCreateCatBullet(BulletBase bullet)
	{
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}
}
