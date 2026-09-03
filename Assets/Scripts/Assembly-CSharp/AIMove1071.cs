using DG.Tweening;

public class AIMove1071 : AIMove1036
{
	private Sequence seq;

	private bool addSkill;

	public AIMove1071(EntityBase entity, float move2playerratio, int time, float speedratio, bool shoot = true, bool addSkill = true)
		: base(null, 0f, 0, 0f, shoot: false)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd()
	{
	}
}
