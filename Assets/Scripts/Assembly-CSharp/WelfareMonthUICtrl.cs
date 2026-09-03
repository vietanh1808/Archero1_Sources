using System;
using UnityEngine;
using UnityEngine.UI;

public class WelfareMonthUICtrl : MediatorCtrlBase
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

	public WelfareMonthTab[] tabs;

	public WelfareMonthTaskPart welfareMonthTaskPart;

	public WelfareMonthCheckInPanel welfareMonthCheckInPanel;

	public ButtonCtrl closeBtn;

	public ButtonCtrl checkInBtn;

	public DxxText titleTex;

	public DxxText checkInTex;

	public RedNodeCtrl checkInRed;

	public Transform tabObj;

	public GameObject tipsGameObject;

	public DxxText Text_Tip;

	public ButtonCtrl tipsCloseBtn;

	public ButtonCtrl tipsBtn;

	public GameObject[] kvs;

	private TabBtns tabBtn;

	private int CurType;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void RefreshAfterReviceGift()
	{
	}

	public void RefreshTab(int tab)
	{
	}

	public void RefreshAfterRevice(uint type, uint taskid)
	{
	}

	public void Refresh()
	{
	}

	public void ClickClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void ClickBottomTab(int index)
	{
	}

	public string GetTabName(int index)
	{
		return null;
	}

	public bool RefreshRed(int index)
	{
		return false;
	}
}
