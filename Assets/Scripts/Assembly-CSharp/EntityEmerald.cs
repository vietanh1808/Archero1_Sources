using UnityEngine;

public class EntityEmerald : EntityParentBase
{
	public BoxCollider emeraldCollider;

	public GameObject goEmerald;

	private Vector3 originalScale;

	private Vector3 originalColliderSize;

	public EntityEmeraldHit emeraldHit;

	public bool IsReady { get; set; }

	private void Awake()
	{
	}

	public void DeInit()
	{
	}

	public void Scale(float percent)
	{
	}

	public override void SetEntityParent(EntityBase entity)
	{
	}
}
