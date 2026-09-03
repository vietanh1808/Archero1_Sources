using System;

public class AIMove4006MoveParent : AIMoveBabyMoveParent
{
	private Func<bool> extraUpdateCond;

	public AIMove4006MoveParent(EntityBase entity, EntityBase parent, int range)
		: base(null, null, 0)
	{
	}

	public void SetExtraUpdateCond(Func<bool> extraUpdateCond)
	{
	}

	protected override void OnUpdate()
	{
	}
}
