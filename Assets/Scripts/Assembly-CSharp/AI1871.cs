public class AI1871 : AIBase
{
	private const string LOG_TAG = "[AssistHero]";

	protected EntityBase m_Parent;

	private float _atkRange;

	private int _weaponId;

	private int _weaponIdAlt;

	private bool _useAlt;

	protected override void OnInit()
	{
	}

	public void InitAI()
	{
	}

	public void SetWeaponId(int weaponId)
	{
	}

	public void ResetAI()
	{
	}

	protected virtual void RefreshAIAction()
	{
	}

	private int GetAlternateWeaponId(int weaponId)
	{
		return 0;
	}

	private EntityBase FindTarget()
	{
		return null;
	}
}
