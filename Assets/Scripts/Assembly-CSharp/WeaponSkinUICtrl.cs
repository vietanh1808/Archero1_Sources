using PureMVC.Interfaces;
using TableTool;

public class WeaponSkinUICtrl : MediatorCtrlBase
{
	public WeaponSkinTopPart weaponSkinTopPart;

	public WeaponSkinShowPart weaponSkinShowPart;

	public WeaponSkinSelectPart weaponSkinSelectPart;

	public WeaponSkinAttributePart weaponSkinAttributePart;

	public WeaponSkinBottomPart weaponSkinBottomPart;

	public WeaponSkinModelPart weaponSkinModelPart;

	public WeaponColorSkinPart weaponColorSkinPart;

	public WeaponSkinUIData openData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void ShowWeapon(int weaponType, int skinId, int colorID)
	{
	}

	public void OnClickBuyCallBack(int weaponType, int skinId, int source, string SourceInfo)
	{
	}

	private bool isCanClaimOrUse(Equip_WeaponSkin skin)
	{
		return false;
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void FlyExchangeReward(bool isColor = false)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void ReqActivateSkinOrColor(int skinID, bool isColor)
	{
	}
}
