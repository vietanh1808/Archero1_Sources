using Dxx.Util;
using UnityEngine;

public class SkillAlone1774 : SkillAloneBase
{
	private int CONFIG_FX_ID;

	private float CONFIG_TIME;

	private float CONFIG_RADIUS;

	private float CONFIG_INTERVAl;

	private int CONFIG_METEOR_ID;

	private float CONFIG_METEOR_INTERVAL;

	private int CONFIG_METEOR_MAX;

	private float CONFIG_METEOR_HIT_RATIO;

	private float m_fLastHittedTime;

	private SequencePool mSeqPool;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	private void OnMiss()
	{
	}

	protected virtual void CreateEffect(Vector3 pos)
	{
	}

	private void CreateRadishMeteors(Vector3 taPrgpostos)
	{
	}

	protected virtual void DoCreateRadishMeteors(Vector3[] poses)
	{
	}
}
