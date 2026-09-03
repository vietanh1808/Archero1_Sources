using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1574 : SkillAloneBase
{
	protected int[] m_aryBuffs;

	protected float m_fInterval;

	protected float m_fBuffRadius;

	protected float m_fAngle;

	protected float m_fRate;

	protected int m_nMax;

	protected int m_nEffectId;

	protected float m_fTime;

	protected int m_nRadius;

	private List<SkillAlone1574GoodCtrl> m_listStaffs;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void EffectCache()
	{
	}

	private void OnGoToNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	private void OnAttack()
	{
	}

	protected (Vector2Int?, float) GetStaffPos()
	{
		return default;
	}

	protected virtual void CreateStaff()
	{
	}

	protected void DoCreateStaff(ShariCursedStaff vo)
	{
	}

	private void EffectEnd(SkillAlone1574GoodCtrl ctrl)
	{
	}
}
