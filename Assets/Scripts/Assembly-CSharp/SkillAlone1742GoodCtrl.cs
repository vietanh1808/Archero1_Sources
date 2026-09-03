using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1742GoodCtrl : MonoBehaviour
{
	[SerializeField]
	private CapsuleCollider _collider;

	private float CONFIG_RADIUS;

	private int CONFIG_DEBUFF_ID;

	private EntityBase m_Entity;

	private Dictionary<EntityBase, float> m_dicHitTimes;

	public void Init(EntityBase entity, float radius, int debuffId)
	{
	}

	public void DeInit()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void CheckSendBuff(Collider other)
	{
	}
}
