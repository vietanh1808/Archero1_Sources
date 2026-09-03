using UnityEngine;

public class SkillAlone1719 : SkillAloneBase
{
	private float hitRate;

	private float hpDropRate;

	private float bossRate;

	private float monekyHairInterval;

	private int maxMonkeyHairCount;

	private int defaultMonkeyHairCount;

	private int curMaxMonkeyHairCount;

	private float curTimeInterval;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void parseArgs0(string[] strs)
	{
	}

	private void initCurMaxMonkeyHairCount()
	{
	}

	private void onCreatePlayer()
	{
	}

	private void onLevelUp(int obj)
	{
	}

	private void updateCurMaxMonkeyHairCount(int count)
	{
	}

	public int GetHeroMonkeyHairCount()
	{
		return 0;
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void onAbsorbHpFood(FoodBase foodBase)
	{
	}

	private void onChangeHP(long curHp, long maxHp, float curHpPercent, long deltaHp)
	{
	}

	private void onKillAction(EntityBase enemy, Vector3 vector, HitStruct hs)
	{
	}

	private void onKillMonster(EntityBase attackTarget)
	{
	}

	private void tryGetMonekyHair(float rate)
	{
	}

	private void increaseCurMonekyHairCount()
	{
	}

	protected virtual void InitCurMonkeyHair()
	{
	}

	protected virtual void AddCallback()
	{
	}

	protected virtual void RemoveCallback()
	{
	}

	private void onSyncMonkeyHairCount(CustomJsonDataCommand cmd)
	{
	}

	protected override void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}
}
