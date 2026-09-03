using System.Collections.Generic;
using TableTool;

public class SkillAlone4013 : SkillAloneBase
{
	private const string String_CallID = "CallID";

	private const string String_Time = "Time";

	private const string String_Weight = "Weight";

	private const string String_TotalPartLimit = "TotalPartLimit";

	private const string String_HpTrans = "HpTrans";

	protected int partid;

	private float time;

	private int weight;

	private int part_limit;

	private int part_boss_limit;

	private int total_part_limit;

	private int hp_trans;

	private List<Goods_goods.GoodData> mAttrs;

	private Dictionary<EntityBase, int> m_dicCallPartNums;

	private float lastCallTime;

	protected float timeInterval;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected virtual void Excute(string str)
	{
	}

	protected void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected virtual float OnPartTime(float time)
	{
		return 0f;
	}

	protected virtual bool CanCallOne(EntityBase entity)
	{
		return false;
	}

	protected virtual void CallOne(EntityBase entity)
	{
	}
}
