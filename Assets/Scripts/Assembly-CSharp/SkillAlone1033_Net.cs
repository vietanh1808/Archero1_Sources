using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SkillAlone1033_Net : SkillAloneBase_Net
{
	private const string String_CallID = "CallID";

	private const string String_Time = "Time";

	private const string String_Weight = "Weight";

	private const string String_PartLimit = "PartLimit";

	private const string String_TotalPartLimit = "TotalPartLimit";

	private const string String_PartBossLimit = "PartBossLimit";

	private const string String_HpTrans = "HpTrans";

	protected int partid;

	private float time;

	private int weight;

	private int part_limit;

	private int part_boss_limit;

	private int total_part_limit;

	private int hp_trans;

	private List<Goods_goods.GoodData> mAttrs;

	protected Dictionary<EntityBase, int> m_dicCallPartNums;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected virtual void Excute(string str, bool bExcute = false)
	{
	}

	protected virtual bool CanCallOne(EntityBase entity)
	{
		return false;
	}

	protected void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected virtual void CallOne(EntityBase entity)
	{
	}

	private void callOneInternal(EntityBase entity)
	{
	}

	protected void CallOneInternal(EntityBase entity, Vector3 newPos)
	{
	}

	protected virtual CreatePartBodyCommand CreatePartBodyCommand(in Vector3 pos)
	{
		return null;
	}

	private int GetRange()
	{
		return 0;
	}

	protected virtual void OnGetRange(ref int range)
	{
	}
}
