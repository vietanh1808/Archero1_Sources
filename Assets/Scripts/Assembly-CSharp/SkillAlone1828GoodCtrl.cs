using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1828GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private GameObject SourceItem;

	[SerializeField]
	private GameObject RingParent;

	public float ringWidth;

	public float ringWidthMax;

	public float ringRadius;

	public float ringRadiusMax;

	public float angularVelocity;

	public float duration;

	public int ColliderCount;

	public float ringHeight;

	public float hitInterval;

	public List<CapsuleCollider> colliders;

	private bool isHitInFrame;

	private float activeTime;

	private Dictionary<int, EntityBase> hitEnermyDict;

	private Dictionary<int, float> hitEnermyTimeDict;

	public void ResetColliders()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	public void TriggerEntered(EntityBase e)
	{
	}

	private void Update()
	{
	}

	private void RingMove()
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
