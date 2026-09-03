using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class EventChest1TurnCtrl : MonoBehaviour
{
	private const int TableCount = 6;

	public Action<TurnTableType> TurnEnd;

	public Transform child;

	public Transform arrow;

	public List<EventChest1OneCtrl> mList;

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

	private TurnTableData resultData;

	private List<TurnTableData> list;

	private int playCount;

	private ActionBasic action;

	private Drop_DropModel.DropData[] equips;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void InitGood(Drop_DropModel.DropData[] equips)
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

	private void RotateAction()
	{
	}

	private Vector3 GetRandomOffset()
	{
		return default;
	}
}
