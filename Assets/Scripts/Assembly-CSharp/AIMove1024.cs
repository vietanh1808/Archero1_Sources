using UnityEngine;

public class AIMove1024 : AIMoveBase
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

	private int range;

	private bool isFired;

	protected virtual int AttackID => 0;

	public AIMove1024(EntityBase entity, int range)
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

	private void UpdateDirection()
	{
	}

	protected override void OnEnd()
	{
	}

	private void createBullets()
	{
	}
}
