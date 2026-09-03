using UnityEngine;
using UnityEngine.UI;

public class CardUpgradeCtrl : MonoBehaviour
{
	public DxxText Text_UpgradeCount;

	public CardUILevelLimitCtrl mLevelLimitCtrl;

	public ButtonGoldCtrl Button_Upgrade;

	public DxxText Text_UpgradeContent;

	public Text Text_ButtonBG;

	public void UpdateUpgrade()
	{
	}

	public bool CanPushNotification(out string info)
	{
		info = null;
		return false;
	}

	public void OnLanguageChange()
	{
	}
}
