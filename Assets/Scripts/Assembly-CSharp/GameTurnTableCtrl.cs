using System;
using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class GameTurnTableCtrl : MonoBehaviour
{
	private const int TableCount = 6;

	public Action<TurnTableData> TurnEnd;

	public Transform child;

	public Transform arrow;

	public List<GameTurnTableOneCtrl> mList;

	private const float Speed = -20f;

	private float speed;

	private float speedtime;

	private float starttime;

	private bool bStart;

	private bool bDelayTurnEnd;

	private float turnendstarttime;

	private float turnendupdatetime;

	private float offset;

	private float rotateangle;

	private SequencePool mSeqPool;

	private TurnTableData resultData;

	private TurnTableData resultGet;

	private List<TurnTableData> list;

	private int playCount;

	private ActionBasic action;

	private bool isJumpAni;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void InitGood(List<TurnTableData> list)
	{
	}

	private void CheckResult()
	{
	}

	private float GetMinAngle(float angle)
	{
		return 0f;
	}

	private void Update()
	{
	}

	public void JumpAni()
	{
	}

	private void RotateAction()
	{
	}

	private Vector3 GetRandomOffset()
	{
		return default;
	}
}
