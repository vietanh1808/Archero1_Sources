using UnityEngine;

public class AIMove1024_Net : AIMoveBase_Net
{
	private EntityBase target;

	private Vector3 dir;

	private int flyframe;

	private float g;

	private float endx;

	private float endz;

	private float perendx;

	private float perendz;

	private float delaytime;

	private float starttime;

	private float alltime;

	private float halftime;

	private Vector3 startpos;

	private int range;

	private bool moveStarted;

	protected virtual int AttackID => 0;

	public AIMove1024_Net(EntityBase entity, int range)
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

	private void syncColliderCmd(bool _enable)
	{
	}

	private void syncPos(Vector3 _pos)
	{
	}
}
