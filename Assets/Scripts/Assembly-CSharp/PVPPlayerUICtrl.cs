using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PVPPlayerUICtrl : MediatorCtrlBase
{
	public PlayerHeadItemCtrl headItemCtrl;

	public PlayerHeadBoxCtrl headBoxCtrl;

	public PlayerEmojiItemCtrl emojiItemCtrl;

	public PlayerHomePageCtrl homePageItemCtrl;

	public PlayerMedalCtrl playerMedalCtrl;

	public HeadItemOne headItem;

	public Button headButton;

	public Button headBoxButton;

	public Button emojiButton;

	public Button homePageButton;

	public Button medalPageButton;

	public GameObject headFocus;

	public GameObject headBoxFocus;

	public GameObject emojiFocus;

	public GameObject homePageFocus;

	public GameObject medalPageFocus;

	public DxxText Text_ID;

	public DxxText Text_Face;

	public DxxText Text_HeadBox;

	public DxxText Text_emoji;

	public DxxText Text_homePage;

	public DxxText Text_medalPage;

	public DxxText Text_Time;

	public DxxText Text_HeadBox_Focus;

	public DxxText Text_Face_Focus;

	public DxxText Text_homePage_Focus;

	public DxxText Text_medalPage_Focus;

	public DxxText Text_OK;

	public Image Image_OK;

	public ButtonCtrl Button_OK;

	public ButtonCtrl Button_Input;

	public ButtonCtrl Button_Close;

	public Text Text_Name;

	public DxxText Text_PreTitle;

	public DxxText Text_Condition;

	public GameObject HeadBG;

	public GameObject HeadFromBG;

	public DxxText Text_desc;

	public Image QualityBG;

	private Color cq2;

	private Color cq3;

	private Color cq4;

	private Color cq6;

	public RedNodeCtrl redNodeCtrl1;

	public RedNodeCtrl redNodeCtrl2;

	public RedNodeCtrl redNodeCtrl3;

	public RedNodeCtrl redNodeCtrl4;

	public Color tabYes;

	public Color tabNo;

	private const float tabYesPosY = 15f;

	private const float tabNoPosY = 10f;

	private const float redNodeYesPosY = 0f;

	private const float redNodeNoPosY = -6f;

	private int currentTab;

	public int TempTabHeadIndex;

	public int TempTabHeadFrameIndex;

	public DxxText Text_Title;

	public VIPInfoItem vipItem;

	public PVPHeadAttItem[] pvpHeadItems;

	private List<RedNodeCtrl> redNodes;

	public HeroAssistLine heroLine;

	private bool headItemCtrlInitFlag;

	private bool headBoxCtrlInitFlag;

	private bool emojiItemCtrlInitFlag;

	private bool homePageItemCtrlInitFlag;

	private bool playerMedalCtrlInitFlag;

	private bool isButtonOKVisible;

	private bool isTextDescVisible;

	protected override void OnInit()
	{
	}

	private void setEmojiInvisible()
	{
	}

	protected override void OnOpen()
	{
	}

	private void freshRedPoint()
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

	private void updateTextDescVisible(bool visible)
	{
	}

	private void updateButtonOKVisible(bool visible)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	public void OnButtonTab(int tab)
	{
	}

	private void openHeadItem()
	{
	}

	private void openHeadBox()
	{
	}

	public void resetBottomVisible()
	{
	}

	private void openHomePageItem()
	{
	}

	private void openMedalPageItem()
	{
	}

	public void onButtonInput()
	{
	}

	public void onButtonOK()
	{
	}

	public void onClickHeadOne(int headid)
	{
	}

	public void onClickHeadFrameOne(int headfid)
	{
	}

	private void setQualityText(int quality)
	{
	}
}
