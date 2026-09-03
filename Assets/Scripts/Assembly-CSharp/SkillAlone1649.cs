using UnityEngine;

public class SkillAlone1649 : SkillAloneMeteoriteBase
{
	private int m_nBulletid;

	protected float m_fRate;

	private float m_fDropRadius;

	private float m_fOutRadius;

	private float m_fInnerRadius;

	private float m_fInnerhitratio;

	private float m_fOuthitratio;

	private float m_fHitRatio;

	private float m_fDropHpRate;

	private float m_fHpPercent;

	private float m_fExponnet;

	private float m_fDivisor;

	private float m_fMin;

	private float m_fMax;

	private int certainlyTimes;

	private float HitRatioRise;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void OnAttack()
	{
	}

	private void OnKill(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}

	protected void CreateSlopeBullet()
	{
	}

	protected override bool OnMeteoriteOverDistance(BulletSlopeBase bullet)
	{
		return false;
	}

	private void DropHp(Vector3 pos)
	{
	}

	protected override float CalAttackRatio(EntityBase entity)
	{
		return 0f;
	}

	protected override void OnSendHit(EntityBase entity, BulletBase bullet)
	{
	}

	private void CreateAurora(EntityBase entity, float angle)
	{
	}

	private void TigerMeteoriteHitRise(float rise)
	{
	}

	private void TigerMeteoriteCertainlyTimes(int times)
	{
	}
}
