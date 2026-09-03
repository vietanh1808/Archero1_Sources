public class AIBabyBase : AIBase
{
	public const float NearRange = 1f;

	protected EntityCallBase baby;

	protected int AttackID;

	protected EntityBase mParent;

	public float fardis { get; private set; }

	private string getactionname(string name)
	{
		return null;
	}

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	protected virtual ActionBase GetAILogic()
	{
		return null;
	}

	protected virtual ActionBase GetActionMove()
	{
		return null;
	}

	protected virtual bool IsDoorOpen()
	{
		return false;
	}

	protected virtual ActionBase GetAttackOrMove()
	{
		return null;
	}

	protected virtual void OnAddAttack(ActionChooseIf choose)
	{
	}

	protected bool GetFar()
	{
		return false;
	}

	protected ActionBase GetBabyMove()
	{
		return null;
	}

	protected virtual bool FindTarget()
	{
		return false;
	}

	protected virtual void OnGoToNextRoom(RoomGenerateBase.Room room)
	{
	}

	public void SetAttackID(int _attackId)
	{
	}
}
