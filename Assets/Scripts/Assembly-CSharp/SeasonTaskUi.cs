using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SeasonTaskUi : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl Button_Back;

	[SerializeField]
	private Text Text_Title;

	[SerializeField]
	private DxxText Text_Time;

	[SerializeField]
	private SeasonTaskItem taskItem;

	[SerializeField]
	private RectTransform content;

	private LocalUnityObjctPool mPool;

	private SequencePool mSeqPool;

	private float itemheight;

	private float height;

	private List<SeasonTaskItem> tlist;

	protected override void OnInit()
	{
	}

	private void RefreshList()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	private void Update()
	{
	}
}
