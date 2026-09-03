using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class TradingHouseUIPanel : MediatorCtrlBase
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

			public bool IsFocus()
			{
				return false;
			}

			public int GetIndex()
			{
				return 0;
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

		public int GetFocusIndex()
		{
			return 0;
		}
	}

	public interface IPanelBase
	{
		void Init();

		void Open();

		void Close();

		void OnHandleNotification(INotification notification);

		void OnLanguageChange();
	}

	public Transform panelParent;

	public Transform tabsParent;

	public ButtonCtrl closeBtn;

	public ButtonCtrl rankBtn;

	public ButtonCtrl AchBtn;

	public ButtonCtrl InfoBtn;

	public ButtonCtrl quickBuyBtn;

	public TradingHouseLogPanel logPanel;

	public TradingHouseSellPanel sellPanel;

	public DxxText titleText;

	public DxxText matNumText;

	public DxxText shopCoinNumText;

	public DxxText rankBtnText;

	public DxxText achBtnText;

	public Image matIconImg;

	public Image shopCoinIconImg;

	public RectTransform currencyTrans;

	private TabBtns m_TabBtns;

	private Dictionary<int, IPanelBase> panels;

	private string[] PanelPath;

	private IPanelBase CurPanel;

	private TimeLineContainer timeLine;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public void ClickClose()
	{
	}

	public void ClickRank()
	{
	}

	public void ClickAch()
	{
	}

	public void OnClickLog()
	{
	}

	public void ClickInfo()
	{
	}

	private void ClickQuickBuy()
	{
	}

	public void OnClickSell(TradingHouseCommodity commodity, TradingHouseBehavior behavior)
	{
	}

	private void ClickTab(int index)
	{
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

	private void RefreshMat()
	{
	}

	private bool IsTabRed(int index)
	{
		return false;
	}

	public void StartNextReq()
	{
	}
}
