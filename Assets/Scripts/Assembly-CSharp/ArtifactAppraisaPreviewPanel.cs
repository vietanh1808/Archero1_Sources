using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactAppraisaPreviewPanel : MonoBehaviour
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

	public class PreviewItem
	{
		public Text titleTex;

		public Image boxImg;

		public RectTransform propParent;

		public PropOneEquip propOne;

		public GameObject gameObject;

		private List<PropOneEquip> items;

		public PreviewItem(GameObject obj, PropOneEquip copyOne)
		{
		}

		public void Init(ArtifactAppraisaManager.ArtifactAppraisaBoxConfig config)
		{
		}
	}

	public Transform tabBtnParent;

	public ButtonCtrl CloseBtn;

	public DxxText titleText;

	public DxxText contentText;

	public GameObject descObj;

	public GameObject previewObj;

	public RectTransform itemParent;

	public PropOneEquip propOne;

	public GameObject previewRewards;

	private List<PreviewItem> items;

	private TabBtns tabBtns;

	public void Init()
	{
	}

	public void Open(int tabIndex)
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
