using System.Collections.Generic;

public class SkillAlone1713 : SkillAloneBase
{
	private int CONFIG_BULLET_ID;

	private float CONFIG_RATE;

	private int CONFIG_FLY_SWORD_ID;

	private float CONFIG_FLY_SWORD_HIT_RATIO;

	private float CONFIG_SPEAR_TIME;

	private List<SkillAlone1713GoodCtrl> m_listSpears;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void CacheSpears()
	{
	}

	private void OnSpearDeInit(SkillAlone1713GoodCtrl ctrl)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
