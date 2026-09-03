using System.Collections.Generic;

public class SkillAlone2193 : SkillAloneBase
{
	private int CONFIG_FLYSWORD_BULLET_CNT;

	private float CONFIG_HIT_RAISE_PERCENT;

	private float CONFIG_HIT_RAISE_MAX;

	private float m_fTime;

	private HashSet<BulletBase> _bullets;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private int OnFlySwordCnt()
	{
		return 0;
	}

	private void OnCreateFlySword(BulletBase bullet, float ratio)
	{
	}

	private void CheckHitRaise(int nLastTotal)
	{
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}
}
