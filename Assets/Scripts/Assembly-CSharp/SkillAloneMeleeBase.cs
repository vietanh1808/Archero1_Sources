using System.Collections.Generic;

public class SkillAloneMeleeBase : SkillAloneBase
{
	private int m_nMeleeWeaponId;

	protected int m_nOldWeaponId;

	private float m_fDistance;

	private float m_fTime;

	protected EntityBase m_nearestEnermy;

	protected EntityHero m_self;

	protected virtual int WeaponId => 0;

	protected virtual bool CurWeaponIsMeleeWeapon => false;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void OnUpdate(float delta)
	{
	}

	protected virtual void CheckWeapon()
	{
	}

	protected virtual void ChangeMeleeWeapon()
	{
	}

	protected virtual void ChangeToOldWeapon()
	{
	}

	protected void ResetOldWeapon()
	{
	}

	protected EntityBase CheckNearestEnemy()
	{
		return null;
	}

	protected virtual List<EntityBase> GetEnemies(float distance)
	{
		return null;
	}

	protected virtual void OnAttackPrePre()
	{
	}

	protected virtual void OnAttackStart()
	{
	}

	protected virtual void OnAttackEndEndEvent()
	{
	}

	protected virtual void OnMove(bool value)
	{
	}

	protected new void Log(string msg)
	{
	}
}
