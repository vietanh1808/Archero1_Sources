using System.Collections.Generic;

public class AIMove1011_Net : AIMoveBase_Net
{
	private List<Grid.NodeItem> findpath;

	private float findTime;

	private float findDelay;

	private bool bUpdateTime;

	private float updatetime;

	private float starttime;

	private float moveDistance;

	private bool isMoveEnd;

	private float startMoveTime;

	public AIMove1011_Net(EntityBase entity, int min = 0, int max = 0)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void FindPathAndMove(EntityBase target)
	{
	}

	private void OnMoveEvent(bool b)
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}
}
