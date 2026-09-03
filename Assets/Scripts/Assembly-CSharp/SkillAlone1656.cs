using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone1656 : SkillAloneMeleeBase
{
	private enum ShockWaveState
	{
		None = 0,
		Pre = 1,
		Start = 2,
		Moving = 3,
		End = 4
	}

	private Dictionary<int, int> m_dicMappingMeleeBoxing;

	private List<int> m_listLeftHands;

	private const float MinDistance = 2f;

	private float m_fConfigBoxingSuperSkillTime;

	private float m_fBoxingUpdateStep;

	private float m_fDistance;

	private float m_fShockWaveTime;

	private int m_nBuffId;

	private float m_fAttackRatio;

	private float m_fLevelRatio;

	private int EffectId;

	private float CONFIG_BACKRATIO;

	protected bool m_bSuperSkill;

	private float m_fBoxingSuperSkillTime;

	private float m_fTime;

	private EntityHero m_hero;

	private SequencePool mSeqPool;

	private SkillAlone1656GoodCtrl m_superSkillEffect;

	private float m_fPreStartTime;

	private float m_fMoveStartTime;

	private float m_fPreTime;

	private float m_fMoveTime;

	private float m_fEndTime;

	private ShockWaveState m_emShockWaveState;

	private Vector3? m_startPos;

	private Vector3? m_endPos;

	private Coroutine m_minDisCoroutine;

	protected override bool CurWeaponIsMeleeWeapon => false;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnBoxingGloveIdChangeEvent(int id)
	{
	}

	private void PlaySuperSkilEffect(int id)
	{
	}

	protected override void OnAttackEndEndEvent()
	{
	}

	private void OnAttack()
	{
	}

	private void LogSuperSkill(string msg)
	{
	}

	private bool OnCheckSuperSkill()
	{
		return false;
	}

	private void OnSuperSkill(bool flag)
	{
	}

	private bool CanSaveSuperSkillCD()
	{
		return false;
	}

	private bool CanSuperSkillCD()
	{
		return false;
	}

	private bool CanSuperSkill()
	{
		return false;
	}

	protected override void OnUpdate(float delta)
	{
	}

	private void OnMoveEvent(bool move)
	{
	}

	private void Move()
	{
	}

	protected virtual void OnMove(float fMoveTime, Vector3 endPos)
	{
	}

	protected virtual void OnSuperSkillEnd()
	{
	}

	private void MoveEnd()
	{
	}

	private void MoveEndCreateBullet()
	{
	}

	private void CalEndPos(ref Vector3 endPos, Vector3 dir)
	{
	}

	private void CacheEffect()
	{
	}

	private bool OnCanMove()
	{
		return false;
	}

	protected virtual void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void ResetSuperSkillState()
	{
	}

	private void ResetAniState()
	{
	}

	private void OnDead()
	{
	}
}
