using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class AI5042 : AIBase
{
	private int calldelay1;

	private int calldelay2;

	private float prev_scale;

	private SequencePool mSeqPool;

	private SequencePool mSeqPool2;

	private float delay;

	private List<Vector3> poslist;

	private List<GameObject> prevs;

	private List<BulletRedLineCtrl> mLines;

	protected float startangle;

	private static float[] angles;

	protected virtual int BulletId => 0;

	protected virtual List<int> callids => null;

	protected override void OnInitOnce()
	{
	}

	protected virtual List<int> GetCallIds()
	{
		return null;
	}

	protected override void OnInit()
	{
	}

	private void showlines(bool show)
	{
	}

	private void ClearLines()
	{
	}

	private void CreateBullets()
	{
	}

	protected virtual void CreateBullet(float angle)
	{
	}

	protected override void OnAIDeInit()
	{
	}
}
