using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1574GoodCtrl : MonoBehaviour
{
	[SerializeField]
	private CapsuleCollider m_collider;

	private EntityBase m_Entity;

	private int[] m_aryBuffs;

	private float m_fRotation;

	private float m_fAngle;

	private float m_fInterval;

	private Dictionary<EntityBase, float> m_dicTimes;

	private Coroutine m_coroutine;

	public void Init(EntityBase entity, float radius, float rotation, float angle, int[] buffs, float time, float interval, Action<SkillAlone1574GoodCtrl> end)
	{
	}

	public void DeInit()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void TrySendBuff(Collider other)
	{
	}
}
