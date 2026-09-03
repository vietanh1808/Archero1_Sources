using UnityEngine;

public class AIMove1064 : AIJumpMoveBase
{
	private EntityBase target;

	private Vector3 dir;

	public float g;

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

	private bool m_bDizzy;

	private int m_nBulletId;

	private int m_nBulletCnt;

	private int m_nEliteBulletCnt;

	private float m_fTotalBulletAngle;

	private float m_fRate;

	public AIMove1064(EntityBase entity, int nBulletId, int cnt, int eliteCnt, float totalAngle, float rate = 1f)
		: base(null)
	{
	}

	public AIMove1064(EntityBase entity)
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

	protected override void OnDizzy(bool value)
	{
	}
}
