using UnityEngine;

public class AIMove1008 : AIMoveBase
{
	protected float Move_NextTime;

	protected float Move_NextX;

	protected float Move_NextY;

	protected bool isStart;

	protected float time;

	private float move2playertatio;

	protected float speedratio;

	private GameObject effect;

	protected virtual int MoveEffectID => 0;

	protected virtual float offsetTime => 0f;

	public AIMove1008(EntityBase entity, float move2playertatio, int time, float speedratio)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected virtual void OnInitBaseExtra()
	{
	}

	protected virtual void CalDirection()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected virtual void MoveNormal()
	{
	}

	protected void AIMoveStart()
	{
	}

	protected virtual void CustomizeMoveEffect(GameObject moveEffect)
	{
	}

	protected virtual void RotateHero()
	{
	}

	protected virtual void AIMoving()
	{
	}

	protected void AIMoveEnd()
	{
	}

	private void CacheEffect()
	{
	}

	protected override void OnEnd()
	{
	}
}
