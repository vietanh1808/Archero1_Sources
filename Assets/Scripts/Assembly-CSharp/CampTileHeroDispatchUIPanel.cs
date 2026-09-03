using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileHeroDispatchUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText btnName;

	[SerializeField]
	private Image HeadIcon;

	[SerializeField]
	private DxxText additionRate;

	[SerializeField]
	private CampTileHeroDispatchItem dispatchItem;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl infoBtn;

	[SerializeField]
	private ButtonCtrl closeMask;

	public Image LevelObj;

	public DxxText Level;

	public GameObject NameObj;

	public DxxText Name;

	private CampTileHeroDispatchData data;

	private List<CampTileHeroDispatchItem> dispatchItems;

	private LocalUnityObjctPool pool;

	private int curSelectHeroID;

	private int rate;

	private static DelegateBridge __Hotfix0_get_CurPosHaveDispatch;

	private static DelegateBridge __Hotfix0_get_TileLevel;

	private static DelegateBridge __Hotfix0_get_CurResourcePos;

	private static DelegateBridge __Hotfix0_get_DispatchHeroData;

	private static DelegateBridge __Hotfix0_get_ResourceType;

	private static DelegateBridge __Hotfix0_get_DispatchHeadImgID;

	private static DelegateBridge __Hotfix0_get_CurSelectDispatchHeroData;

	private static DelegateBridge __Hotfix0_get_CurSelectHeroDispatchStatus;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshAdditionItem;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshBtnStatus;

	private static DelegateBridge __Hotfix0_RefreshData;

	private static DelegateBridge __Hotfix0_GetResourceHeroEffect;

	private static DelegateBridge __Hotfix0_GetHeroAdditionRate;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_Dispatch;

	private static DelegateBridge __Hotfix0_UnDispatch;

	private static DelegateBridge __Hotfix0_ClickInfo;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private bool CurPosHaveDispatch => false;

	private int TileLevel => 0;

	private (int, int) CurResourcePos => default;

	private LocalSave.CharacterOne DispatchHeroData => null;

	private CampTileResourceType ResourceType => CampTileResourceType.None;

	private int DispatchHeadImgID => 0;

	private LocalSave.CharacterOne CurSelectDispatchHeroData => null;

	private HeroDispatchStatus CurSelectHeroDispatchStatus => HeroDispatchStatus.None;

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

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void InitObjectPool()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshAdditionItem()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshBtnStatus()
	{
	}

	public void RefreshData()
	{
	}

	public List<(LocalSave.CharacterOne, int)> GetResourceHeroEffect()
	{
		return null;
	}

	public int GetHeroAdditionRate(LocalSave.CharacterOne heroData)
	{
		return 0;
	}

	private void Click()
	{
	}

	public void Dispatch()
	{
	}

	public void UnDispatch()
	{
	}

	private void ClickInfo()
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
