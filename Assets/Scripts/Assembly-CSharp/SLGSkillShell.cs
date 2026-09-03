using UnityEngine;
using UnityEngine.UI;
using XLua;

public class SLGSkillShell : MonoBehaviour
{
	public DxxText txt_slg_coin;

	public Image img_selected;

	public Image img_arrow;

	public ButtonCtrl btn_ok;

	public DxxText txt_ok;

	public Image img_mask;

	public Image img_check;

	public DxxText txt_bought;

	[HideInInspector]
	public int skillId;

	private static DelegateBridge __Hotfix0_get_canBuy;

	private static DelegateBridge __Hotfix0_get_HaveBought;

	private static DelegateBridge __Hotfix0_set_HaveBought;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnSelected;

	private static DelegateBridge __Hotfix0_OnBought;

	private static DelegateBridge __Hotfix0_OnOtherSkillSelected;

	private static DelegateBridge __Hotfix0_OnOtherSkillBought;

	private static DelegateBridge __Hotfix0_onClick;

	private static DelegateBridge __Hotfix0_Hide;

	private static DelegateBridge __Hotfix0_refreshSlgCoin;

	private static DelegateBridge __Hotfix0_setSlgCoinVisible;

	private static DelegateBridge __Hotfix0_GetPrice;

	private static DelegateBridge __Hotfix0_EnableSelect;

	private static DelegateBridge __Hotfix0_EnableBought;

	private static DelegateBridge _c__Hotfix0_ctor;

	private bool canBuy => false;

	public bool HaveBought { get; set; }

	public void OnOpen(int _skillId)
	{
	}

	public void OnSelected()
	{
	}

	public void OnBought()
	{
	}

	public void OnOtherSkillSelected()
	{
	}

	public void OnOtherSkillBought()
	{
	}

	private void onClick()
	{
	}

	public void Hide()
	{
	}

	private void refreshSlgCoin()
	{
	}

	private void setSlgCoinVisible(bool visible)
	{
	}

	public int GetPrice()
	{
		return 0;
	}

	public void EnableSelect(bool enable)
	{
	}

	public void EnableBought(bool enable)
	{
	}
}
