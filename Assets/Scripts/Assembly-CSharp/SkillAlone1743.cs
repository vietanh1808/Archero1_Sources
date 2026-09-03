using UnityEngine;

public class SkillAlone1743 : SkillAloneBase
{
	private float CONFIG_RATE;

	private float CONFIG_CD;

	private float CONFIG_BACKRATIO_MIN;

	private float CONFIG_BACKRATIO_MAX;

	private float CONFIG_HIT_RATIO;

	private Coroutine m_coroutine;

	private float m_fLastBodyHittedTime;

	private bool m_bMoveFlag;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnMove(bool flag)
	{
	}

	private void OnBodyHit(EntityBase entity)
	{
	}
}
