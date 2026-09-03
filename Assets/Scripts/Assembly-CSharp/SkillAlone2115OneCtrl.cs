using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2115OneCtrl : MonoBehaviour
{
	private EntityBase m_Entity;

	private float CONFIG_HIT_INTERVAL;

	private Action<EntityBase> m_callback;

	private Dictionary<EntityBase, float> m_dicLastHitTimes;

	public void Init(EntityBase entity, float fHitInterval, Action<EntityBase> callback)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void DeInit()
	{
	}
}
