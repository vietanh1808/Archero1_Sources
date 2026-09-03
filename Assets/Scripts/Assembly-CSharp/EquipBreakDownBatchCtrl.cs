using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class EquipBreakDownBatchCtrl : MediatorCtrlBase
{
	public BoxOpenBoxAniCtrl mBoxCtrl;

	public DxxText Text_Got;

	public Transform gotparent;

	public TapToCloseCtrl mTapCloseCtrl;

	private const int width = 160;

	private const int height = 200;

	private const int LineCount = 4;

	private GameObject equipone;

	private LocalUnityObjctPool mPool;

	private LocalSave.TimeBoxType boxtype;

	private BoxOpenProxy.Transfer mTransfer;

	private List<Drop_DropModel.DropData> mEquipTransfer;

	private int currentIndex;

	private SequencePool mSeqPool;

	public GameObject effectFireObj;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	private void InitUI()
	{
	}

	private void init_box()
	{
	}

	private void show_equips()
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

	private void refreshText_Got()
	{
	}
}
