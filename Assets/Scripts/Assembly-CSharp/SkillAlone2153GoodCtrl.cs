using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2153GoodCtrl : MonoBehaviour
{
	[SerializeField]
	private GameObject _ball;

	[SerializeField]
	private GameObject _bomb;

	private const float _flyTime = 1f;

	private const float _flyHeight = 5f;

	private float _horizontalSpeed;

	private float _verticalSpeed;

	private Vector3 _dir;

	private EntityBase _entity;

	private BulletBase _parentBullet;

	private Vector3 _endPos;

	private float _radius;

	private float _time;

	private Action<BulletBase, List<EntityBase>, SkillAlone2153GoodCtrl> _callback;

	public void Init(EntityBase entity, BulletBase parentBullet, float distance, float radius, float angle, Action<BulletBase, List<EntityBase>, SkillAlone2153GoodCtrl> callback)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	public void DeInit()
	{
	}
}
