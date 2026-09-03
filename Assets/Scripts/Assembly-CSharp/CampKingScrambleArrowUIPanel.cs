using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class CampKingScrambleArrowUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText getArrowBtnName;

	[SerializeField]
	private DxxText launchArrowBtnName;

	[SerializeField]
	private Transform arrowItemParent;

	[SerializeField]
	private CampTileArrowItem arrowItem;

	[SerializeField]
	private ButtonCtrl getArrowBtn;

	[SerializeField]
	private ButtonCtrl launchArrowBtn;

	[SerializeField]
	private ButtonCtrl infoBtn;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private CampTileArrowBuyUIPanel buyUIPanel;

	[SerializeField]
	private ButtonCtrl closeMask;

	public GameObject LevelObj;

	public GameObject NameObj;

	private (int, int) position;

	private List<CampTileArrowItem> createCampTileArrowItem;

	private LocalUnityObjctPool outputItemBtnPool;

	private int selectIronArrowCount;

	private int selectGoldArrowCount;

	private CampTileManager CampTileManager => null;

	private CampKingScrambleManager CampKingScrambleManager => null;

	protected override void OnInit()
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

	public void InitObjectPool()
	{
	}

	public void RefreshItem()
	{
	}

	private void CheckData(Action success)
	{
	}

	private void GetArrowClick()
	{
	}

	public void LaunchArrowClick()
	{
	}

	private void InfoClick()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void ClickCloseBtn()
	{
	}

	private void ClickMaskBtn()
	{
	}

	private void Esc()
	{
	}
}
