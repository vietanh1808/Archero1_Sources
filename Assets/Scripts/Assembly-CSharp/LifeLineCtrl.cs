using System;
using UnityEngine;

public class LifeLineCtrl : MonoBehaviour
{
	private GameObject mStartObj;

	private GameObject mEndObj;

	private LineRenderer line;

	private const float textureLengthScale = 3f;

	private const float textureScrollSpeed = 8f;

	private EntityBase m_Entity;

	private EntityBase entity;

	public Action mCacheEvent;

	private bool bStart;

	private void Awake()
	{
	}

	public void UpdateEntity(EntityBase m_Entity, EntityBase entity)
	{
	}

	private void Update()
	{
	}

	public void Cache()
	{
	}
}
