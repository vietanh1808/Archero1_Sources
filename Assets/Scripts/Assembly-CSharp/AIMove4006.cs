public class AIMove4006 : AIMoveBase
{
	protected EntityBase mParent;

	private EntityPetBase mPet;

	protected float Move_NextX;

	protected float Move_NextY;

	private bool isStart;

	protected float speed;

	private int index;

	private int checkindex;

	protected float fardis;

	public AIMove4006(EntityBase entity, float fardis)
		: base(null)
	{
	}

	protected virtual void update_baby_parent()
	{
	}

	protected override void OnInitBase()
	{
	}

	protected virtual bool CheckMove()
	{
		return false;
	}

	protected override void OnUpdate()
	{
	}

	private void MoveNormal()
	{
	}

	protected virtual bool GetNear()
	{
		return false;
	}

	private void AIMoveStart()
	{
	}

	protected virtual void UpdateMoveDirection()
	{
	}

	private void AIMoving()
	{
	}

	protected override void OnEnd()
	{
	}
}
