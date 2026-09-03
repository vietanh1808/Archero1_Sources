using System.Collections.Generic;

public class SkillAlone1108 : SkillAloneBase
{
	private new const string Tag = "SkillAlone1108";

	private float attackAddPercent;

	private float attackPercentLimit;

	private long currentAttackPercent;

	private long currentBodyHitPercent;

	private Dictionary<EntityBase, float> mAddList;

	protected override void OnInstall()
	{
	}

	private void onMonsterDead(EntityBase entity)
	{
	}

	private void addAttack2Entity(EntityBase entity)
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void debug(string value, params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}
}
