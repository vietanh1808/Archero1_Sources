using System;
using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SupperTurnTableCtrl : MonoBehaviour
{
	public Action TurnEnd;

	public Transform child;

	public Transform arrow;

	public List<SuperTurnTableOneCtrl> mList;

	private const float Speed = -20f;

	private float speed;

	private float speedtime;

	private float starttime;

	private bool bStart;

	private bool bDelayTurnEnd;

	private float turnendstarttime;

	private float turnendupdatetime;

	private float rotateangle;

	private SequencePool mSeqPool;

	private ActionBasic action;

	public void StartRot()
	{
	}

	public void DeInit()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void RotateAction()
	{
	}

	public void InitGood(List<SuperTurntableData> list)
	{
	}

	public void CheckResult()
	{
	}

	private bool isHit()
	{
		return false;
	}

	private float GetMinAngle(float angle)
	{
		return 0f;
	}
}
