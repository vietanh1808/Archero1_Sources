using System;
using UnityEngine;

public class CommonHitCtrl : PauseObject
{
	public class HitType
	{
		public static int None;

		public static int Capybara;

		public static int NewPlay125WeaponSkin;
	}

	public int hitType;

	public Action<Collider> onTriggerEnterCallback;

	public Action<Collider> onTriggerStayCallback;

	public Action<Collider> onTriggerExitCallback;

	protected EntityBase m_Entity;

	public bool IsDead;

	public string Tag => null;

	public virtual void Init(EntityBase entity)
	{
	}

	public virtual void DeInit()
	{
	}

	protected virtual void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	public void DestroySelf()
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

	protected EntityBase GetTarget(Collider other)
	{
		return null;
	}
}
