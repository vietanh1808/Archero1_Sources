using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ShopOneCharacterDiscount : ShopOneBase
{
	public class HeroSetting
	{
		public int charid;

		public Vector3 position;

		public Vector3 scale;
	}

	public DxxText content_Text;

	public DxxText hero_Name;

	public ButtonCtrl button_Buy;

	public DxxText old_Price;

	public DxxText new_Price;

	public DxxText time_Text;

	public DxxText discount_Num;

	public DxxText discount_Text;

	public DxxText title;

	public CountDownCtrl mCountDownCtrl;

	private HeroDiscount data;

	public Image charImage;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_UpdateNet;

	private static DelegateBridge __Hotfix0_OnDeinit;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge _c__Hotfix0_ctor;

	public override void OnLanguageChange()
	{
	}

	public override void UpdateNet()
	{
	}

	protected override void OnDeinit()
	{
	}

	protected override void OnInit()
	{
	}
}
