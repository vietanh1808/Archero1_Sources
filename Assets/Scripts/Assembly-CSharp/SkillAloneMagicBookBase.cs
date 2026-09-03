using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SkillAloneMagicBookBase : SkillAloneBase
{
	protected const string String_Time = "Time";

	private const string String_SkillNum = "SkillNum";

	public const string String_HpToEnergy = "HpToEnergy";

	protected int m_nEnergy;

	private long m_lLastEnergy;

	protected long m_lInitialEnergy;

	protected List<Goods_goods.GoodData> m_listAttrs;

	protected List<Goods_goods.GoodData> m_listReverseAttrs;

	protected List<Goods_goods.GoodData> globalListAttrs;

	protected List<Goods_goods.GoodData> globalListReverseAttrs;

	protected List<Goods_goods.GoodData> argsListAttrs;

	protected List<Goods_goods.GoodData> argsListReverseAttrs;

	protected int m_nAddMaxPercent;

	protected override void OnInstall()
	{
	}

	protected void populateAttrs()
	{
	}

	private void handleValuesDict(Dictionary<string, object> values)
	{
	}

	protected virtual void ExcuteArgs()
	{
	}

	protected virtual bool OnExcuteOneArg(string str)
	{
		return false;
	}

	protected override void OnUninstall()
	{
	}

	private void OnKillAction(EntityBase entity, Vector3 HittedDirection, HitStruct hs)
	{
	}

	protected virtual void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void OnEnergyChangeAction()
	{
	}

	protected virtual void UpdateEnergyMax()
	{
	}

	protected virtual void OnEnergyChange()
	{
	}

	protected virtual bool OnEnergyFull()
	{
		return false;
	}

	protected virtual void ExcuteAttributes()
	{
	}

	protected virtual void ReverseAttributes()
	{
	}

	protected virtual void AddUniqueTime(ref long time)
	{
	}
}
