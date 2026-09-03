using System;
using UnityEngine;

public class SkillAlone2135GoodCtrl : MonoBehaviour
{
	[SerializeField]
	private LineRenderer _chain;

	[SerializeField]
	private Transform _hook;

	private float _time;

	private Vector3 _dir;

	private float _speed;

	private EntityBase _target;

	private Vector3 _endPos;

	private Action _callback;

	public void Init(Vector3 endPos, EntityBase target, Action callback)
	{
	}

	public void DeInit()
	{
	}

	private void OnUpdate(float delta)
	{
	}
}
