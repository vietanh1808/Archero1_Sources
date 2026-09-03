using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CharUpgradeCtrl : MonoBehaviour
{
	public CharUpgradeUICtrl uiCtrl;

	public ButtonCtrl Button_Upgrade;

	public ButtonCtrl Button_UpgradeOneClick;

	public DxxText Text_IsMax;

	public GoldTextCtrl mGoldCtrl;

	public DxxText Text_Upgrade;

	public DxxText Text_UpgradeOneClick;

	public CharUpgradeNeedCtrl mNeedCtrl;

	public CharUpgradeLockCtrl mLockCtrl;

	public CardUILevelLimitCtrl mLimitCtrl;

	public Image Img_UpgradeOneClick;

	public void OnInit()
	{
	}

	private void UpgradeOneClick()
	{
	}

	private void send_upgrade(int diamond)
	{
	}

	private void CheckMaterialDeal()
	{
	}

	public void InitUI(bool first)
	{
	}

	private void upgrade_succeed()
	{
	}

	private void gold_buy_succeed(int diamond)
	{
	}

	public object OnGetEvent(string eventName)
	{
		return null;
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}
}
