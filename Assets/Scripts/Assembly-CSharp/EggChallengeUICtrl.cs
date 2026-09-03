using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class EggChallengeUICtrl : MediatorCtrlBase
{
	public class FindData
	{
		public int mode;

		public int chapter;

		public int recommond;
	}

	public class OpenData
	{
		public bool find;

		public int monsterid;

		public int from;
	}

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

	public EggActivityUICtrl eggUICtrl;

	public GameObject bg;

	public GameObject monsterRoot;

	public ButtonCtrl buttonClose;

	public ButtonCtrl buttonBack;

	public DxxText title;

	public DxxText subTitle;

	public GameObject content;

	public GameObject findOne;

	private OpenData openData;

	private int preTab;

	public InfiniteListView InfiniteList;

	public Transform tabsParent;

	private TabBtns m_TabBtns;

	private List<ViewCellData> showList;

	private List<int> models;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void ClickTab(int tabIndex)
	{
	}

	protected override void OnClose()
	{
	}

	public void android_escape()
	{
	}

	public override object OnGetEvent(string eventName)
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

	public void init(bool find, int monsterid)
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonBack()
	{
	}

	private void onButtonGo()
	{
	}
}
