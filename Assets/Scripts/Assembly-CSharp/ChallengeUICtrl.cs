using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public ChallengeInfoCtrl mInfoCtrl;

	public ScrollRectBase mScrollRect;

	public GridLayoutGroup scrollGroup;

	public GameObject copyitems;

	public GameObject copyitem;

	private LocalUnityObjctPool mPool;

	private List<Stage_Level_activity> mList;

	private int mCurrentID;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void PlayInfo(bool show)
	{
	}

	private void MoveToNext()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
