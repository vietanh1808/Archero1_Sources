using UnityEngine;

public class SkillAloneTigerBase : SkillAloneBase
{
	protected float bulletAtkPercent;

	protected const int BULLET_ID = 1520;

	protected int minHP;

	protected int maxHP;

	protected void CreateTigerBullets(Vector3 targetPos, bool isPvp)
	{
	}

	protected bool IsTigerBullet(HitStruct @struct)
	{
		return false;
	}

	protected bool IsMainWeaponBullet(HitStruct @struct)
	{
		return false;
	}
}
