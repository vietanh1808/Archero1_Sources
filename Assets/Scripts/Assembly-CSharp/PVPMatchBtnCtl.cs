using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class PVPMatchBtnCtl : MonoBehaviour
{
	public CooperationData cooperatonData;

	[Header("匹配")]
	public ButtonCtrl buttonMatch;

	public DxxText textName;

	public DxxText textNum;

	public DxxText textInvalid;

	public Image imageIcon;

	public GameObject buttonMatchMask;

	public LocalSave.GamePlayActivityOneData mData;

	public Daily_DailyType tableData;

	public Daily_PvPConfig tableConfig;

	public bool isMatchOpen;

	public Action resetLastTime;

	private Func<CooperationData.MatchType, bool> _condition;

	protected void Awake()
	{
	}

	public void RefreshData(Func<CooperationData.MatchType, bool> condition)
	{
	}

	public void RefreshBtn()
	{
	}

	public void OnLanguageChange()
	{
	}

	protected void OnClickMatch()
	{
	}

	private bool IsEngouh()
	{
		return false;
	}

	private void OnClickNormal()
	{
	}

	private void OnClickMathc()
	{
	}

	private void CreateProxy()
	{
	}

	public static void SendClickBtnEvent(int type)
	{
	}

	private void JoinRoom()
	{
	}

	private void CreateRoom()
	{
	}

	private void copyCooperationData()
	{
	}
}
