using System;

public class AIMove1070 : AIMoveBase
{
	private Action OnDown;

	private Action OnUp;

	private bool bShowCollider;

	private ConditionBase condition;

	private int time;

	private float radius;

	public AIMove1070(EntityBase entity, int time, float radius, Action OnDown = null, Action OnUp = null)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void Show(bool value)
	{
	}

	private void ShowCollider(bool value)
	{
	}
}
