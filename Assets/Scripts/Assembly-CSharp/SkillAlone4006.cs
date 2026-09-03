using UnityEngine;

public class SkillAlone4006 : SkillAloneBase
{
	private int m_nBuffId;

	private float m_fIntervalTime;

	private float m_fAddTime;

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

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void RebornUpdate()
	{
	}

	private void OnRebornUpdate(float delta)
	{
	}
}
