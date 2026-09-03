using System.Collections.Generic;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileResourceUIPanel : CampTileBaseUIPanel<CampTileResourceData, CampTileResourceConfigData>
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
	private CampTileOutputPreview outputReward;

	[SerializeField]
	private CampTileDispatch dispatch;

	[SerializeField]
	private CampTileOccupyBtn occupyBtn;

	[SerializeField]
	private CampTileCurrency currency;

	[SerializeField]
	private ButtonCtrl closeMask;

	[SerializeField]
	private ButtonCtrl info;

	[SerializeField]
	private GameObject progressInfo;

	[SerializeField]
	private Image levelObj;

	[SerializeField]
	private CampTileIcon campTileIcon;

	[SerializeField]
	private CampTileAttackAni attackAni;

	[SerializeField]
	private ButtonCtrl btn_HolyRank;

	[SerializeField]
	private DxxText txt_Rank;

	[SerializeField]
	private DxxImage rankIcon;

	[SerializeField]
	private DxxText rankNum;

	public GameObject NameObj;

	public DxxText Name;

	[SerializeField]
	private CampBuffPreviewIcon buffIcon;

	private CampTileBattleStatus recordBattleStatus;

	private static DelegateBridge __Hotfix0_get_CurWindowID;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_RefreshRecordStatus;

	private static DelegateBridge __Hotfix0_OnBtnHolyRankClick;

	private static DelegateBridge __Hotfix0_RefreshHolyRankBtn;

	private static DelegateBridge __Hotfix0_RefreshCommon;

	private static DelegateBridge __Hotfix0_CalcNeedOccupyValue;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge __Hotfix0_ClickBtnExtra;

	private static DelegateBridge __Hotfix0_CanAttack;

	private static DelegateBridge __Hotfix0_IsBtnEnableExtra;

	private static DelegateBridge __Hotfix0_ClickBtnDisableExtra;

	private static DelegateBridge __Hotfix0_RefreshData;

	private static DelegateBridge __Hotfix0_ClickInfo;

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

	public void RefreshRecordStatus()
	{
	}

	private void OnBtnHolyRankClick()
	{
	}

	private void RefreshHolyRankBtn()
	{
	}

	public void RefreshCommon()
	{
	}

	public int CalcNeedOccupyValue()
	{
		return 0;
	}

	public void RefreshText()
	{
	}

	public void RefreshStatus()
	{
	}

	protected override bool RefreshTime()
	{
		return false;
	}

	protected override bool ClickBtnExtra()
	{
		return false;
	}

	public bool CanAttack()
	{
		return false;
	}

	protected override bool IsBtnEnableExtra()
	{
		return false;
	}

	protected override bool ClickBtnDisableExtra()
	{
		return false;
	}

	public void RefreshData()
	{
	}

	private void ClickInfo()
	{
	}
}
