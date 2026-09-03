using System;

public class SkillAlone1401 : SkillAloneAttackCountBase
{
	[Serializable]
	private class SyncSkill1401ThunderVO : CustomJsonActionVO
	{
		public int TargetGuid;

		public int Count;
	}

	private int minCount;

	private int maxCount;

	private int buffId;

	private float radius;

	private ActionBasic action;

	private const string SyncSkill1401_Thunder = "SyncSkill1401_Thunder";

	protected override void ParseArgs()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnMaxAttackCount()
	{
	}

	private void DoThunder(EntityBase enemy, int attackCount)
	{
	}

	private void sendBuff2Enemy(EntityBase enemy)
	{
	}

	private void SyncThunder(int targetGuid, int count)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
