public class AIBase_Net : AIBase
{
	private int m_nWeaponId;

	private bool ForbiddenAttack => false;

	private bool IsOpponentPartBody => false;

	public int WeaponId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override void Attack(int AttackID, bool bRotate, EntityBase CustomHatredTarget = null)
	{
	}

	public override void AttackSpecial(int AttackID, bool bRotate)
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	protected void SyncActionCmd(string actionName, float offset)
	{
	}

	protected virtual void RefreshAIAction()
	{
	}
}
