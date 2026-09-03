using UnityEngine;

public class AIMove1034_Net : AIMoveBase_Net
{
	private int offsetx;

	private int offsety;

	private int move2player;

	private bool isEnd;

	public AIMove1034_Net(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void OnMoveEvent(bool b)
	{
	}

	private Vector2Int UpdateMove2Player(float angle)
	{
		return default;
	}

	private bool GetMove2Player()
	{
		return false;
	}

	protected override void OnEnd()
	{
	}
}
