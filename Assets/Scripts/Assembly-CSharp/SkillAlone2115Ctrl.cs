using System;
using UnityEngine;

public class SkillAlone2115Ctrl : MonoBehaviour
{
	[SerializeField]
	private SkillAlone2115OneCtrl[] m_skillAlone2115OneCtrls;

	[SerializeField]
	private CapsuleCollider[] m_skillAlone2115ShieldOneCtrls;

	[SerializeField]
	private SpriteRenderer m_srCircleProgress;

	[SerializeField]
	private Transform m_tTriangleParent;

	private EntityHero m_Entity;

	private float CONFIG_ROTATE_SPEED;

	private float CONFIG_CHARGE_MAX;

	private float CONFIG_CHARGE_PER_SECOND;

	private float CONFIG_CHARGE_PER_HP;

	private float CONFIG_SKILL_TIME;

	private float m_fCharge;

	private float m_fSkillTime;

	private bool m_bAddFlag;

	private float m_fRotateSpeed;

	public void Init(EntityHero entity, float fRotateSpeed, float fHitInterval, bool bEnableShield, float fChargeMax, float fChargePerSecond, float fChargePerHp, float fSkillTime, Action<EntityBase> callback)
	{
	}

	private void Update()
	{
	}

	public void AddHpFood()
	{
	}

	public void DeInit()
	{
	}

	public void SetProgress(float progress)
	{
	}

	public void SetAddFlag(bool value)
	{
	}

	public void OnRotateBallSpeedPercentChanged()
	{
	}

	public void OnAttackSpeedUpdated()
	{
	}

	private void updateRotateSpeed()
	{
	}
}
