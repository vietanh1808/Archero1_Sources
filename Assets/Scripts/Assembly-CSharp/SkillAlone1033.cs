using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SkillAlone1033 : SkillAloneBase
{
	protected const string String_CallID = "CallID";

	protected const string String_Time = "Time";

	protected const string String_Weight = "Weight";

	protected const string String_PartLimit = "PartLimit";

	protected const string String_TotalPartLimit = "TotalPartLimit";

	private const string String_PartBossLimit = "PartBossLimit";

	protected const string String_HpTrans = "HpTrans";

	protected int partid;

	private float _time;

	protected int weight;

	protected int part_limit;

	protected int part_boss_limit;

	protected int total_part_limit;

	protected int hp_trans;

	private bool m_bUseCallPlusOneAttr;

	protected List<Goods_goods.GoodData> mAttrs;

	protected Dictionary<EntityBase, int> m_dicCallPartNums;

	protected float callInterval;

	protected ConditionTime callConditionTime;

	protected float time
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected virtual int size => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	protected virtual void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected virtual void Excute(string str, bool bExcute = false)
	{
	}

	protected virtual void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected virtual int CallPartCount()
	{
		return 0;
	}

	protected virtual void OnHitActionInternal(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected virtual EntityPartBodyBase CallOne(EntityBase entity, Vector3? newCreatePos, bool CallPlusOne = false)
	{
		return null;
	}

	protected virtual EntityPartBodyBase CallOneWithCheck(EntityBase entity, Vector3? newCreatePos, bool CallPlusOne = false)
	{
		return null;
	}

	protected virtual EntityPartBodyBase CallOne(EntityBase entity, bool CallPlusOne = false)
	{
		return null;
	}

	protected Vector3 GetRandomPos(EntityBase entity)
	{
		return default;
	}

	protected EntityPartBodyBase callOneInternal(EntityBase entity, Vector3? newPos = null)
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

	protected virtual float OnPartTime(float time)
	{
		return 0f;
	}

	protected virtual bool CanCallOne(EntityBase entity)
	{
		return false;
	}

	protected virtual bool CanCallPlusOne()
	{
		return false;
	}
}
