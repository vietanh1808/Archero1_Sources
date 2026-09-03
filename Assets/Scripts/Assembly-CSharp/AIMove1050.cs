using DG.Tweening;
using UnityEngine;

public class AIMove1050 : AIMoveBase
{
	protected EntityBase target;

	protected Vector3 nextpos;

	protected Vector3 endpos;

	private Sequence seq;

	private Animation ani;

	private bool bShow;

	private int m_nBulletId;

	private int m_nBulletCnt;

	public AIMove1050(EntityBase entity, int nBulletId, int cnt)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void SetAnimation()
	{
	}

	private void CreateBullets(int count)
	{
	}

	private void DeInitSeq()
	{
	}

	private void show(bool value)
	{
	}

	protected override void OnEnd()
	{
	}
}
