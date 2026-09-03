public class AI5090 : AIDizzyBase
{
	private float originalRadius;

	private float maxRadius;

	private float animTime_attack01;

	private const string ATTACK_01 = "Attack 01";

	private const string ATTACK_02 = "Attack 02";

	private const string ATTACK_03 = "Attack 03";

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	protected override void OnDizzy(bool isDizzy)
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	protected override void PopulateActions()
	{
	}

	private ActionBase getRestAction()
	{
		return null;
	}

	private ActionBase getSkill1()
	{
		return null;
	}

	private ActionBase getSkill2()
	{
		return null;
	}

	private ActionBase getSkill3()
	{
		return null;
	}

	private float getSpeedTimes()
	{
		return 0f;
	}

	public bool CanRest()
	{
		return false;
	}

	private void playAttack01(float twistFactor = 1f)
	{
	}

	private void resetRadius()
	{
	}
}
