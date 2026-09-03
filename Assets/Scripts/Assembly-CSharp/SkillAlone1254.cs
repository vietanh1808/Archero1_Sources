using UnityEngine;

public class SkillAlone1254 : SkillAloneBase
{
	private GameObject obj;

	private float m_fRate;

	private float m_fDuration;

	private float m_fInterval;

	private int m_nBulletId;

	private float m_fRotateSpeed;

	private float m_fHpRatio;

	private float m_fRadius;

	private float m_fTime;

	private float m_fCreateShieldTime;

	private bool m_bAddShield;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void OnHitShield(GameObject shield, BulletBase bullet)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void CreateShied()
	{
	}

	private GameObject GetShieldEffect()
	{
		return null;
	}

	private void RemoveRotateShield()
	{
	}
}
