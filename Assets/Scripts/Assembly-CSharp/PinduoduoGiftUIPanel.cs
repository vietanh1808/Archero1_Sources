using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PinduoduoGiftUIPanel : MediatorCtrlBase
{
	public class TabBtns
	{
		public class TabBtn
		{
			public GameObject gameObject;

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

			public bool IsFocus()
			{
				return false;
			}

			public int GetIndex()
			{
				return 0;
			}
		}

		private GameObject copyOne;

		private List<TabBtn> m_btns;

		private int curCount;

		private Action<int> OnClick;

		private Transform m_TabBtnParent;

		public TabBtns(Transform tabBtnParent, Action<int> onClick)
		{
		}

		public void Refresh(int count)
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

		public int GetFocusIndex()
		{
			return 0;
		}
	}

	public interface IPanelBase
	{
		void Init();

		void Open(object data);

		void Close();

		void OnHandleNotification(INotification notification);

		void OnLanguageChange();
	}

	public Transform panelParent;

	public Transform tabsParent;

	public DxxText titleText;

	public DxxText timeText;

	public ButtonCtrl infoBtn;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgbtn;

	public PinduoduoMatBuyPanel matBuyPanel;

	private TabBtns m_TabBtns;

	private Dictionary<int, IPanelBase> panels;

	private string[] PanelPath;

	private IPanelBase CurPanel;

	private List<PinduoduoGiftGroupData> giftGroupDatas;

	private int curIndex;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void Refresh(bool obj)
	{
	}

	public void ClosePanel()
	{
	}

	public void ClickInfo()
	{
	}

	private void ClickTab(int tabIndex)
	{
	}

	private void OnClickBuy(int offset, bool isClick)
	{
	}

	private int GetPanelIndex(int tabIndex)
	{
		return 0;
	}

	private object GetPanelData(int tabIndex)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private string GetNameTab(int index)
	{
		return null;
	}

	private void RefreshTabRed()
	{
	}

	private bool IsTabRed(int index)
	{
		return false;
	}

	private void freshTime()
	{
	}
}
