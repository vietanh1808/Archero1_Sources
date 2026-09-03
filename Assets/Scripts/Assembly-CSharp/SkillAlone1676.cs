using System.Collections.Generic;

public class SkillAlone1676 : SkillAloneTigerBase
{
	private float triggerRate;

	private float factor1;

	private float factor2;

	private float factor3;

	private float timeInterval;

	private int buffId;

	protected SkillHitEnemy skill;

	private Dictionary<EntityBase, ConditionTime> enemyCDDict;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	private void onWillDead()
	{
	}

	private void onHitEnemy(EntityBase attackTarget, HitStruct data, HittedData hitteddata)
	{
	}

	private void onEnemyDead(EntityBase entity)
	{
	}
}
