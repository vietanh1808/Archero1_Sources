using UnityEngine;

public class EntityHeroAI : EntityBase
{
	private AIBase m_AIBase;

	private float mMoveStartAngle;

	private float mMoveTime;

	private float mNextMoveMaxTime;

	private int width;

	private int height;

	private Vector2Int mPrevV;

	private float mJoyMoveAngle;

	private float mJoyTime;

	private float mJoyMoveMaxTime;

	private bool bAttack;

	private JoyData mJoyData;

	public static EntityHeroAI mHeroAI { get; private set; }

	protected override void OnInitBefore()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void StartInit()
	{
	}

	protected override void InitCharacter()
	{
	}

	private void DeInitAI()
	{
	}

	protected override void OnDeInitLogic()
	{
	}

	protected override void UpdateProcess(float delta)
	{
	}

	protected override void OnChangeHP(EntityBase entity, long HP)
	{
	}

	private void FellGround()
	{
	}

	private void RandomMove()
	{
	}

	private void RandomJoyAngle()
	{
	}

	private void RandomAngleAndTime(out float angle, out float time)
	{
		angle = default;
		time = default;
	}

	private void CheckJoyMove()
	{
	}

	private void OnAttackStartEnd()
	{
	}

	private void UpdateMove()
	{
	}
}
