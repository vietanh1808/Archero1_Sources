using System.Collections.Generic;

public class SkillAlone2153 : SkillAloneBase
{
	private float[] CONFIG_BULLET_ANGLES;

	private float CONFIG_DISTANCE;

	private float CONFIG_RADIUS;

	private float CONFIG_HIT_RATIO;

	private float CONFIG_HIT_RATIO_2;

	private Dictionary<int, List<EntityBase>> _hittedDic;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected virtual void CreateDivideBullets(EntityBase entity, BulletBase bullet)
	{
	}

	private void OnDivideBulletHit(BulletBase bullet, List<EntityBase> entities, SkillAlone2153GoodCtrl ctrl)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
