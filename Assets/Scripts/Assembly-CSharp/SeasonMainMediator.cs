using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SeasonMainMediator : WindowMediator
{
	public class SeasonPageData : MainModuleMediator.PageData
	{
		public SeasonPageData(int page, Transform self, UIBase ctrl)
			: base(0, null, null)
		{
		}

		public override void In()
		{
		}

		public override void Out()
		{
		}
	}

	private SeasonMainDownCtrl mDownCtrl;

	private ScrollRectBase mScrollRect;

	private float scrollpercentx;

	private RectTransform mButtonFront;

	private GridLayoutGroup grid;

	private static MainModuleMediator.PageData[] mPageDatas;

	private static int currentPage;

	public override List<string> OnListNotificationInterests => null;

	public SeasonMainMediator()
		: base(null)
	{
	}

	protected override void OnRegisterOnce()
	{
	}

	protected override void OnRegisterEvery()
	{
	}

	private void setCurrentPageIndex(int index)
	{
	}

	private void ResetBottomBtns()
	{
	}

	private void InitPages()
	{
	}

	private void TouchPage(int nextpage)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnRemoveAfter()
	{
	}

	private void CloseUI()
	{
	}

	protected override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	private void RegisterScrollviewEvent()
	{
	}

	private void play_button_animation(int prevpage, int currentPage)
	{
	}

	private void OnValueChanged(Vector2 value)
	{
	}

	private void EndDragItem(int page)
	{
	}
}
