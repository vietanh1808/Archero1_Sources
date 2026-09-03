using UnityEngine;

public class AIMoveChangeMonsterWalk : AIMoveBase
{
	private Vector3 targetPos;

	private float originLastTime;

	private float lastTime;

	public AIMoveChangeMonsterWalk(EntityBase entity, float lastTime)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}

	private void UpdateDirection()
	{
	}
}
