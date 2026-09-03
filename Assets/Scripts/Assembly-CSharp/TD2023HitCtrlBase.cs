using System;
using UnityEngine;

public class TD2023HitCtrlBase : PauseObject
{
	public Action<Collider> onTriggerEnterCallback;

	public Action<Collider> onTriggerStayCallback;

	public Action<Collider> onTriggerExitCallback;

	protected EntityBase m_Entity;

	public string Tag => null;

	public virtual void Init(EntityBase entity)
	{
	}

	public virtual void DeInit()
	{
	}

	public void Destroy()
	{
	}

	protected override void UpdateProcess()
	{
	}

	protected virtual void OnTriggerEnter(Collider other)
	{
	}

	protected virtual void OnTriggerStay(Collider other)
	{
	}

	protected virtual void OnTriggerExit(Collider other)
	{
	}
}
