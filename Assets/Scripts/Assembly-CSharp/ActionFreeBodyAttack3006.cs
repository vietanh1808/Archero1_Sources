using UnityEngine;

public class ActionFreeBodyAttack3006 : ActionFreeBodyAttack
{
	private GameObject effect;

	protected virtual int MoveEffectID => 0;

	public ActionFreeBodyAttack3006(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnForceEnd()
	{
	}

	private void createEffect()
	{
	}

	private void cacheEffect()
	{
	}
}
