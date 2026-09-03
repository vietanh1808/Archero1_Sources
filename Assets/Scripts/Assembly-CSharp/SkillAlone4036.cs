using UnityEngine;

public class SkillAlone4036 : SkillAloneBase_Net
{
	private GameObject obj;

	private float m_fRate;

	private float m_fDuration;

	private float m_fInterval;

	private int m_nBulletId;

	private float m_fRotateSpeed;

	private float m_fHpRatio;

	private float m_fRadius;

	private int m_nFxId;

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

	private void CreateReoundBullet(CustomJsonDataCommand cmd)
	{
	}

	private void CreateReoundBullet(SocketShieldReboundBulletVO vo)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void CreateShield(CustomJsonDataCommand cmd)
	{
	}

	private void CreateShield(EntityBase entity, SocketAddShieldVO vo)
	{
	}

	private GameObject GetShieldEffect(int ID)
	{
		return null;
	}

	private void RemoveRotateShield()
	{
	}

	private void OnRecvCustomJsonDataCommand(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
