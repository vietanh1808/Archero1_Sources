using System;
using System.Collections.Generic;
using Dxx.Net;
using Dxx.Util;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class DragonResetCtrl : MonoBehaviour, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnReset;

	[SerializeField]
	private DxxText txtReset;

	[SerializeField]
	private DxxText txtDesc;

	[SerializeField]
	private DxxText txtResetCost;

	[SerializeField]
	private GameObject goMaskRoot;

	[SerializeField]
	private EquipOneCtrl equipForAnimation;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private DragonEquipItem cellItem;

	private List<DragonCombineData> dataList;

	[SerializeField]
	private EquipOneCtrl propDragon;

	[SerializeField]
	private PropOneEquip[] propReturnList;

	[SerializeField]
	private GameObject effectFire;

	private LocalSave.EquipOne selected;

	private SequencePool seqPool;

	public void OnInit()
	{
	}

	private void OnBtnReset()
	{
	}

	private void OnResetResponse(NetResponse response)
	{
	}

	public void InitUI()
	{
	}

	private void GenerateDataList()
	{
	}

	public UITableViewCellAlignment AlignmentOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return UITableViewCellAlignment.RightOrTop;
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	private void OnClickOne(DragonEquipItem item)
	{
	}

	private void Refresh()
	{
	}

	private void RefreshPreview()
	{
	}

	private void RefreshInventory()
	{
	}

	private void SetState(DragonCombineData one)
	{
	}

	private void PlayMove(DragonEquipItem item, Action callback)
	{
	}

	private void android_escape()
	{
	}

	private void InitTabView()
	{
	}

	public UITableViewCell CellAtIndexInTableView(UITableView tableView, int index)
	{
		return null;
	}

	public int NumberOfCellsInTableView(UITableView tableView)
	{
		return 0;
	}

	public float ScalarForCellInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public int NumberOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return 0;
	}

	private int Comparison(DragonCombineData a, DragonCombineData b)
	{
		return 0;
	}
}
