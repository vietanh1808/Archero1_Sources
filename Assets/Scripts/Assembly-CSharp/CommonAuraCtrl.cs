using System;
using UnityEngine;

public class CommonAuraCtrl : PauseObject
{
	public bool TriggerSelf;

	public SphereCollider collider;

	private float radius;

	public Transform colliderChild;

	public Action<EntityBase> OnTriggerEnterCallback;

	public Action<EntityBase> OnTriggerStayCallback;

	public Action<EntityBase> OnTriggerExitCallback;

	protected EntityBase m_Entity;

	public Action OnDestroyAction;

	public string Tag => null;

	public virtual void Init(EntityBase entity, float radius, bool isFollow = true)
	{
	}

	public virtual void DeInit()
	{
	}

	public void DestroySelf()
	{
	}

	protected void OnTriggerEnter(Collider other)
	{
	}

	protected void OnTriggerStay(Collider other)
	{
	}

	protected void OnTriggerExit(Collider other)
	{
	}

	protected EntityBase GetTarget(Collider other)
	{
		return null;
	}

	public void Scale(float radius)
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void OnDestroySelf()
	{
	}

	protected virtual void OnEnterAuraCollider(EntityBase e)
	{
	}

	protected virtual void OnStayAuraCollider(EntityBase e)
	{
	}

	protected virtual void OnExitAuraCollider(EntityBase e)
	{
	}
}
