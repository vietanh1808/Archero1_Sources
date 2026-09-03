using System.Collections.Generic;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileGateUIPanel : CampTileBaseUIPanel<CampTileGateData, CampTileGateConfigData>
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText level;

	[SerializeField]
	private DxxText pos;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private CampTileProgress progress;

	[SerializeField]
	private CampTileOccupyReward occupyReward;

	[SerializeField]
	private CampTileOccupyBtn occupyBtn;

	[SerializeField]
	private CampTileCurrency currency;

	[SerializeField]
	private ButtonCtrl closeMask;

	[SerializeField]
	private CampTileIcon campTileIcon;

	[SerializeField]
	private CampTileAttackAni attackAni;

	[SerializeField]
	private Image levelObj;

	public GameObject NameObj;

	public DxxText Name;

	[SerializeField]
	private CampBuffPreviewIcon buffIcon;

	private static DelegateBridge __Hotfix0_get_CurWindowID;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_IsNeedShowCountDown;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshCommon;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_IsBtnEnableExtra;

	private static DelegateBridge __Hotfix0_ClickBtnDisableExtra;

	private static DelegateBridge __Hotfix0_RefreshTimeShow;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override WindowID CurWindowID => WindowID.WindowID_Invaild;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void Refresh()
	{
	}

	protected override void PlayAni(List<CampTileArrowDamageData> damageData, CRespCampBlock response, int oldLevel, CampTileOccupyAttackType attackType, int returnIronArrow, int returnGoldArrow, CampID recordOccupyCamp, int attackMonsterCampID)
	{
	}

	private bool IsNeedShowCountDown()
	{
		return false;
	}

	public void RefreshStatus()
	{
	}

	public void RefreshCommon()
	{
	}

	public void RefreshText()
	{
	}

	protected override bool IsBtnEnableExtra()
	{
		return false;
	}

	protected override bool ClickBtnDisableExtra()
	{
		return false;
	}

	protected override void RefreshTimeShow()
	{
	}

	protected override bool RefreshTime()
	{
		return false;
	}
}
