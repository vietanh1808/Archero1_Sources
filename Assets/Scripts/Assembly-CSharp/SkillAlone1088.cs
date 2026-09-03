using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1088 : SkillAloneBase_EffectSkill
{
	protected const string String_CallID = "CallID";

	protected const string String_Time = "Time";

	protected const string String_Weight = "Weight";

	protected const string String_Num = "Num";

	protected const string String_AttackFromParentHpPercent = "AttackFromParentHp%";

	protected int partid;

	protected float time;

	protected int weight;

	protected int num;

	protected float attackFromHp;

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

	private void CallPart(EntityBase entity, Vector2Int randomPos)
	{
	}

	protected override void OnTrigger(EntityBase entity)
	{
	}

	private void CallPartWrapper(List<Vector2Int> list)
	{
	}
}
