using System.Collections.Generic;

public class SkillAlone1332 : SkillAloneBase
{
	private float deltaElementHit;

	private float maxElementHit;

	private float explosionRadius;

	private float attackPercent;

	private int buffId;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onElementHit(EntityBase hitTarget, HitStruct hitStruct, HittedData hittedData)
	{
	}

	protected void OnReachMaxElementHit(EntityBase hitTarget)
	{
	}

	protected List<EntityBase> GetEnemyList(EntityBase hitTarget, float explosionRadius)
	{
		return null;
	}

	private void syncExplodeEffect(EntityBase hitTarget)
	{
	}
}
