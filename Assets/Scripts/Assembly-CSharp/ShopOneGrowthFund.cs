using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ShopOneGrowthFund : ShopOneBase
{
	[SerializeField]
	private ButtonCtrl btnGet;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtBtn;

	[SerializeField]
	private DxxText txtCrit;

	[SerializeField]
	private DxxText txtRewardUnlocked;

	[SerializeField]
	private DxxText txtRewardTotal;

	[SerializeField]
	private RectTransform rtRootUnlocked;

	[SerializeField]
	private RectTransform rtRootTotal;

	[SerializeField]
	private ShopOneGrowthFundItem template;

	[SerializeField]
	private HorizontalLayoutGroup hlUnlocked;

	[SerializeField]
	private HorizontalLayoutGroup hlTotal;

	[SerializeField]
	private ContentSizeFitter fitterUnlocked;

	[SerializeField]
	private ContentSizeFitter fitterTotal;

	[SerializeField]
	private RectTransform rtUnlocked;

	[SerializeField]
	private RectTransform rtTotal;

	private const int HEIGHT = 580;

	private LocalUnityObjctPool pool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_OnBtnGetClick;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnDeinit()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void UpdateNet()
	{
	}

	private void OnBtnGetClick()
	{
	}

	public override void UpdateUI()
	{
	}

	private void _003C_003ExLuaBaseProxy_UpdateUI()
	{
	}
}
