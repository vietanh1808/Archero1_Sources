using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1334 : SkillAloneBase_EffectSkill
{
	private int m_nTempShieldMin;

	private int m_nTempShieldMaX;

	private int m_nTempShieldTime;

	private float m_fShieldAttackPercent;

	private float m_fShieldBuffRatePercent;

	private float m_fTempShieldBuffRatePercent;

	private int m_nTempShieldBuffId;

	private List<string> m_listReverseEffects;

	private Coroutine m_Coroutine;

	private WaitForSeconds m_wait;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnTrigger(EntityBase entity)
	{
	}

	private void OnHitShield(GameObject shield, BulletBase bullet)
	{
	}

	private void Reset()
	{
	}
}
