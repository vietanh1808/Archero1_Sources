using TableTool;
using UnityEngine;
using UnityEngine.UI;

namespace Activity.Christmas
{
	public class WishPanel : PanelBase
	{
		[SerializeField]
		private ButtonCtrl btnRewardPreview;

		[SerializeField]
		private ButtonCtrl btnRoundPreview;

		[SerializeField]
		private ButtonCtrl btnWish;

		[SerializeField]
		private ButtonCtrl btnSelectWishReward;

		[SerializeField]
		private ButtonCtrl btnInfo;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtDesc;

		[SerializeField]
		private DxxText txtPanelTitle;

		[SerializeField]
		private DxxText txtTimeCountdown;

		[SerializeField]
		private DxxText txtBtnWish;

		[SerializeField]
		private DxxText txtBtnPreview;

		[SerializeField]
		private DxxText txtCoinCount;

		[SerializeField]
		private DxxText txtWishValue;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private PropOneEquip prop;

		[SerializeField]
		private GameObject goAdd;

		[SerializeField]
		private WishRewardPreview wishRewardPanel;

		[SerializeField]
		private WishProgressReward[] progressRewardItems;

		[SerializeField]
		private WishRoundPreview wishRoundPanel;

		[SerializeField]
		private RedNodeCtrl redNodeBtnWish;

		[SerializeField]
		private RedNodeCtrl redNodeWishItem;

		private float curProgress => 0f;

		private ChristmasWishingReward currentWish => null;

		private int curCoinCount => 0;

		private int wishCoinCost => 0;

		private string selectionSource => null;

		private void Awake()
		{
		}

		private void OnSelectWishRewardClick()
		{
		}

		private void OnWishSelect()
		{
		}

		private void OnWishSelect(Drop_DropModel.DropData selection)
		{
		}

		private void OnWishClick()
		{
		}

		public override void Open()
		{
		}

		public override void Refresh()
		{
		}
	}
}
