using System;
using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class MainModuleMediator : WindowMediator
{
	public class PageData
	{
		public int Page;

		public Transform self;

		public UIBase PageCtrl;

		public RectTransform buttonrect;

		public Animation animation;

		public ButtonCtrl buttonctrl;

		public Image Image_ButtonBG;

		public RedNodeCtrl redctrl;

		private bool bInit;

		public PageData(int page, Transform self, UIBase ctrl)
		{
		}

		public void init()
		{
		}

		public void AddButtonClick(Action click)
		{
		}

		public virtual void In()
		{
		}

		public virtual void Out()
		{
		}

		public void Play(string name)
		{
		}

		public void DeInit()
		{
		}

		public void PreloadRes()
		{
		}
	}

	private static RectTransform mScrollTransform;

	private static ScrollRectBase mScrollRect;

	private static GridLayoutGroup grid;

	private static RectTransform mButtonFront;

	private static PageData[] mPageDatas;

	private static ButtonCtrl Button_Start;

	private static Transform MiddleTransform;

	private static Image Image_Sound;

	private static BoxRedAniCtrl mBoxCtrl;

	private static ButtonCtrl Button_Setting;

	private static ButtonCtrl Button_Set;

	private static GameObject Obj_Setting;

	private static ButtonCtrl Button_Rate;

	protected static MainDownCtrl mDownCtrl;

	private bool isGuiderRunning;

	private bool isGuiderRunningBox;

	private bool isGuideRunning_HeroAssist;

	private bool isGuiderRunning_Artifact;

	private bool isGuideRunning_EquipCast;

	private bool isGuiderRunning_Badge;

	private ActionBasic action;

	private bool bSettingShow;

	private static int currentPage;

	private float scrollpercentx;

	private bool bOnlyMain;

	private List<Action> OnOnlyMainActionList;

	private SequencePool mSeqPool;

	private GameObject newObj;

	private Dictionary<int, Func<bool>> mActivityOpen;

	private float touchtime;

	public override List<string> OnListNotificationInterests => null;

	public static int CurrentPage => 0;

	public MainModuleMediator()
		: base(null)
	{
	}

	protected override void OnRegisterOnce()
	{
	}

	private void InitPages()
	{
	}

	private void OnValueChanged(Vector2 value)
	{
	}

	private void OnOnlyMain(bool onlymain)
	{
	}

	private void EndDragItem(int page)
	{
	}

	private void TouchPage(int nextpage)
	{
	}

	private void play_button_animation(int prevpage, int currentPage)
	{
	}

	protected override void OnRegisterEvery()
	{
	}

	private new void PreloadRes()
	{
	}

	public void InitGuide()
	{
	}

	private void update_page()
	{
	}

	private void Guide()
	{
	}

	private void GoldUpdate(long allgold, long change)
	{
	}

	private void PlayGetGold(object o)
	{
	}

	private void PlayGetDiamond(object o)
	{
	}

	protected override void OnRemoveAfter()
	{
	}

	private void UpdateShopRedCount()
	{
	}

	private void UpdateEquipRedCount()
	{
	}

	private void UpdateCardRedCount()
	{
	}

	private void UpdateSettingRedCount()
	{
	}

	public void UpdateDailyPalyNew()
	{
	}

	private bool GotoPage(int index)
	{
		return false;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override object GetEvent(string eventName)
	{
		return null;
	}

	private void MiddleShow(bool show)
	{
	}

	private void OnButtonClick()
	{
	}

	private void UpdateGold()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnLanguageChange()
	{
	}
}
