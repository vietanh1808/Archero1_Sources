using UnityEngine;

public class SkillAlone1768 : SkillAloneBase
{
	private float CONFIG_KILL_SOLIDER_ATTACK_SPEED_PERCENT;

	private float CONFIG_KILL_BOSS_ATTACK_SPEED_PERCENT;

	private float CONFIG_KILL_ATTACK_SPEED_PERCENT_MAX;

	private float CONFIG_KILL_SOLIDER_MOVE_SPEED_PERCENT;

	private float CONFIG_KILL_BOSS_MOVE_SPEED_PERCENT;

	private float CONFIG_KILL_MOVE_SPEED_PERCENT_MAX;

	private float m_fTotalAddedAttackSpeedPercent;

	private float m_fTotalAddedMoveSpeedPercent;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnKill(EntityBase arg1, Vector3 arg2, HitStruct hs)
	{
	}

	private void CheckMax(ref float value, ref float max)
	{
	}
}
