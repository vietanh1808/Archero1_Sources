using UnityEngine;

public class SkillAlone1678 : SkillAloneBase
{
	private float CONFIG_MIN_DISTANCE;

	private float CONFIG_HP_PERCENT;

	private float CONFIG_RATE;

	private float CONFIG_HIT_RATIO;

	private float m_fTotalDistance;

	private int m_nFlag;

	private Vector3? m_lastPos;

	private bool m_bTriggerFlag;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void OnAttack()
	{
	}

	private void CreateContinueBullet(int bulletId, float rotate, long count)
	{
	}

	private void CreateBullets_Side(int bulletId, long count)
	{
	}

	private void OnMove(bool move)
	{
	}
}
