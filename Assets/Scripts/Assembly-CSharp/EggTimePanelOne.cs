using UnityEngine;
using UnityEngine.UI;

public class EggTimePanelOne : MonoBehaviour
{
	public GameObject Loader;

	public DxxText Text_Title;

	public DxxText Kill_Hatch;

	public DxxText Kill_Desc;

	public Slider Kill_Slider;

	public DxxText Kill_Progress;

	public DxxText Time_Hatch;

	public DxxText Time_Desc;

	public Slider Time_Slider;

	public DxxText Time_Progress;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Go;

	public DxxText Text_ButtonGo;

	public ButtonCtrl Button_Time;

	public DxxText Text_Time;

	public EggTimeCardOne[] timeCardBox;

	private LocalSave.EggData data;

	private int monsterid;

	private int TimeTotal;

	private int TimeSpace;

	private int TimePass;

	private int needKill;

	private int have;

	public EggTimeCardUICtrl uiCtrl;

	public GameObject Pop_Window;

	public DxxText Pop_Title;

	public DxxText Pop_Content;

	public ButtonCtrl Button_Pop;

	public DxxText Pop_ButtonText;

	public GameObject Panel_Button;

	public RectTransform RTF_POPBG;

	private EggTimeCardType cardType;

	public ButtonCtrl Button_Ad;

	public AdsController ads;

	public DxxText Text_AdTime;

	public DxxText Text_AdCount;

	public long adNeedTimex;

	public DxxText RTText;

	public GameObject RTRedBox;

	public void OnInit()
	{
	}

	public void OnClose()
	{
	}

	public void init()
	{
	}

	private void onButtonGo()
	{
	}

	private void calcuteTimex()
	{
	}

	public void onLanguageChanged()
	{
	}

	public void onButtonTime()
	{
	}

	public void freshUI()
	{
	}

	public bool checkHaveFinish()
	{
		return false;
	}

	public void openPopWindow(TimeCardPopData data)
	{
	}

	public void onButtonPopUse()
	{
	}

	public void onButtonClickPopWindow()
	{
	}

	public void freshAdState()
	{
	}

	private void onButtonAd()
	{
	}

	private void calcuteAdTime()
	{
	}
}
