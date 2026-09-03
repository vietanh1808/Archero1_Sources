using Dxx.Util;
using UnityEngine;

public class AIMove1081 : AIJumpMoveBase
{
	private int m_nBulletId;

	private GameObject effect;

	private SequencePool mSeqPool;

	public AIMove1081(EntityBase entity, int bulletId)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd()
	{
	}

	private void CreateBullets(int count)
	{
	}
}
