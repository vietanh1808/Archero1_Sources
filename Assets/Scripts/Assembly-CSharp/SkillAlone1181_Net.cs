using UnityEngine;

public class SkillAlone1181_Net : SkillAloneBase_Net
{
	private int m_nBuffId;

	private float m_fSoliderTime;

	private float m_fBossTime;

	private float m_fMaxTime;

	private float m_fStartTime;

	private bool m_bIsUsedAFuReviveSkill;

	private float mRebornStartTime;

	private AnimationCurve mRebornCurve;

	private const float mRebornAllTime = 1.5f;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void OnMonsterDead(EntityBase entity)
	{
	}

	private void RebornUpdate()
	{
	}

	private void OnRebornUpdate(float delta)
	{
	}
}
