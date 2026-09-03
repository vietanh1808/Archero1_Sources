using System.Collections.Generic;
using Activity.Wish;
using UnityEngine;
using UnityEngine.UI;

public class SelectTab : MonoBehaviour
{
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

	private LocalUnityObjctPool pool;

	[SerializeField]
	private PropOneEquip previewItem;

	[SerializeField]
	private PropOneEquip template;

	[SerializeField]
	private WishPanel panel;

	[SerializeField]
	private WishSelection panelSelection;

	private List<PropOneEquip> equipOnes;

	private int curSelectedId;

	private bool isOpen;

	private int[][] Optional;

	private List<GameObject> listTemp;

	private int[] currentWish => null;

	private PurchaseWishingReward currentWishReward => null;

	private void Awake()
	{
	}

	public void Open()
	{
	}

	private void ShowSelection()
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

	public void Close()
	{
	}

	private void RefreshText()
	{
	}

	public void SetWishPanel(WishPanel wishPanel)
	{
	}
}
