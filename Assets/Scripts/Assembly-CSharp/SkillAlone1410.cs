public class SkillAlone1410 : SkillAloneBase
{
	private float callRate;

	private int callId;

	private float aliveTime;

	private float inheritAttackSpeedPercent;

	private float inheritAttackValuePercent;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onEntityDead(EntityBase target, EntityBase source, HitStruct hs)
	{
	}

	private bool isGhost(int id)
	{
		return false;
	}
}
