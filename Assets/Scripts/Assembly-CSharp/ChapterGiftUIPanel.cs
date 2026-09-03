using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class ChapterGiftUIPanel : MediatorCtrlBase
{
	public class ChapterGiftTabBtns
	{
		private readonly ChapterGiftTabBtn[] btns;

		public ChapterGiftTabBtns(Transform tabBtnParent, Action<int> onClick)
		{
		}

		public void Refresh(List<int> validModes, Func<int, string> getName, Func<int, bool> isRed)
		{
		}

		public void SetFocusMode(int mode)
		{
		}

		public void Close()
		{
		}
	}

	public class ChapterGiftTabBtn
	{
		private readonly int index;

		private readonly Action<int> callBack;

		private bool isFocus;

		private readonly ButtonCtrl button;

		private readonly GameObject focusObj;

		private readonly RedNodeCtrl redObj;

		private readonly DxxText nameText;

		private readonly DxxText nameText1;

		public ChapterGiftTabBtn(int index, Transform go, Action<int> onClick)
		{
		}

		public void ClickDO()
		{
		}

		public void SetActive(bool active)
		{
		}

		public void SetFocus(bool focus)
		{
		}

		public void SetRed(bool show)
		{
		}

		public void SetName(string name)
		{
		}
	}

	public DxxText titleText;

	public DxxText modeText;

	public DxxText chapterRangeText;

	public DxxText pageText;

	public StarDiamondItem starDiamond;

	public DxxText emptyText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgBtn;

	public ButtonCtrl leftPageBtn;

	public ButtonCtrl rightPageBtn;

	public InfiniteListView listView;

	public Transform tabParent;

	public RectTransform scollViewRect;

	private ChapterGiftTabBtns tabBtns;

	private int curMode;

	private int curPage;

	private readonly List<int> validModes;

	private List<ChapterGiftItemData> curModeItems;

	private readonly List<int> curModePages;

	private bool listViewOpened;

	private int PageChapterRange => 0;

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

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void ClosePanel()
	{
	}

	private int ResolveOpenMode()
	{
		return 0;
	}

	private int ResolveDefaultPage(int mode)
	{
		return 0;
	}

	private void OnClickTab(int mode)
	{
	}

	private void OnClickLeftPage()
	{
	}

	private void OnClickRightPage()
	{
	}

	private void RefreshLanguageAndList(bool resetPage, bool keepScroll)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshTabs()
	{
	}

	private void RefreshList(bool keepScroll)
	{
	}

	private void RefreshValidModes()
	{
	}

	private List<ChapterGiftItemData> BuildList(int mode)
	{
		return null;
	}

	private void RebuildPages()
	{
	}

	private List<ViewCellData> BuildPageData(List<ChapterGiftItemData> source, int pageIndex)
	{
		return null;
	}

	private bool HasModeRed(int mode)
	{
		return false;
	}

	private void ClampCurrentPage()
	{
	}

	private void RefreshPageControls()
	{
	}

	public static int GetStageCount(Current_purchaseItem item)
	{
		return 0;
	}

	public static int GetModeFromItem(Current_purchaseItem item)
	{
		return 0;
	}

	private string GetChapterRangeText()
	{
		return null;
	}

	private string GetTabName(int mode)
	{
		return null;
	}

	private string GetModeName(int mode)
	{
		return null;
	}

	private void RefreshStarDiamondText()
	{
	}

	private static void SetText(DxxText target, string value)
	{
	}

	private static string GetLanguageOrDefault(string key, string fallback, params object[] args)
	{
		return null;
	}
}
