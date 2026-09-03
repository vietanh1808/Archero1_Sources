using UnityEngine;
using UnityEngine.UI;
using XLua;

public class MiningGuideUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Pic;

	public DxxText Text_Pic;

	public GameObject Focus_Pic;

	public ButtonCtrl Button_Rule;

	public DxxText Text_Rule;

	public GameObject Focus_Rule;

	public ButtonCtrl Button_Reward;

	public DxxText Text_Reward;

	public GameObject Focus_Reward;

	public GameObject Panel_Pic;

	public GameObject Panel_Rule;

	public GameObject Panel_Reward;

	public DxxText Reward_Title1;

	public DxxText Reward_Title2;

	public DxxText Reward_Title3;

	public DxxText Reward_Title4;

	public RectTransform Container1;

	public RectTransform Container2;

	public RectTransform Container3;

	public RectTransform Container4;

	public GameObject cpRewardItem;

	public DxxText Text_Desc;

	private int currentTab;

	public ScrollRect scrollRect;

	public DxxText contentText;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge __Hotfix0_onButtonClose;

	private static DelegateBridge __Hotfix0_onButtonPic;

	private static DelegateBridge __Hotfix0_onButtonRule;

	private static DelegateBridge __Hotfix0_onButtonReward;

	private static DelegateBridge __Hotfix0_showTab;

	private static DelegateBridge __Hotfix0_addRewardList;

	private static DelegateBridge _c__Hotfix0_ctor;

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

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonPic()
	{
	}

	private void onButtonRule()
	{
	}

	private void onButtonReward()
	{
	}

	private void showTab(int tab)
	{
	}

	private void addRewardList(RectTransform rtf, int key)
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
}
