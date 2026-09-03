using PureMVC.Interfaces;
using UnityEngine.UI;

public class CharUpgradeUICtrl : MediatorCtrlBase
{
	public CharUpgradeInfoCtrl mInfoCtrl;

	public CharUpgradeHeroCtrl mHeroCtrl;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public CharUpgradeCtrl upgrade;

	public CharTrainCtrl train;

	private int tabIndex;

	public HeroLevelInfoCtrl levelInfo;

	public CharStarShowItem starItem;

	public Button buttonUpgrade;

	public Button buttonTrain;

	public DxxText upgradeText;

	public DxxText trainText;

	public DxxText upgradeText1;

	public DxxText trainText1;

	public RedNodeOneCtrl redNode;

	public DxxText titleTex;

	public int charid;

	private bool isHaveTrainGuider;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
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

	public override void OnLanguageChange()
	{
	}

	public void OnButtonClicked(int index)
	{
	}

	public void swichTabUpgrade()
	{
	}

	public void switchTabTrain()
	{
	}

	public void showStar()
	{
	}

	public void showTrainGuider()
	{
	}
}
