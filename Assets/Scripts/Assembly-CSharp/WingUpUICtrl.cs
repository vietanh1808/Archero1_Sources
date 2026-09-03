using System;
using UnityEngine;
using UnityEngine.UI;

public class WingUpUICtrl : MediatorCtrlBase
{
	public class TabBtns
	{
		public class TabBtn
		{
			private int m_index;

			public Button button;

			public GameObject focusObj;

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

			public void SetName(string name)
			{
			}
		}

		private TabBtn[] m_btns;

		public TabBtns(Transform tabBtnParent, Action<int> onClick)
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

	public WingUpModelShow wingUpModelShow;

	public Transform tabParent;

	public RectTransform window;

	public WingUpValueShowPart wingUpValueShowPart;

	public WingUpAttributePart wingUpAttributePart;

	public WingUpMatPart wingUpMatPart;

	public WingUpButtonsPart wingUpButtonsPart;

	public DxxText titleText;

	public ButtonCtrl closeBtn;

	private TabBtns tabBtns;

	private LocalSave.WingOne wing;

	protected override void OnInit()
	{
	}

	public void ClickCLose()
	{
	}

	public void OnClickTab(int index)
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

	public string GetTabName(int index)
	{
		return null;
	}
}
