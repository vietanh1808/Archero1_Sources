using UnityEngine;

public class AIMove1073 : AIMoveBase
{
	private Vector3 startpos;

	private Vector3 endpos;

	private int range;

	private float movetime;

	private float starttime;

	private float percent;

	private float percentby;

	private Vector3 dir;

	private float alldis;

	private float perdis;

	private float moveby;

	private float startattacktime;

	private bool bStartAttack;

	private int bulletindex;

	public AIMove1073(EntityBase entity, int range)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}
}
