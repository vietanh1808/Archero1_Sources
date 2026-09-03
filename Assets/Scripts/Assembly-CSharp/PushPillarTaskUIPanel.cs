using System;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PushPillarTaskUIPanel : MediatorCtrlBase
{
	public class TabBtns
	{
		public class TabBtn
		{
			private int m_index;

			public ButtonCtrl button;

			public GameObject focusObj;

			public RedNodeCtrl redObj;

			public Text nameText;

			private bool m_IsFocus;

			private Action<int> callBack;

			public TabBtn(int index, Transform go, Action<int> onClick)
			{
			}

			public void ClickDO()
			{
			}

			public void SetFocus(bool isFocus)
			{
			}

			public void SetRed(bool isShow)
			{
			}

			public void SetName(string name)
			{
			}
		}

		private TabBtn[] m_btns;

		public TabBtns(Transform tabBtnParent, Action<int> onClick)
		{
		}

		public void RefreshRed(Func<int, bool> isShowRed)
		{
		}

		public void ClickTab(int index)
		{
		}

		public void Close()
		{
		}

		public void OnLanguageChange(Func<int, string> getName)
		{
		}
	}

	public DxxText titleText;

	public DxxText timeText;

	public ButtonCtrl closeBtn;

	public InfiniteListView listView;

	public Transform tabParent;

	public StarDiamondItem starDiamond;

	public RectTransform scollViewRect;

	[SerializeField]
	private OfficialStoreBannerCtrl _goOfficialStoreBanner;

	private TabBtns tabBtns;

	private int curTab;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnReqGiftCallBack(bool obj)
	{
	}

	private void OnReqTaskCallBack(bool obj)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshTitleByTab()
	{
	}

	public void ClosePanel()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void ClickTab(int index)
	{
	}

	private void RefreshUI()
	{
	}

	private string SetTabName(int index)
	{
		return null;
	}

	public void RefreshRed()
	{
	}

	private bool TabRed(int index)
	{
		return false;
	}

	private void freshTime()
	{
	}
}
