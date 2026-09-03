using PureMVC.Interfaces;
using UnityEngine;

public class CharTrainCtrl : MonoBehaviour
{
	public CharUpgradeUICtrl uiCtrl;

	public ButtonCtrl Button_Upgrade;

	public DxxText Text_IsMax;

	public GoldTextCtrl mGoldCtrl;

	public DxxText Text_Upgrade;

	public CharUpgradeInfoCtrl mInfoCtrl;

	public CharTrainNeedCtrl mNeedCtrl;

	public RectTransform skillContent;

	public GameObject cpSki;

	public DxxText levelLimitText;

	public CharTrainStarUpTips popWindow;

	public DxxText skillTitleText;

	[SerializeField]
	private GameObject mOpenLimitParent;

	[SerializeField]
	private DxxText mTextOpenLimt;

	[SerializeField]
	private DxxText mTextOpenLimtDesc;

	[SerializeField]
	private RectTransform mHeadImg;

	public void OnInit()
	{
	}

	private void send_upgrade(int value)
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
