using System;
using UnityEngine;

public class SkillAlone2111Ctrl : MonoBehaviour
{
	[SerializeField]
	private GameObject[] m_aryShowEffects;

	[SerializeField]
	private GameObject[] m_aryDisappearEffects;

	[SerializeField]
	private GameObject[] m_aryBalls;

	[SerializeField]
	private GameObject m_godEffect;

	private EntityBase m_Entity;

	private int m_nShowCnt;

	private Action m_callback;

	public void Init(EntityBase entity, Action callback)
	{
	}

	public bool Add()
	{
		return false;
	}

	public void DeInit()
	{
	}

	public void End()
	{
	}
}
