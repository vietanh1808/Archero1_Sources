using UnityEngine;

public class SkillAlone1617 : SkillAloneBase
{
	public class SkillEffect1617IgniteVO_SyncCure : CustomJsonActionVO
	{
		public int guid;

		public long cureValue;
	}

	private float addBuffRate;

	private int buffId;

	private float recoverRate;

	private const string Skill1Effect1617_SycCure = "Skill1Effect1617_SycCure";

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnKill(EntityBase enemy, Vector3 vector, HitStruct hs)
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void SyncCure(long cure)
	{
	}

	protected override void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}
}
