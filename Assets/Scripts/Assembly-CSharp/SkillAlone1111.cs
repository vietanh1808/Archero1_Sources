using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SkillAlone1111 : SkillAloneBase
{
	private const string String_CallID = "CallID";

	private const string String_Time = "Time";

	private const string String_CallRate = "CallRate";

	private const string String_MaxNum = "MaxNum";

	private int partid;

	private float time;

	private int callRate;

	private int maxNum;

	private List<Goods_goods.GoodData> mAttrs;

	private int currentNum;

	protected virtual int size => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void Excute(string str)
	{
	}

	private void onHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private Vector2Int getCreatePos(EntityBase entity)
	{
		return default;
	}

	private bool tryGetRound8(EntityBase entity, out Vector2Int v)
	{
		v = default;
		return false;
	}

	private bool can_call()
	{
		return false;
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnRemoveEvent(EntityPartBodyBase entity, int id)
	{
	}
}
