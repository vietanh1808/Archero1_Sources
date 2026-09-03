using System;
using System.Collections.Generic;

public class SkillAlone1402 : SkillAloneAttackCountBase
{
	[Serializable]
	private class SyncSkill1402BuffTargetsVO : CustomJsonActionVO
	{
		public List<int> TargetGuids;
	}

	private float radius;

	private int minMonsterCount;

	private int maxMonsterCount;

	private int buffId;

	private const string SyncSkill1402_BuffTargets = "SyncSkill1402_BuffTargets";

	protected override void ParseArgs()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnMaxAttackCount()
	{
	}

	private void ApplyBuffs(List<EntityBase> targets)
	{
	}

	private void SyncBuffTargets(List<int> targetGuids)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
