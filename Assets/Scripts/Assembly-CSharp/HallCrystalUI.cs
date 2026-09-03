using System.Collections.Generic;
using Spine;
using Spine.Unity;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class HallCrystalUI : MonoBehaviour
{
	public SkeletonGraphic[] EggAni;

	public GameObject[] parents;

	public GameObject CryAnimation;

	public Animator CryAniLoader;

	public PropOneEquip propItem;

	public ButtonCtrl Button_Info;

	public DxxText Text_Count;

	public ButtonCtrl Button_Box;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public DxxText Text_ExchNum;

	public ButtonCtrl Button_Preview;

	public DxxText Text_Preview;

	public ButtonCtrl Button_Reset;

	public DxxText Text_Box;

	public GameObject RedPoint_ExchTicket;

	public RectTransform rt_contet;

	public PropOneEquip rewardItem;

	public HorizontalLayoutGroup hlg;

	public ScrollRect sRect;

	public Text Text_SkipAni;

	public Toggle Toggle_Skip;

	private bool isGuideRunning;

	private List<Drop_DropModel.DropData> rewards;

	private List<bool> isResetAni;

	private int getCount;

	private int crtIndex;

	private bool isLast;

	private bool isClick;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_InitEggAni;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnAniCompleted;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_RefreshRewards;

	private static DelegateBridge __Hotfix0_initLast;

	private static DelegateBridge __Hotfix0_initCrystal;

	private static DelegateBridge __Hotfix0_ShowMonster;

	private static DelegateBridge __Hotfix0_onButtonInfo;

	private static DelegateBridge __Hotfix0_onButtonBox;

	private static DelegateBridge __Hotfix0_onButtonExch;

	private static DelegateBridge __Hotfix0_onButtonPreview;

	private static DelegateBridge __Hotfix0_onButtonGet;

	private static DelegateBridge __Hotfix0_onButtonClickCrystal;

	private static DelegateBridge __Hotfix0_onLanguageChanged;

	private static DelegateBridge __Hotfix0_onNote;

	private static DelegateBridge __Hotfix0_OnButtonReset;

	private static DelegateBridge __Hotfix0_freshRedPoint;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Awake()
	{
	}

	private void InitEggAni()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnAniCompleted(TrackEntry data)
	{
	}

	private void init()
	{
	}

	private void RefreshRewards()
	{
	}

	private void initLast()
	{
	}

	private void initCrystal(int totalId)
	{
	}

	public void ShowMonster(int monsterindex, int index)
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonBox()
	{
	}

	private void onButtonExch()
	{
	}

	private void onButtonPreview()
	{
	}

	private void onButtonGet()
	{
	}

	public void onButtonClickCrystal(int index)
	{
	}

	public void onLanguageChanged()
	{
	}

	public void onNote(string key, object value)
	{
	}

	public void OnButtonReset()
	{
	}

	private void freshRedPoint()
	{
	}
}
