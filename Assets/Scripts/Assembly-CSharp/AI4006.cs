public class AI4006 : AIBase
{
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

	private bool CanAIDoBehavior()
	{
		return false;
	}

	protected virtual ActionBase GetActionMove()
	{
		return null;
	}

	private bool Move4006Cond()
	{
		return false;
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

	private bool AttackCond()
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
}
