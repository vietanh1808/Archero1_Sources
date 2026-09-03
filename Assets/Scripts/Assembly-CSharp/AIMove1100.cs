using UnityEngine;

public class AIMove1100 : AIMove1006
{
	private float m_fDistance;

	private float m_fTime;

	private float m_fStartTime;

	private Vector3? m_pos;

	public AIMove1100(EntityBase entity, int min, int max)
		: base(null, 0, 0)
	{
	}

	protected override void OnInitBase()
	{
	}

	private bool Condition()
	{
		return false;
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}
}
