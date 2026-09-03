using System;
using Dxx.Util;
using UnityEngine;

public class SkillAlone1774GoodCtrl : MonoBehaviour
{
	[SerializeField]
	private Transform _Circle;

	[SerializeField]
	private SpriteRenderer _spriteRenderer;

	private SequencePool mSeqPool;

	private EntityBase m_Entity;

	public void Init(EntityBase entity, float time, float radius, Action<Vector3> callback)
	{
	}

	public void DeInit()
	{
	}
}
