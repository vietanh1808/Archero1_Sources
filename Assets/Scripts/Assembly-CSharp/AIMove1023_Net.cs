using System.Collections.Generic;
using UnityEngine;

public class AIMove1023_Net : AIMoveBase_Net
{
	private EntityBase target;

	private List<Grid.NodeItem> findpath;

	private Vector3 nextpos;

	private Vector3 endpos;

	private int range;

	public AIMove1023_Net(EntityBase entity, int range)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void Find()
	{
	}
}
