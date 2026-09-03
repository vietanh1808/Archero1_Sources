using UnityEngine;

public class AIMove1013 : AIJumpMoveBase
{
	private EntityBase target;

	private Vector3 dir;

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

	private bool bPlaySkill;

	private int _weaponId;

	public AIMove1013(EntityBase entity, int weaponId)
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
}
