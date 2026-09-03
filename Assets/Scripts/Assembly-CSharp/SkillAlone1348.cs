using System.Collections.Generic;

public class SkillAlone1348 : SkillAloneBase
{
	private int consecutiveCount;

	private int debuffId;

	private float timeInterval;

	private float maxTimeInterval;

	private Dictionary<EntityBase, BulletBase.ConsecutiveHitsData> mCommonConsecutiveHitList;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onAction(HitStruct data, EntityBase source)
	{
	}

	public BulletBase.ConsecutiveHitsData GetCommonConsecutiveHitsData(EntityBase source)
	{
		return null;
	}
}
