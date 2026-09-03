using System;

public class AIMove1032 : AIMove1008
{
	private Action OnCollisionWallCallback;

	protected override int MoveEffectID => 0;

	public AIMove1032(EntityBase entity, float move2playerratio, int time, float speedratio, Action callback = null)
		: base(null, 0f, 0, 0f)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd()
	{
	}

	protected void OnCollisionWall()
	{
	}
}
