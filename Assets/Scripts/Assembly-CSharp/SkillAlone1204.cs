using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SkillAlone1204 : SkillAloneBase
{
	private const string String_CallID = "CallID";

	private const string String_Time = "Time";

	private const string String_Weight = "Weight";

	private const string String_HpTrans = "HpTrans";

	private const string String_CharId = "CharId";

	protected int partid;

	private float time;

	private int weight;

	private int hp_trans;

	private List<Goods_goods.GoodData> mAttrs;

	private int m_nCharId;

	protected override void OnInstall()
	{
	}

	protected virtual void InitSlotinSkills(EntityHero hero)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void Excute(string str)
	{
	}

	private void OnKillEnemy(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}

	private EntityBase CallOne(EntityBase entity, bool CallPlusOne = false)
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
