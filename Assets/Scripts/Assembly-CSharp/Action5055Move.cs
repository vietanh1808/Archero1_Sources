using UnityEngine;

public class Action5055Move : AIMoveToTargetLimited
{
	private GameObject effect;

	protected int MoveEffectID => 0;

	public Action5055Move(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void onAfterInit()
	{
	}

	private void CacheEffect()
	{
	}
}
