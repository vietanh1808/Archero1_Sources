using System.Collections.Generic;
using System.Reflection;
using TableTool;

public class AI3182 : AIBase
{
	private int m_nWeaponId;

	protected List<Skill_slotin_boss> m_SkillList_RoleReversal;

	protected int WeightAll_RoleReversal;

	private MethodInfo _method;

	private MethodInfo method => null;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	public void InitSkillList_RoleReversal()
	{
	}

	public List<int> GetSkill_RoleReversal(int num = 9)
	{
		return null;
	}
}
