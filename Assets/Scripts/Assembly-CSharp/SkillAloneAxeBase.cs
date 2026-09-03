using UnityEngine;

public class SkillAloneAxeBase : SkillAloneBase
{
	private float particalScale;

	protected float atkRatio;

	protected float scaleFactor1;

	protected float scaleFactor2;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void OnInstallCallback()
	{
	}

	protected virtual void OnUninstallCallback()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	protected virtual BulletBase CreateBullet(EntityBase entity, int bulletId, Vector3 bulletPos, Vector3 bulletDir, float startRadius = 0f)
	{
		return null;
	}

	protected void SyncBullet(EntityBase entity, int bulletId, Vector3 bulletPos, Vector3 bulletDir, float startRadius = 0f)
	{
	}

	protected void SetBulletAttributes(BulletBase bulletBase)
	{
	}

	private float GetDeltaModelScale(float bodyScale)
	{
		return 0f;
	}

	protected void parseArgs(string args, ref float arg1, ref float arg2)
	{
	}

	protected void parseArgs(string args, ref int arg1, ref int arg2)
	{
	}
}
