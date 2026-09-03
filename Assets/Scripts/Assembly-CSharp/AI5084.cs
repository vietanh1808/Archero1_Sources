using Dxx.Util;
using UnityEngine;

public class AI5084 : AI5070
{
	private GameObject m_shadow;

	private SequencePool mSeqPool;

	private ActionBasic m_action;

	private int m_nThunderMaxCnt;

	protected override void OnInit()
	{
	}

	protected override ActionBase GetAttack_5242()
	{
		return null;
	}

	protected override void OnAIDeInit()
	{
	}

	protected override ActionBase GetMove2()
	{
		return null;
	}

	private void CallThunder()
	{
	}

	private float CalMinDistance(in Vector3 startPos, float[] mindises, in Vector3[] dirs)
	{
		return 0f;
	}

	protected override void OnUpdate(float delta)
	{
	}
}
