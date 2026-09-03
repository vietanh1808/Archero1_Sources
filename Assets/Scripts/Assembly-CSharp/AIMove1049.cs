using UnityEngine;

public class AIMove1049 : AIJumpMoveBase
{
	private EntityBase target;

	private float startTime;

	private float delaytime;

	private float jumptime;

	private float endtime;

	private bool bjumpend;

	private AnimationCurve curve;

	private Vector3 startpos;

	private Vector3 endpos;

	private float height;

	private float skillspeed;

	private bool m_bCreateBullet;

	private GameObject obj;

	public AIMove1049(EntityBase entity, bool bCreateBullet = false)
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

	private void AIMoveStart()
	{
	}

	private void AIMoving()
	{
	}

	private void CreateBullets()
	{
	}

	protected virtual GameObject GetEffect()
	{
		return null;
	}

	protected override void OnEnd()
	{
	}
}
