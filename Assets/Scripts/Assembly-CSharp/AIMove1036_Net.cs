public class AIMove1036_Net : AIMove1008_Net
{
	private float perattacktime;

	private float attackcurrenttime;

	private bool shoot;

	public AIMove1036_Net(EntityBase entity, float move2playerratio, int time, float speedratio, bool shoot = true)
		: base(null, 0f, 0, 0f)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected virtual void CreateBullet()
	{
	}
}
