using UnityEngine;

public class SkillAlone1809 : SkillAloneBase
{
	private const int BULLET_ID = 3036;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hs, HittedData hitted)
	{
	}

	private BulletBase createBullet(float angle, Vector3 bulletPos)
	{
		return null;
	}

	private void syncBullet(float angle, Vector3 bulletPos)
	{
	}
}
