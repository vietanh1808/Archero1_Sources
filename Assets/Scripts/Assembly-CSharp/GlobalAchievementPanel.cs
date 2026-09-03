using Activity;
using Activity.Christmas;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAchievementPanel : PanelBase
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtDesc;

	[SerializeField]
	private DxxText txtTimeCountdown;

	[SerializeField]
	private DxxText txtTitleTask;

	[SerializeField]
	private DxxText txtTitleReward;

	[SerializeField]
	private DxxText txtBtnGiftpack;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private GiftPackItem giftPackTemplate;

	[SerializeField]
	private ChristmasSignInTaskItem taskItemTemplate;

	[SerializeField]
	private GlobalRewardItem globalRewardTemplate;

	[SerializeField]
	private PropOneEquip propTemplate;

	[SerializeField]
	private RectTransform rtContentRoot;

	[SerializeField]
	private RectTransform rtSliderRewardContentRoot;

	[SerializeField]
	private ButtonCtrl btnGiftPack;

	[SerializeField]
	private GiftPackPanel giftPackPanel;

	[SerializeField]
	private RedNodeCtrl redNodeGiftAd;

	private LocalUnityObjctPool pool;

	private float t;

	private void Awake()
	{
	}

	public override void Open()
	{
	}

	private void RefreshTexts()
	{
	}

	private void RefreshGlobalRewards()
	{
	}

	private void RefreshCheckInTask()
	{
	}

	public override void Close()
	{
	}

	private void Update()
	{
	}
}
