public class AISwordDragon : AIDragonBase
{
	private const float INIT_TIME = 0.95f;

	public const float TOTAL_TIME = 5f;

	private ActionCallSwords callSwords;

	protected override void OnInit1()
	{
	}

	protected override void AfterSkillAttackPre()
	{
	}

	private int GetSwordCount()
	{
		return 0;
	}

	private float GetTimeInterval()
	{
		return 0f;
	}

	private bool CanCrit()
	{
		return false;
	}

	private bool CanThroughEnemy()
	{
		return false;
	}

	private bool CanWithElements()
	{
		return false;
	}
}
