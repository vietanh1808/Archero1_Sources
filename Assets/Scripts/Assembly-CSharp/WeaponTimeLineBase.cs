using System;
using TableTool;
using UnityEngine;

public class WeaponTimeLineBase
{
	public Action OnAttackStartStartAction;

	public Action OnAttackStartEndAction;

	public Action OnAttackEndStartAction;

	public Action OnAttackEndEndAction;

	public Action OnAttackInterruptAction;

	protected ActionBasic action;

	protected int ParabolaSize;

	protected int weapenID;

	protected int bulletID;

	protected EntityTimeLineBase owner;

	protected string prevAttackPrev;

	protected string prevAttackEnd;

	public Weapon_weapon weapondata { get; private set; }

	public GameObject weaponobj { get; protected set; }

	public WeaponTimeLineBase(EntityTimeLineBase pW)
	{
	}

	public virtual void Init(int pWeapenId)
	{
	}

	private void InitAnimations()
	{
	}

	public virtual void UnInstall()
	{
	}

	public virtual void Dispose()
	{
	}

	public static Transform GetWeaponNode(BodyMask body, int weaponnode)
	{
		return null;
	}

	protected virtual void OnAttack(params object[] args)
	{
	}

	public virtual void Attack(params object[] args)
	{
	}

	private void CreateBullets()
	{
	}

	protected Transform CreateBullet(Vector3 offsetpos, float rota)
	{
		return null;
	}

	protected Transform CreateBulletByObject(BulletTimeLineBase b, Vector3 offsetpos, float rota)
	{
		return null;
	}

	public void OnAttackStart_StartCallback()
	{
	}

	public void OnAttackStart_EndCallback()
	{
	}

	public void OnAttackEnd_StartCallback()
	{
	}

	public void OnAttackEnd_EndCallback()
	{
	}
}
