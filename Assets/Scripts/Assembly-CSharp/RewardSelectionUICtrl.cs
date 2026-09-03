using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class RewardSelectionUICtrl : MediatorCtrlBase
{
	public class TransferData
	{
		public string entranceName;

		public Action callback;

		public ActivityCustomRewardData data;

		public string sourceNameSingle;

		public int index;

		public string titleKey;

		public string confirmKey;
	}

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnShadow;

	[SerializeField]
	private ButtonCtrl btnConfirm;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtTitleSelection;

	[SerializeField]
	private DxxText txtItemDesc;

	[SerializeField]
	private DxxText txtBtnConfirm;

	[SerializeField]
	private ScrollRectBase scrollRect;

	[SerializeField]
	private RectTransform rtContentRoot;

	[SerializeField]
	private GridLayoutGroup gridLayoutGroup;

	[SerializeField]
	private GameObject goMask;

	private LocalUnityObjctPool pool;

	[FormerlySerializedAs("selections")]
	[SerializeField]
	private PropOneEquip[] selectionPreviewItems;

	[SerializeField]
	private PropOneEquip template;

	private List<PropOneEquip> equipOnes;

	private RewardSelectionData[] selectionData;

	private int curSelectedId;

	private bool isOpen;

	private TransferData cachedData;

	private int[][] Optional;

	private int shownIndex;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	private void ShowSelection(int index, bool instant = false)
	{
	}

	private void RefreshButton()
	{
	}

	private void RefreshSelectionPreviews()
	{
	}

	private void OnSelectItem(PropOneBase one)
	{
	}

	private void OnBtnConfirm()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
