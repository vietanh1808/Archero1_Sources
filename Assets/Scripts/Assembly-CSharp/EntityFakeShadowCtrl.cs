using UnityEngine;

public class EntityFakeShadowCtrl : PauseObject
{
	private const float OFFSET_ANGLE = 30f;

	private Vector3 curMoveDir;

	private float moveSpeed;

	[HideInInspector]
	public EntityBase m_Entity;

	protected override void UpdateProcess()
	{
	}

	public void Init(EntityBase parent)
	{
	}

	public void RandomMovDir()
	{
	}
}
