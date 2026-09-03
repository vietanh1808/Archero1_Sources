using System.Collections.Generic;

public class SkillAlone1750 : SkillAlone1310
{
	private const int RECOVER_TIMES = 5;

	private const int HIT_REDUCE_BUFF_ID = 9108;

	private const int CONFIG_ID = 3293;

	private float minRecoverHPPercent;

	private float maxRecoverHPPercent;

	private Dictionary<EntityBase, bool> hittedDict;

	private int hitCountByMeteor;

	private ActionBasic recoverHPAction;

	private float soldierRate;

	private float bossRate;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void initConfig()
	{
	}

	private void onFireworksDragonRelease()
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onHit(EntityBase enemy, HitStruct hs, HittedData hd)
	{
	}

	private void onChangeHP(long currentHP, long maxHP, float percent, long deltaHP)
	{
	}

	private void addAttrs(int count)
	{
	}

	private void recoverHP()
	{
	}

	private void recoverHPInternal(long recoverHP)
	{
	}
}
