using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class EggActivityUICtrl : MediatorCtrlBase
{
	public GameObject Loader;

	private EggHatchCtrl eggHatchCtrl;

	private Farm3DUI farm3dCtrl;

	private MonsterBookCtrl bookCtrl;

	private MeadowBattleCtrl meadowBattleCtrl;

	public ButtonCtrl Button_Close;

	public ButtonCtrl buttonEgg;

	public GameObject eggImage;

	public DxxText eggButtonText;

	public ButtonCtrl Button_Farm;

	public GameObject Image_Farm;

	public DxxText Text_Farm;

	public ButtonCtrl Button_Book;

	public GameObject Image_Book;

	public DxxText Text_Book;

	public ButtonCtrl Button_MeadowBattle;

	public GameObject Image_MeadowBattle;

	public DxxText Text_MeadowBattle;

	public Image image_mbLock;

	private int curTab;

	public ButtonCtrl Button_BackOther;

	public GameObject BottomMe;

	public GameObject BottomOther;

	public HeadItem headItem;

	public DxxText Text_Name;

	public GameObject Cloud;

	public DxxText Text_Searching;

	public RectTransform CloudLeft;

	public RectTransform CloudRight;

	private int timeID;

	private ulong timeEndToday;

	private int safeCount;

	protected override void OnInit()
	{
	}

	private void InitMeadowBattle()
	{
	}

	private void initMeadowBattleTimer()
	{
	}

	private void RefreshMeadowBattle()
	{
	}

	private void ClearMeadowBattle()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnClose()
	{
	}

	private void openPanelEgg()
	{
	}

	private void openPanelFarm()
	{
	}

	private void openPanelBook()
	{
	}

	private void openMeadowBattle()
	{
	}

	private void android_escape()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void cloudCome(int who)
	{
	}

	private void cloudGo(int who)
	{
	}

	private void findOtherEnd()
	{
	}

	private void onButtonBackOther()
	{
	}

	private void backToMe()
	{
	}

	private void onClickMeadowBattle()
	{
	}

	private void checkIfOpenMeadowBattle(bool autoReqeust)
	{
	}

	private void refreshText_MeadowBattle()
	{
	}
}
