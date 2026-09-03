using System;
using Dxx.Util;
using UnityEngine;

public class Boss5083CallCtrl : MonoBehaviour
{
	public enum STATE
	{
		Idle = 0,
		Call = 1,
		Translate = 2
	}

	private EntityBase m_entity;

	private EntityBase m_callEntity;

	private SequencePool mSeqPool;

	private float m_fTime;

	private Action<Boss5083CallCtrl> OnDeInitAction;

	private Action<Boss5083CallCtrl> OnTranslateAction;

	private Func<EntityBase> OnCallAction;

	public STATE State { get; private set; }

	public Boss5083CallCtrl Init(EntityBase entity, int fTime, Func<EntityBase> callAction, Action<Boss5083CallCtrl> onDeInitAction, Action<Boss5083CallCtrl> onTranslateAction)
	{
		return null;
	}

	private void Call(float time = 2f)
	{
	}

	public void DeInit(bool bCallback = true)
	{
	}

	private void DeInitCallEntity()
	{
	}

	private void OnAttackEnd()
	{
	}

	public void OnUpdate(float delta)
	{
	}
}
