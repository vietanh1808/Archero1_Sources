using UnityEngine;

public class AIMove1015 : AIMoveBase
{
	private EntityBase target;

	private Vector3 dir;

	private int flyframe;

	private float g;

	private float endx;

	private float endz;

	private float perendx;

	private float perendz;

	private float delaytime;

	private float starttime;

	private float alltime;

	private float halftime;

	private Vector3 startpos;

	public AIMove1015(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void MoveNormal()
	{
	}

	private void OnFly()
	{
	}

	private void RandomItem(out float endx, out float endz)
	{
		endx = default;
		endz = default;
	}
}
