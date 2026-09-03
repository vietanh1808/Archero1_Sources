using System.Collections.Generic;

public class SkillAlone2155 : SkillAloneBase
{
	private float CONFIG_HP_PERCENT;

	private float CONFIG_RATE;

	private float CONFIG_ADD_BLACK_ENERGY;

	private float CONFIG_ADD_SHIELD_VALUE;

	private float CONFIG_DISTANCE;

	private List<EntityBase> _listEntities;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private HitType OnChangeHitType(EntityBase entity, HitStruct hs)
	{
		return HitType.Normal;
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
