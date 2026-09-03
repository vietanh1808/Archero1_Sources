using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ImprintUICtrl : MediatorCtrlBase
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

	public interface IPanelBase
	{
		void Init();

		void Open();

		void Close();

		void OnHandleNotification(INotification notification);

		void OnLanguageChange();
	}

	public Transform m_PanelParent;

	public Transform m_tabParent;

	public ButtonCtrl m_closeBtn;

	public RectTransform topTrans;

	public RectTransform panelTrans;

	private TabBtns m_tabBtns;

	public BeliefLevelPart m_BeliefLevelPart;

	private Dictionary<int, IPanelBase> panels;

	private string[] PanelPath;

	private IPanelBase CurPanel;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnClickClose()
	{
	}

	public void Refresh()
	{
	}

	protected override void OnClose()
	{
	}

	public void Esc()
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

	private bool IsTabRed(int index)
	{
		return false;
	}
}
