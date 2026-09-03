using UnityEngine;

public class AIMove1125 : AIMoveBase
{
	private Vector3 startpos;

	private Vector3 endpos;

	private int range;

	private float movetime;

	private float starttime;

	private float percent;

	private float percentby;

	private Vector3 dir;

	private float alldis;

	private float perdis;

	private float moveby;

	private float startattacktime;

	private bool bStartAttack;

	private int bulletindex;

	private float addspeed;

	private bool changeAnimSpeed;

	private int reboundcount;

	private const int ReboundMaxCount = 3;

	protected int curFrameCount;

	public float RadiusFactor;

	private bool isColliding;

	public AIMove1125(EntityBase entity, int range)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void updateMoveDir(Vector3 _startpos, Vector3 _endpos)
	{
	}

	protected override void OnUpdate()
	{
	}

	private void AttackGround()
	{
	}

	private void Attack()
	{
	}

	protected override void OnEnd()
	{
	}

	protected void OnCollideWall()
	{
	}

	private void recoverAnimSpeed()
	{
	}

	private void CheckCollision()
	{
	}

	protected virtual void OnCollision(RaycastHit hitInfo)
	{
	}
}
