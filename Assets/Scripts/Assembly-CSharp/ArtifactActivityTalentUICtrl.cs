using System.Collections.Generic;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;

public class ArtifactActivityTalentUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl _btnUpgrade;

	[SerializeField]
	private ButtonCtrl _btnClose;

	[SerializeField]
	private ButtonCtrl _btnTips;

	[SerializeField]
	private ButtonCtrl _btnBg;

	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private DxxText _textTotalTalent;

	[SerializeField]
	private DxxText _textUpgradeBtnText;

	[SerializeField]
	private DxxText _textCost;

	[SerializeField]
	private GameObject _goCostParent;

	[SerializeField]
	private DxxText _textTotal;

	[SerializeField]
	private ArtifactActivityTalentInfoCtrl _infoCtrl;

	[SerializeField]
	private ArtifactActivityTalentInfoCtrl _infoCtrl2;

	[SerializeField]
	private ArtifactActivityTalentOne _copyOne;

	[SerializeField]
	private RectTransform _randomobj;

	[SerializeField]
	private DxxImage _mask;

	[SerializeField]
	private RectTransform _middle;

	[SerializeField]
	private RectTransform _rtLine1;

	[SerializeField]
	private RectTransform _rtLine2;

	[SerializeField]
	private RectTransform _rtLine3;

	[SerializeField]
	private ArtifactActivityTipsUICtrl _artifactActivityTips;

	private LocalUnityObjctPool _pool;

	private ArtifactActivityManager _manager;

	private List<ArtifactActivityTalentOne> _listOnes;

	private ArtifactActivityTalentOne _targetOne;

	private Sequence s;

	private Sequence s_random;

	private int lastrandomindex;

	private int currentcount;

	private int currentrandomid;

	private const int SpeedDownCount = 20;

	private AnimationCurve curve;

	protected override void OnInit()
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

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void UpdateUI()
	{
	}

	private void OnClickUpgrade()
	{
	}

	private void OnClickCard(ArtifactActivityTalentOne one)
	{
	}

	public void OnClickBg()
	{
	}

	private void ResetRandom()
	{
	}

	private void StartPlayRandom()
	{
	}

	private void PlayRandom()
	{
	}

	private void SetRandomPosition()
	{
	}
}
