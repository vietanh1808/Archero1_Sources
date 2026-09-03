using UnityEngine;

public class SkillAlone1568 : SkillAloneAxeBase
{
	protected const int BULLET_ID = 5325;

	private const int FORWARD_COUNT = 1;

	private int FORSIDE_COUNT;

	private const int AXE_COUNT = 3;

	private const int DELTA_COUNT = 2;

	private const int MAX_AXE_COUNT = 4;

	private float callRate;

	protected override void OnInstallCallback()
	{
	}

	protected override void OnUninstallCallback()
	{
	}

	private void OnAttack()
	{
	}

	private void createSideBullet(Vector3 bulletPos, Vector3 startDir, int sign = 1)
	{
	}

	private int getBonusAxeCount()
	{
		return 0;
	}
}
