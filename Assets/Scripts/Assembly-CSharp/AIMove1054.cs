using DG.Tweening;
using UnityEngine;

public class AIMove1054 : AIMoveBase
{
	private const int BULLET_ID = 5077;

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

	private const float skillspeed = -0.5f;

	private Sequence seq_play;

	private bool bAttack;

	private Vector3 lastPos;

	private float delatDis;

	public const float DELTA_DIS = 1.5f;

	public AIMove1054(EntityBase entity)
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

	private void CreateBullet()
	{
	}

	private void UpdateDirection()
	{
	}

	protected override void OnEnd()
	{
	}
}
