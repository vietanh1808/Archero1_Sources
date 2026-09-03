using UnityEngine;

public class SkillAlone2012 : SkillAlone2011
{
	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void onKillAction(EntityBase enemy, Vector3 vector, HitStruct hs)
	{
	}

	private void OnMonsterDead(EntityBase enemy, HitStruct hs)
	{
	}

	private void createDropHPWrapper(EntityBase enemy, HitStruct hs)
	{
	}

	public override float GetDeltaMeteorAtkPercent(float curHPPercent)
	{
		return 0f;
	}
}
