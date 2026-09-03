using System;
using UnityEngine;

public class Goods1005EffectCtrl : MonoBehaviour
{
	public Action<EntityBase> Event_TriggerEnter;

	public Action<EntityBase> Event_TriggerStay;

	public Action<EntityBase> Event_TriggerAllEnter;

	public Action<EntityBase> Event_TriggerAllStay;

	private void OnTriggerEnter(Collider o)
	{
	}

	private void OnTriggerStay(Collider o)
	{
	}
}
