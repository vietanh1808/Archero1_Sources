using UnityEngine;

public class AIMove3224 : AIMoveBase
{
	private float MoveSpeedCoe { get; set; }

	private float RotateSpeedCoe { get; set; }

	private float MoveSpeed { get; set; }

	private float RotateSpeed { get; set; }

	private float MoveSpeedMax { get; set; }

	private float RotateSpeedMax { get; set; }

	private float OriginMoveSpeed { get; set; }

	private float OriginRotateSpeed { get; set; }

	private float AccumulateTime { get; set; }

	public static AIMove3224 Create(EntityBase entity, float moveSpeed, float moveSpeedMax, float moveSpeedCoe, float rotateSpeed, float rotateSpeedMax, float rotateSpeedCoe)
	{
		return null;
	}

	public AIMove3224(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private bool IsMoveOver()
	{
		return false;
	}

	private float GetMoveSpeed()
	{
		return 0f;
	}

	private float GetRotateSpeed()
	{
		return 0f;
	}

	private (Vector3, Vector3) GetDir()
	{
		return default;
	}

	private float GetRunBubbleInterval(float moveSpeed)
	{
		return 0f;
	}

	private bool IsEntityValid()
	{
		return false;
	}

	private bool IsHitWall()
	{
		return false;
	}

	private new void Reset()
	{
	}

	private void RunBubble(float moveSpeed)
	{
	}

	private void ShowRunBubble(Vector3 pos)
	{
	}
}
