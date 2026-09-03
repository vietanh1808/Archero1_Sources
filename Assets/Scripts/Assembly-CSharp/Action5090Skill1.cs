using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

internal class Action5090Skill1 : ActionBasic.ActionBase
{
	private bool isRedLinesCreated;

	private List<BulletRedLineCtrl> redLineCtrlList;

	private Transform redlineParent;

	private float curRedlineTime;

	private float totalRedlineTime;

	private float lineWidth;

	private Sequence seq;

	private bool isCalling;

	private const int LASER_BULLET_ID = 5306;

	private bool isElite;

	private const int LIGHT_BALL_BULLET_ID = 5307;

	private float callAnimTime;

	private float toMaxTime;

	private bool canRunNormalAI;

	protected override void OnEnd()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void updateAttrs(int delta)
	{
	}

	private void normalMode()
	{
	}

	private void createLaserBullets()
	{
	}

	private void clearRedLineBullets()
	{
	}

	private void createLightBallBullets()
	{
	}

	private void playCallAnim(Action callback1, Action callback2)
	{
	}

	private void createRedLines()
	{
	}

	private void updateRedLines()
	{
	}

	private void reset()
	{
	}

	protected override void OnForceEnd()
	{
	}

	protected override void OnDeInit()
	{
	}
}
