using PureMVC.Interfaces;
using UnityEngine.UI;
using XLua;
using newplay122;

public class DailyChooseTDLevelPanel : MediatorCtrlBase
{
	public DxxText txt_change_tip;

	public DxxText txt_map_name;

	public ButtonCtrl btn_close;

	public DxxText txt_title;

	public DxxText txt_wave_progress;

	public ButtonCtrl btn_battle;

	public DxxText txt_battle;

	public GoldTextCtrl battleCostCtrl;

	public ButtonCtrl btn_changeMap;

	public DxxText txt_changeMap;

	public GoldTextCtrl changeCostCtrl;

	public RawImage img_map;

	public RawImage img_map_bg1;

	public RawImage img_map_bg2;

	public RawImage img_map_bg3;

	public RawImage img_map_bg4;

	protected GamePlayActivityOne_NewPlay122 activityCtrl;

	protected LocalSave.GamePlayActivityOneData activityData;

	private RandomMapAnim randomMapAnim;

	private int curCostDiamond;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_initRandomMapAnim;

	private static DelegateBridge __Hotfix0_refreshWaveProgress;

	private static DelegateBridge __Hotfix0_refreshDiamond;

	private static DelegateBridge __Hotfix0_GetDiamond;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_closeWindow;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onBattle;

	private static DelegateBridge __Hotfix0_onChangeMap;

	private static DelegateBridge __Hotfix0_randomRefreshMap;

	private static DelegateBridge __Hotfix0_refreshMap;

	private static DelegateBridge __Hotfix0_getMapSn;

	private static DelegateBridge _c__Hotfix0_ctor;

	public override void OnLanguageChange()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void initRandomMapAnim()
	{
	}

	private void refreshWaveProgress()
	{
	}

	private void refreshDiamond()
	{
	}

	private int GetDiamond()
	{
		return 0;
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void closeWindow()
	{
	}

	private void android_escape()
	{
	}

	private void onBattle()
	{
	}

	private void onChangeMap()
	{
	}

	private void randomRefreshMap()
	{
	}

	private void refreshMap(int levelId)
	{
	}

	private int getMapSn(int levelId)
	{
		return 0;
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
