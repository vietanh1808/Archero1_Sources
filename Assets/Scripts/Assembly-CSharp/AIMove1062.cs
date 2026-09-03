using UnityEngine;

public class AIMove1062 : AIJumpMoveBase
{
	private EntityBase target;

	private Vector3 dir;

	public float g;

	public int attackid;

	private float endx;

	private float endz;

	private float perendx;

	private float perendz;

	private float delaytime;

	private float starttime;

	public float alltime;

	private float halftime;

	private Vector3 startpos;

	private bool bPlaySkill;

	private float speedratio;

	public AIMove1062(EntityBase entity)
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

	protected override void OnEnd()
	{
	}
}
