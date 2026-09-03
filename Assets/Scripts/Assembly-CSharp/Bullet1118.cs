using UnityEngine;

public class Bullet1118 : BulletBase
{
	private enum JumpState
	{
		A_jump_none = 0,
		A_jump_start = 1,
		A_jump_idle = 2,
		A_jump_middle = 3,
		A_jump_end = 4
	}

	private Animator animator;

	private GameObject trail;

	private JumpState m_emJumpState;

	private bool m_bBeginJump;

	private Collider m_lastCollider;

	private float waittime;

	private float currenttime;

	private ActionBasic action;

	private float ySpeed;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void onHitWall(Collider c)
	{
	}

	private void onAnimationAction(string name)
	{
	}

	protected override void OnHitHero(EntityBase entity)
	{
	}

	protected override void OnBulletTrack()
	{
	}

	protected override void HitWater(Collider o)
	{
	}

	protected override void OnUpdate()
	{
	}

	private void Refresh()
	{
	}
}
