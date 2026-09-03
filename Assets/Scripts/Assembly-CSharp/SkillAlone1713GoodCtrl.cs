using System;
using Dxx.Util;
using UnityEngine;

public class SkillAlone1713GoodCtrl : MonoBehaviour
{
	private int CONFIG_FLY_SWORD_ID;

	private float CONFIG_FLY_SWORD_HIT_RATIO;

	private float CONFIG_SPEAR_TIME;

	[SerializeField]
	private CapsuleCollider m_Collider;

	[SerializeField]
	private Transform m_Model;

	private SequencePool m_SeqPool;

	private const float height = 20f;

	private EntityBase m_Entity;

	private Action<SkillAlone1713GoodCtrl> m_onDeInitAction;

	public void Init(EntityBase entity, EntityBase target, Action<SkillAlone1713GoodCtrl> deinitAction, params float[] args)
	{
	}

	public void DeInit()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void CreateFlySword(Vector3 startpos, float angle)
	{
	}
}
