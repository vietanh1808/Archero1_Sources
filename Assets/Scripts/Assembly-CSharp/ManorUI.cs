using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class ManorUI : ManorPanelBase
{
	public GameObject BG;

	public List<ManorRoad> RoadPointList;

	public GameObject cpCharItem;

	public GameObject CharObj;

	public GameObject BuildingObj;

	public ManorGuide Panel_Guider;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_initBuilding;

	private static DelegateBridge __Hotfix0_initBuildingRedPoint;

	private static DelegateBridge __Hotfix0_flyStealItem;

	private static DelegateBridge __Hotfix0_LoadChar;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Awake()
	{
	}

	public override void OnInit()
	{
	}

	public override void Open()
	{
	}

	private void initBuilding(int repairId = -1)
	{
	}

	private void initBuildingRedPoint()
	{
	}

	public void flyStealItem(ManorStealFlyData mssd)
	{
	}

	private void LoadChar()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_Open()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
