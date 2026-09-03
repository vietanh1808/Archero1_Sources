using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Activity.Wish
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
		private ButtonCtrl btnGiftPack;

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
		private DxxText txtWishDesc;

		[SerializeField]
		private DxxText txtBtnPreview;

		[SerializeField]
		private DxxText txtBtnGift;

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
		private WishRoundPreview purchaseWishRoundPanel;

		[SerializeField]
		private RedNodeCtrl redNodeBtnWish;

		[SerializeField]
		private RedNodeCtrl redNodeWishItem;

		[SerializeField]
		private RedNodeCtrl redNodeGift;

		[SerializeField]
		private GiftPackPanel giftPackPanel;

		[SerializeField]
		private WishSelection selectionPanel;

		[SerializeField]
		private Sprite[] sprites;

		[SerializeField]
		private DxxImage imgNumPop;

		[SerializeField]
		private DxxImage imgRefresh;

		[SerializeField]
		private RectTransform rtLight;

		[SerializeField]
		private RectTransform rtRef;

		[SerializeField]
		private float fadeDuration;

		[SerializeField]
		private float popDuration;

		[SerializeField]
		private float moveDuration;

		[SerializeField]
		private float scale;

		[SerializeField]
		private float lightRight;

		[SerializeField]
		private float lightMoveDuration;

		[SerializeField]
		private Vector2 moveOffset;

		private float curProgress => 0f;

		private PurchaseWishingReward currentWish => null;

		private int curCoinCount => 0;

		private int wishCoinCost => 0;

		private void Awake()
		{
		}

		private void OnSelectWishRewardClick()
		{
		}

		public void OnWishSelect(int index)
		{
		}

		private void OnWishClick()
		{
		}

		private void OnWishValueChange(int delta)
		{
		}

		public override void Init(IActivityUI ctrl)
		{
		}

		public override void Open()
		{
		}

		public override void Refresh()
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}
	}
}
