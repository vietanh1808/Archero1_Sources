using UnityEngine;

public class AIMove1008_Net : AIMoveBase_Net
{
	private float Move_NextTime;

	private bool isStart;

	protected float time;

	private float move2playertatio;

	private float speedratio;

	private GameObject effect;

	private EntityBase target;

	private Vector3 dir;

	protected virtual int MoveEffectID => 0;

	public AIMove1008_Net(EntityBase entity, float move2playertatio, int time, float speedratio)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void MoveStart()
	{
	}

	private void CacheEffect()
	{
	}

	protected override void OnEnd()
	{
	}
}
