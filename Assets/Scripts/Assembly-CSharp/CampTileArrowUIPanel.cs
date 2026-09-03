using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class CampTileArrowUIPanel : MediatorCtrlBase
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

	private List<CampTileArrowItem> createCampTileArrowItem;

	private CampTileArrowTransData data;

	private LocalUnityObjctPool outputItemBtnPool;

	private int selectIronArrowCount;

	private int selectGoldArrowCount;

	private static DelegateBridge __Hotfix0_get_Position;

	private static DelegateBridge __Hotfix0_get_TileType;

	private static DelegateBridge __Hotfix0_get_RecordOccupyValue;

	private static DelegateBridge __Hotfix0_get_RecordOccupyCamp;

	private static DelegateBridge __Hotfix0_get_RecordBossStage;

	private static DelegateBridge __Hotfix0_get_RecordBossMonsterOccupyValue;

	private static DelegateBridge __Hotfix0_get_RecordBossCampRank;

	private static DelegateBridge __Hotfix0_get_RecordBossCampScore;

	private static DelegateBridge __Hotfix0_get_NeedValue;

	private static DelegateBridge __Hotfix0_get_ResourceType;

	private static DelegateBridge __Hotfix0_get_CampTileManager;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_CheckData;

	private static DelegateBridge __Hotfix0_GetArrowClick;

	private static DelegateBridge __Hotfix0_LaunchArrowClick;

	private static DelegateBridge __Hotfix0_InfoClick;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private (int, int) Position => default;

	private CampTileType TileType => CampTileType.None;

	private int[] RecordOccupyValue => null;

	private CampID RecordOccupyCamp => CampID.Unknown;

	private int RecordBossStage => 0;

	private int[] RecordBossMonsterOccupyValue => null;

	private int[] RecordBossCampRank => null;

	private int[] RecordBossCampScore => null;

	private int NeedValue => 0;

	private CampTileResourceType ResourceType => CampTileResourceType.None;

	private CampTileManager CampTileManager => null;

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

	private void Esc()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
