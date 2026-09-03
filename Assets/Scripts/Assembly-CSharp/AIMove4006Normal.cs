using System;

public class AIMove4006Normal : AIMoveBabyNormal
{
	private Func<bool> extraUpdateCond;

	public AIMove4006Normal(EntityBase entity, int min, int max, float fardis)
		: base(null, 0, 0, 0f)
	{
	}

	public void SetExtraUpdateCond(Func<bool> extraUpdateCond)
	{
	}

	protected override void OnUpdate()
	{
	}
}
