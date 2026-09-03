using UnityEngine;

public class SkillAlone1677 : SkillAloneTigerBase
{
	private float hpPercent;

	private int buffId;

	private SkillHitEnemy skill;

	private bool hasTriggered;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onWillDead()
	{
	}

	private void onHitEnemy(EntityBase @base, HitStruct @struct, HittedData data)
	{
	}

	public void SyncTigerBullets(Vector3 targetPos)
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}
}
