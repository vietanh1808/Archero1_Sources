using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1674 : SkillAloneBase
{
	private float m_fMeleeRate;

	private float m_fFarRate;

	private float m_fHitRatio;

	private int m_nDebuffId;

	protected float m_fRadius;

	private List<int> m_listMeleBullets;

	private List<int> m_listFarBullets;

	protected List<int> triggerEnemy;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected void CreateBombSkill(BulletBase bullet, EntityBase target, int attack, float radius)
	{
	}

	protected virtual void CreateBomb(BulletBase bullet, Vector3 targetPos, int attack, float radius)
	{
	}

	protected virtual int GetBulletAttack(BulletTransmit bulletTransmit)
	{
		return 0;
	}

	protected virtual void OnCreateBomb(BulletBase bullet, Vector3 targetPos)
	{
	}
}
