using UnityEngine;

public class AIMoveBabyMoveParent : AIMoveBase
{
	private int range;

	private EntityBase parent;

	private Vector3 endpos;

	private float tickDistance;

	private float tickTime;

	private const float m_fTimeMax = 5f;

	private float m_fTime;

	public AIMoveBabyMoveParent(EntityBase entity, EntityBase parent, int range)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void UpdateDirection()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}
}
