using System.Collections.Generic;
using Activity7thAnniversary;
using DG.Tweening;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class BattleDaily130UICtrl : BattleLevelUICtrl
{
	private const string UpdateName = "BattleDaily130UICtrl.Update";

	private const float HitScaleDuration = 0.12f;

	private const float HitScaleValue = 1.12f;

	private const int DefaultDamageRatio = 1;

	private const float HpBarFullWidth = 488f;

	private static readonly Color[] HpBarColors;

	[SerializeField]
	private GameObject _goHp;

	[SerializeField]
	private DxxText _textRatio;

	[SerializeField]
	private DxxText _textCD;

	[SerializeField]
	private DxxText _textHitTotal;

	[SerializeField]
	private Image _imgFg;

	[SerializeField]
	private Image _imgFFg;

	[SerializeField]
	private RectTransform _rtBuffParent;

	private Daily_StageInfo_130 _stageInfo;

	private List<Daily_StageBoxReward_130> _rewardInfos;

	private float _battleRemainingTime;

	private long _lastAccumulatedDamage;

	private int _lastSegmentCount;

	private bool _isBossRoomActive;

	private bool _bossRoomStateInitialized;

	private bool _battleEndNotified;

	private Tween _hitTextTween;

	private Tween _ratioTween;

	private Activity7thAnniversaryMgr _mgr;

	private int _segmentCount;

	private GameObject _curEffect;

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

	private void InitDaily130Config()
	{
	}

	private void RefreshBossRoomState()
	{
	}

	private void StartBossRoomBattleTimer()
	{
	}

	private int GetBossWaveCount()
	{
		return 0;
	}

	private int GetBossWaveInterval()
	{
		return 0;
	}

	private void RefreshAll()
	{
	}

	private void RefreshHitProgress(long accumulatedDamage)
	{
	}

	private void RefreshBossHp(long accumulatedDamage)
	{
	}

	private void RefreshCountdown()
	{
	}

	private void OnBattleUpdate(float deltaTime)
	{
	}

	private void UpdateBattleRemainingTime(float deltaTime)
	{
	}

	private void TryNotifyBattleEndByTime()
	{
	}

	private static bool IsBattleTimeEndedForTest(float battleRemainingTime)
	{
		return false;
	}

	private int GetCurrentSegmentCount(long accumulatedDamage)
	{
		return 0;
	}

	private List<Daily_StageBoxReward_130> GetSortedRewardInfos()
	{
		return null;
	}

	private long GetCurrentSegmentDamageLimit(long accumulatedDamage)
	{
		return 0L;
	}

	private long GetCurrentSegmentValue(long accumulatedDamage)
	{
		return 0L;
	}

	private void PlayPunchScale(Transform target, ref Tween tween)
	{
	}

	private void KillTweens()
	{
	}

	protected override void SetPetSkillBtnGroupState()
	{
	}
}
