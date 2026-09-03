using System;
using System.Collections.Generic;
using UnityEngine;

public class EntityHitCtrl
{
	public EntityBase m_Entity;

	public BoxCollider m_BoxCollider;

	public SphereCollider m_SphereCollider;

	public CapsuleCollider m_CapsuleCollider;

	private bool bEnable;

	private Vector3 box_scale;

	private float sphere_scale;

	private float capsule_scale;

	private List<float> scales;

	protected Dictionary<string, BoxCollider> m_ChildsBoxCollider;

	protected Dictionary<string, SphereCollider> m_ChildsSphereCollider;

	protected Dictionary<string, CapsuleCollider> m_ChildsCapsuleCollider;

	protected const string Entity2MapOutWall = "Entity2MapOutWall";

	protected const string Entity2Stone = "Entity2Stone";

	protected const string Entity2Water = "Entity2Water";

	protected const string Entity2DragonStone = "Entity2DragonStone";

	public Action<Collider> Event_TriggerEnter;

	public Action<Collider> Event_TriggerExit;

	public Action<Collision> Event_CollisionEnter;

	private int triggerCount;

	public void Init(EntityBase entity)
	{
	}

	public void SetCollider(bool enable)
	{
	}

	public void SetBodyScale(float scale)
	{
	}

	public void SetTrigger(bool value)
	{
	}

	public bool GetTrigger()
	{
		return false;
	}

	private void InitCollider()
	{
	}

	public void TryCreateDragonStoneCollider()
	{
	}

	public GameObject CreateCollider(string name, int layer)
	{
		return null;
	}

	private float addscale(float scale)
	{
		return 0f;
	}

	public void ResetColliderRadius(float radius)
	{
	}

	public void SetCollidersScale(float scale)
	{
	}

	public float GetColliderHeight()
	{
		return 0f;
	}

	public float GetCollidersSize()
	{
		return 0f;
	}

	public Vector3 GetColliderCenter()
	{
		return default;
	}

	public void RemoveColliders()
	{
	}

	public void SetFlyOne(string layer, bool fly)
	{
	}

	public bool GetColliderEnable()
	{
		return false;
	}

	public bool GetColliderTrigger()
	{
		return false;
	}

	private void OnTriggerEnter(Collider o)
	{
	}

	private void OnTriggerExit(Collider o)
	{
	}

	private void OnCollisionEnter(Collision o)
	{
	}
}
