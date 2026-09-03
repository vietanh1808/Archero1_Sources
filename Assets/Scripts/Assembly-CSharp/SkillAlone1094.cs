using System.Collections.Generic;

public class SkillAlone1094 : SkillAloneBase_EffectSkill
{
	private struct EntityStruct
	{
		public EntityBase entity;

		public int index;

		public EntityStruct(EntityBase entity, int index)
		{
			this.entity = null;
			this.index = 0;
		}
	}

	private const string String_AttackMin = "AttackMin%";

	private const string String_AttackMax = "AttackMax%";

	private const string String_NumMin = "NumMin";

	private const string String_NumMax = "NumMax";

	private const string String_RateMin = "RateMin";

	private const string String_RateMax = "RateMax";

	private const string String_RateReduce = "RateReduce";

	private int AttackMin;

	private int AttackMax;

	private int NumMin;

	private int NumMax;

	private int RateMin;

	private int RateMax;

	private int RateReduce;

	private ActionBasic action;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void Excute(string str)
	{
	}

	protected override void OnTrigger(EntityBase entity)
	{
	}

	private void CallThunder(int i, List<EntityStruct> targets)
	{
	}
}
