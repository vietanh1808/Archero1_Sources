using System.Collections.Generic;
using TableTool;

public class SkillAlone1212 : SkillAloneBase
{
	private const string HpCondition = "Hp%";

	private string m_strCondition;

	private long m_lConditionValue;

	private List<Goods_goods.GoodData> m_listEffects;

	private bool m_bTriggerFlag;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ExcuteArgs()
	{
	}

	private void ParseCondition(Goods_goods.GoodData data)
	{
	}

	private float OnCalValue(HitStruct ht, EntityBase entity)
	{
		return 0f;
	}

	private float CalValue()
	{
		return 0f;
	}
}
