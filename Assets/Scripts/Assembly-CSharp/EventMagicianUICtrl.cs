using PureMVC.Interfaces;
using UnityEngine;

public class EventMagicianUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl _CloseBtn;

	[SerializeField]
	private ButtonCtrl _InfoBtn;

	[SerializeField]
	private ButtonCtrl[] _Cells;

	[SerializeField]
	private DxxImage[] _CellImgs;

	[SerializeField]
	private ParticleSystem[] _CellParticles;

	[SerializeField]
	private PropOneEquip[] _Rewards;

	[SerializeField]
	private ParticleSystem[] _RewardParticles;

	[SerializeField]
	private DxxImage _DoubleIcon;

	[SerializeField]
	private DxxImage _ChangeIcon;

	[SerializeField]
	private DxxText _DoubleTxt;

	[SerializeField]
	private DxxText _ChangeTxt;

	[SerializeField]
	private Sprite[] _DoubleIconSprites;

	[SerializeField]
	private Sprite[] _ChangeIconSprites;

	[SerializeField]
	private Sprite[] _ChangeProgressSprites;

	[SerializeField]
	private ProgressCtrl[] _DoubleProgresses;

	[SerializeField]
	private ProgressCtrl[] _ChangeProgresses;

	[SerializeField]
	private ParticleSystem[] _DoubleProgressParticles;

	[SerializeField]
	private ParticleSystem[] _ChangeProgressParticles;

	[SerializeField]
	private ParticleSystem _DoubleIconParticle;

	[SerializeField]
	private ParticleSystem[] _ChangeIconParticles;

	[SerializeField]
	private DxxText _TitleTxt;

	[SerializeField]
	private DxxText _CellTitleTxt;

	[SerializeField]
	private DxxText _RewardTitleTxt;

	[SerializeField]
	private DxxText _BuyTxt;

	[SerializeField]
	private ButtonCtrl _BuyBtn;

	[SerializeField]
	private DxxText _DiamondTxt;

	[SerializeField]
	private ButtonCtrl _DiscountBuyBtn;

	[SerializeField]
	private GoldTextCtrl _OriginPrice;

	[SerializeField]
	private GoldTextCtrl _DiscountPrice;

	[SerializeField]
	private GoldTextCtrl _Price;

	[SerializeField]
	private GameObject _InfoNode;

	[SerializeField]
	private DxxText _InfoTxt;

	[SerializeField]
	private ButtonCtrl[] _InfoCloseBtns;

	[SerializeField]
	private ButtonCtrl _InfoShadowBtn;

	[SerializeField]
	private GameObject[] _TabGOs;

	[SerializeField]
	private GameObject[] _TabButtons;

	[SerializeField]
	private DxxText[] _TabTxts;

	[SerializeField]
	private EventMagicianPreviewItemUICtrl _PreviewPrefab;

	[SerializeField]
	private GameObject _PreviewContent;

	[SerializeField]
	private DxxText[] _InfoTitleTxt;

	[SerializeField]
	private GameObject _CellNormalGO;

	[SerializeField]
	private GameObject _CellDestroyGO;

	[SerializeField]
	private Transform _BoomTargetPoint;

	[SerializeField]
	private ParticleSystem _BoomParticle;

	[SerializeField]
	private GameObject _CoverMask;

	[SerializeField]
	private GameObject _Guide;

	private int _DoubleCounter;

	private int _ChangeCounter;

	private int _FlipCounter;

	private int _CurTab;

	private int _RewardId;

	private int _RewardCount;

	private bool _IsBoomed;

	private bool _NeesResetChangeProgress;

	private long _LastCtrlTs;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void _InitUI()
	{
	}

	private void _RefreshReward()
	{
	}

	private void _RefreshRewardPrice()
	{
	}

	private void _RefreshDoubleProgress(bool bInit)
	{
	}

	private void _RefreshChangeProgress(bool bInit)
	{
	}

	private void OnEscape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Update()
	{
	}

	private void _OnCloseBtnClicked()
	{
	}

	private void _OnInfoBtnClicked()
	{
	}

	public void _OnCellBtnClicked(int cellIndex)
	{
	}

	private void _RefreshDiamond()
	{
	}

	public void _OnButtonTab(int tab)
	{
	}

	public void _OnBuyBtnClicked()
	{
	}

	private void _OnDiamondShopClose()
	{
	}

	private void _OnUserActive()
	{
	}

	private bool _IsDiscount()
	{
		return false;
	}

	private uint _GetOriginPrice()
	{
		return 0u;
	}

	private uint _GetDiscountPrice()
	{
		return 0u;
	}

	private uint _GetPrice()
	{
		return 0u;
	}

	private WindowID _GetWindowId()
	{
		return WindowID.WindowID_Invaild;
	}

	private void _Report(bool isBuy)
	{
	}

	private static long GetTimeStamp()
	{
		return 0L;
	}
}
