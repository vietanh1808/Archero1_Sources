using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class DoubleChallengeReportUIPanel : MediatorCtrlBase
{
	public ButtonCtrl closeBtn;

	public ButtonCtrl BgBtn;

	public ButtonCtrl infoBtn;

	public DxxText titleTex;

	public InfiniteListView listView;

	public GameObject emptyObj;

	public DxxText emptyTex;

	private List<ViewCellData> datas;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	protected override void OnDeInit()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshList()
	{
	}

	private void OnClickInfo()
	{
	}

	private void ClosePanel()
	{
	}

	private void android_escape()
	{
	}
}
