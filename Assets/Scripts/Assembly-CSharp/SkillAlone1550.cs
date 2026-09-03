using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SkillAlone1550 : SkillAloneBase
{
	private float moveDis;

	private float thunderAtkRate;

	private float atkRadius;

	private int maxAtkCount;

	private float hitRatio;

	private float decreaseHitRatio;

	private float minHitRatio;

	private float thunderAtkInterval;

	private float thunderAliveTime;

	private float thunderAtkPercent;

	private SkillMoveBuff moveSkill;

	private Vector3 lastFramePos;

	private float curDis;

	private bool isMoving;

	private RoomGenerateBase.Room curRoom;

	private Tween thunderTween;

	private Transform thunderBall;

	private List<Action1550ThunderAtk> actionList;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room obj)
	{
	}

	private void onMovEnd()
	{
	}

	private void onMovStart()
	{
	}

	private void onUpdate()
	{
	}

	private void parseParams(string str)
	{
	}

	private void parseThunderParams(string thunderStr)
	{
	}

	private void parseHitParams(string hitStr)
	{
	}

	private void runThunderAtk()
	{
	}

	private Action1550ThunderAtk createActionThunderAtk()
	{
		return null;
	}

	private void onThunderBallRemoved(Action1550ThunderAtk action)
	{
	}
}
