using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BattlePassNewCommonUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private RectTransform rectPanelParent;

	[SerializeField]
	private RectTransform rectBtnParent;

	[SerializeField]
	private BattlePassMainNewUICtrl mainBp;

	[SerializeField]
	private BattlePassOtherNewUICtrl bpTemplate;

	[SerializeField]
	private BattlePassNewBtnCtrl bpBtnTemplate;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ScrollRect bottomScroll;

	public ButtonCtrl Button_GetAll;

	public DxxText Text_GetAll;

	public GameObject RedPoint_GetAll;

	private Dictionary<LocalSave.NewBpType, BattlePassOtherNewUICtrl> _newBpMap;

	private Dictionary<LocalSave.NewBpType, BattlePassNewBtnCtrl> _newBpBtnMap;

	private Dictionary<LocalSave.NewBpType, LocalSave.BattlePassNewData> _allNewBpDataMap;

	private LocalSave.NewBpType _curBpType;

	protected override void OnInit()
	{
	}

	private void CheckBottomBtn()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void OnBpBtnClick(LocalSave.NewBpType bpType)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void RefreshBtnRedNode()
	{
	}

	private bool CheckBpIsOpen(LocalSave.NewBpType bpType)
	{
		return false;
	}

	private void RefreshBottomStatus(LocalSave.NewBpType closeBpType)
	{
	}

	public void onButtonGetAll()
	{
	}

	public void freshGetAllRedPoint()
	{
	}
}
