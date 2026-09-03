using System;
using DG.Tweening;
using UnityEngine;

public class SkillCreateBase : MonoBehaviour
{
	protected EntityBase m_Entity;

	protected Action<SkillCreateBase> mCallback;

	protected float time;

	private Sequence seq;

	private void Awake()
	{
	}

	protected virtual void OnAwake()
	{
	}

	public void Init(EntityBase entity, string[] args)
	{
	}

	protected virtual void OnInit(string[] args)
	{
	}

	public void SetTimeCallback(Action<SkillCreateBase> callback)
	{
	}

	public void Deinit()
	{
	}

	protected virtual void OnDeinit()
	{
	}
}
