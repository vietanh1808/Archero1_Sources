using System;
using UnityEngine;

public class SkillAlone1726 : SkillAloneBase
{
	private Func<Vector3, Quaternion, BulletBase> CreateHitGroundBullet;

	private Func<Vector3, Quaternion, BulletBase> CreateStretchBullet;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnBeforeRunWuKongHitGroundAI()
	{
	}

	private void OnAfterRunWuKongHitGroundAI()
	{
	}

	private void OnBeforeRunWuKongStretchAI()
	{
	}

	private void OnAfterRunWuKongStretchAI()
	{
	}

	private BulletBase OnCreateWuKongStretchBullet(Vector3 bulletPos, Quaternion rotation)
	{
		return null;
	}

	private BulletBase OnCreateWuKongHitGroundBullet(Vector3 bulletPos, Quaternion rotation)
	{
		return null;
	}
}
