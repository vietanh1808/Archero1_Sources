using System;
using System.Collections.Generic;
using UnityEngine;

public class AttackControl
{
	private static Dictionary<KeyCode, MoveControl.EMoveDirection> m_KeyDic;

	private static Dictionary<MoveControl.EMoveDirection, Vector2> m_DirDic;

	protected EntityBase m_EntityHero;

	protected EntityHero m_EntitySelf;

	protected JoyData m_JoyData;

	protected float pAliveTime;

	protected GameObject child;

	[SerializeField]
	protected float RotateAngle;

	protected Vector3 Direction;

	protected float updateangley;

	protected bool bRegister;

	protected AttackCtrl_Bomberman mBomberman;

	private bool bCanRotateP;

	public Func<bool> OnRotateOverEvent;

	protected float AliveTime => 0f;

	public bool CanRotate => false;

	public void SetCanRotate(bool value)
	{
	}

	public void Init(EntityBase entity)
	{
	}

	public void Start()
	{
	}

	protected virtual void OnStart()
	{
	}

	protected virtual void OnDestroys()
	{
	}

	public void DeInit()
	{
	}

	public virtual void Reset()
	{
	}

	public float GetCurrentAngle()
	{
		return 0f;
	}

	public virtual void RegisterJoyEvent()
	{
	}

	public void RemoveJoyEvent()
	{
	}

	public void RemoveAllJoyEvents()
	{
	}

	public virtual void OnMoveStart(JoyData data)
	{
	}

	public void OnMoving(JoyData data)
	{
	}

	public void OnMoveEnd(JoyData data)
	{
	}

	public void OnMoveEnd()
	{
	}

	public bool GetAttacking()
	{
		return false;
	}

	public void RotateUpdate(EntityBase target)
	{
	}

	public void RotateUpdateInMeleeBaby(EntityBase target)
	{
	}

	public virtual void RotateHero(float angle)
	{
	}

	public void SetRotateAngle(float value)
	{
	}

	public void RotateHero(EntityBase entity)
	{
	}

	public bool RotateOver(float offsetAngle = 1f)
	{
		return false;
	}

	public float GetHeroRotate()
	{
		return 0f;
	}

	public void SetRotate(float angle)
	{
	}

	public virtual void UpdateProgress()
	{
	}

	private float GetHeroRotate(float currenty, float endx, float endy, float framepery)
	{
		return 0f;
	}

	private void Update()
	{
	}

	public virtual void MoveEndCallBack()
	{
	}
}
