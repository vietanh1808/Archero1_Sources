using System;
using UnityEngine;

public class SkillAlone2002StarCtrl : MonoBehaviour
{
	private bool isFlying;

	private bool isWaiting;

	private float delayTimer;

	private EntityBase targetEntity;

	private float flySpeed;

	private float arriveDistance;

	private Action<SkillAlone2002StarCtrl> onArriveCallback;

	private EntityBase m_Entity;

	public void Init(EntityBase entity)
	{
	}

	private void SetEffectWeakenStatus(bool isOpen, bool isForceLoad = false)
	{
	}

	public void FlyToTarget(EntityBase target, float speed, Action<SkillAlone2002StarCtrl> onArrive, float delay = 0f)
	{
	}

	private void Update()
	{
	}

	private void OnArrive()
	{
	}

	public void Recycle()
	{
	}
}
