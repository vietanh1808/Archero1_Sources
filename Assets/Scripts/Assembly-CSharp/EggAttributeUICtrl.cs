using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class EggAttributeUICtrl : MediatorCtrlBase
{
	public enum AttrSource
	{
		Unkonwn = 0,
		Farm = 1,
		Book = 2
	}

	public class AttrData
	{
		public AttrSource source;

		public LocalSave.MonsterData data;
	}

	public RectTransform Window;

	public Image Image_HeadBG;

	public Image Image_HeadIcon;

	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Battle;

	public ButtonCtrl Button_Star;

	public ButtonCtrl Button_Go;

	public ButtonCtrl Button_Down;

	public ButtonCtrl Button_Find;

	public DxxText Text_ButtonUP;

	public DxxText Text_ButtonDown;

	public DxxText Text_ButtonStar;

	public DxxText Text_ButtonGo;

	public DxxText Text_CoinNum;

	public MonsterStarShow starShow;

	public Slider slider;

	public DxxText Text_Slider;

	public DxxText Slider_TextInfo;

	public DxxText Text_Arrive;

	public GameObject starTab;

	public DxxText starText;

	public Image starFocusImage;

	public GameObject starPanel;

	public RectTransform starContent;

	public GameObject attrTab;

	public DxxText attrText;

	public Image attrFocusImage;

	public GameObject attrPanel;

	public RectTransform attrContent;

	public RectTransform skillContainer;

	public UILineCtrlOne starLine;

	public RectTransform starContainer;

	public DxxText Text_Info2;

	public UILineCtrlOne Line_Title3;

	public DxxText Text_Info3;

	public GameObject Panel3;

	public EggMeadowBattlePanel meadowBattlePanel;

	public RectTransform attrContainer;

	public UILineCtrlOne attrTitle;

	public DxxText Text_Info4;

	public UILineCtrl storyTitle;

	public DxxText Text_KillTotal;

	public RectTransform storyContainer;

	public GameObject cpEggStarOne;

	public GameObject cpStoryOne;

	public GameObject cpAssistOne;

	public GameObject cpSkillOne;

	private static Color color1;

	private static Color color2;

	private AttrData attrData;

	private int curTab;

	private Equip_Monster em;

	private float selectedScaleY;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void android_escape()
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

	private void onButtonClose()
	{
	}

	private void onButtonGo()
	{
	}

	private void onButtonBattle()
	{
	}

	private void onButtonDown()
	{
	}

	private void onButtonStar()
	{
	}

	public void onButtonFind()
	{
	}

	public void onButtonPanelStar()
	{
	}

	public void onButtonPanelAttr()
	{
	}

	private void showStar()
	{
	}

	private void showAttr()
	{
	}

	private void freshBasicInfo()
	{
	}

	private void freshUI()
	{
	}
}
