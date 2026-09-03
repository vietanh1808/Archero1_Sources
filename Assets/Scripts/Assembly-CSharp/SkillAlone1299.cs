using UnityEngine;

public class SkillAlone1299 : SkillAloneBase
{
	private long clockindex;

	private int[] bulletids;

	private float hitratio;

	private float dropRadius;

	private float bulletRadius;

	private int minNum;

	private int maxNum;

	private ActionBasic action;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitShield(GameObject go, BulletBase b)
	{
	}
}
