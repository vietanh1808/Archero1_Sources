using UnityEngine;

public class AIMove1033 : AIMoveBase
{
	private EntityBase target;

	private int range;

	private float maxdis;

	private bool move2target;

	private bool bExcuteShow;

	private Vector3 endpos;

	private ActionBattle action;

	private ConditionTime mCondition;

	public AIMove1033(EntityBase entity, float maxdis, int range, bool move2target)
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

	private void KillAction()
	{
	}

	private void Show(bool show)
	{
	}
}
