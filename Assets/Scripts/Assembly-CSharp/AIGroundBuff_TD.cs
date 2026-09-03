using System.Collections.Generic;
using UnityEngine;

public class AIGroundBuff_TD : AIDizzyBase
{
	protected GameObject groundEffect;

	private Dictionary<EntityBase, ConditionTime> enemyCDDict;

	private GameObject hitObj;

	private TD2023HitCtrlBase hitCtrl;

	private float timeInterval;

	protected virtual int GetBuffId()
	{
		return 0;
	}

	protected override void OnInitOnce()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private void initTimeInterval()
	{
	}

	private void onEnemyDead(EntityBase entity)
	{
	}

	private void onTriggerEnter(Collider collider)
	{
	}

	private void onTriggerStay(Collider collider)
	{
	}

	private void onTriggerExit(Collider collider)
	{
	}

	private void trySendBuff(Collider collider)
	{
	}

	private void removeEntityFromDict(EntityBase entity)
	{
	}

	private bool canSendBuff(EntityBase entity)
	{
		return false;
	}
}
