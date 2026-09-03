using TableTool;
using UnityEngine;

public class SkillAlone1029 : SkillAloneBase
{
	private Weapon_weapon weapondata;

	private float percent;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnMonsterDead(EntityBase entity)
	{
	}

	private void OnKillAction(EntityBase entity, Vector3 HittedDirection, HitStruct hs)
	{
	}

	private void onKillInternal(EntityBase entity, Vector3 HittedDirection)
	{
	}

	protected virtual int GetBulletCount()
	{
		return 0;
	}
}
