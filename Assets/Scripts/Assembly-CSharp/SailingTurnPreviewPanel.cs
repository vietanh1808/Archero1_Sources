using System;
using UnityEngine;
using UnityEngine.UI;

public class SailingTurnPreviewPanel : MonoBehaviour
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

	public Transform tabBtnParent;

	public ButtonCtrl CloseBtn;

	public DxxText titleText;

	public DxxText contentText;

	public SailingTurnPreviewRewardPart previewRewardPart;

	private TabBtns tabBtns;

	private int CurWheelIndex;

	public void Init()
	{
	}

	public void Open(int wheelIndex)
	{
	}

	private void ClickTab(int index)
	{
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}

	private string SetTabName(int index)
	{
		return null;
	}
}
