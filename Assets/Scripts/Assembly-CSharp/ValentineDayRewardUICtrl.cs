using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ValentineDayRewardUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl _btnClose;

	[SerializeField]
	private ButtonCtrl _btnInfo;

	[SerializeField]
	private ButtonCtrl _btnBox;

	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private DxxText _textContent;

	[SerializeField]
	private DxxText _textLeftBoxChoice;

	[SerializeField]
	private DxxText _textBoxRedRose;

	[SerializeField]
	private DxxText _textBoxBlueRose;

	[SerializeField]
	private DxxText _textRedRose;

	[SerializeField]
	private DxxText _textBlueRose;

	[SerializeField]
	private ValentineDayRewardCtrl[] _valentineDayRewards;

	[SerializeField]
	private Image _imgLeftProcess;

	[SerializeField]
	private Image _imgRightProcess;

	[SerializeField]
	private Image _imgRedNote;

	[SerializeField]
	private GameObject _goInfo;

	[SerializeField]
	private DxxText _textInfoTitle;

	[SerializeField]
	private DxxText _textInfoContent;

	[SerializeField]
	private ButtonCtrl _btnInfoClose;

	[Header("宝箱详情Tips")]
	[SerializeField]
	private GameObject mGoTips;

	[SerializeField]
	private RectTransform mRtContent;

	[SerializeField]
	private RectTransform mRtRewardTipsBg;

	[SerializeField]
	private RectTransform mRtArrow;

	private ValentineDayRewardManager _manager;

	private Daily_LoverReward_111 _curBoxData;

	private int _curBoxIndex;

	private LocalUnityObjctPool mPool;

	private RectTransform mRtTips;

	private Canvas mCanvas;

	private RectTransform mRtCanvas;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateUI()
	{
	}

	private void ShowRewardContent(Daily_LoverReward_111 data, Transform transform)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void OnClickBox()
	{
	}

	private int GetRepeatBoxMaxCount(Daily_LoverReward_111[] datas)
	{
		return 0;
	}

	private void RefreshRewardTipsPosition(Transform target)
	{
	}
}
