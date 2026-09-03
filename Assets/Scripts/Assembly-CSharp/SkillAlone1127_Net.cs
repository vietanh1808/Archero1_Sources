using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1127_Net : SkillAloneBase_Net
{
	private string m_strMoveSpeedAttr;

	private float m_nDamageExtra;

	private float m_fLvUp;

	private int m_nInterval;

	private float m_fDuration;

	private int m_nEffectId;

	private int m_nDebuffId2;

	private float m_fTotalCharmTime;

	private float m_fTotalPortalTime;

	private int m_nDebuffId;

	private int m_nCallRate;

	private int m_nInnerMinRange;

	private int m_nInnerMaxRange;

	private int m_nOuterRange;

	private float m_fPortalTime;

	private float m_fPortalCreateTime;

	private Dictionary<EntityBase, float> m_dicEnemies;

	private List<SkillAlone1127GoodCtrl> m_listPortals;

	protected override void OnInstall()
	{
	}

	private void Excute(string str)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void CharmEnemy()
	{
	}

	private void OnKillAction(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}

	private void OnAttack()
	{
	}

	private void GetPortalPos(out Vector2Int pos_1, out Vector2Int pos_2)
	{
		pos_1 = default;
		pos_2 = default;
	}

	protected void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void RemovePortals()
	{
	}

	private void OnTriggerPortal(SkillAlone1127GoodCtrl one, SkillAlone1127GoodCtrl two)
	{
	}

	protected override void OnUninstall()
	{
	}
}
