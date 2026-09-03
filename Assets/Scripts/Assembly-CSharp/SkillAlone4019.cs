using UnityEngine;

public class SkillAlone4019 : SkillAlone1170
{
	private bool m_bIsUsedAFuReviveSkill;

	private int m_nPercent;

	protected override void OnInstall()
	{
	}

	protected override bool CanReborn()
	{
		return false;
	}

	protected override void SetFlag()
	{
	}

	protected override void Reborn(long hp, Vector3 pos)
	{
	}
}
