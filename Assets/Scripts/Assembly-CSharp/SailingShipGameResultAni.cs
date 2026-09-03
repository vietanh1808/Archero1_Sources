using DG.Tweening;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SailingShipGameResultAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private RectTransform detailBg;

	[SerializeField]
	private RectTransform resultBg;

	[SerializeField]
	private RectTransform title;

	[SerializeField]
	private RectTransform battleInfo;

	[SerializeField]
	private RectTransform reward;

	[SerializeField]
	private RectTransform rewardParent;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private GridLayoutGroup gridLayoutGroup;

	[SerializeField]
	private ButtonCtrl jumpAniBtn;

	[SerializeField]
	private DxxText jumpAniBtnName;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private DxxText closeBtnName;

	[SerializeField]
	private RectTransform leftAvatar;

	[SerializeField]
	private RectTransform rightAvatar;

	[SerializeField]
	private DxxText vsText;

	[SerializeField]
	private RectTransform selfWinnerObj;

	[SerializeField]
	private RectTransform enemyWinnerObj;

	[SerializeField]
	private GameObject selfWinnerLightObj;

	[SerializeField]
	private GameObject enemyWinnerLightObj;

	[SerializeField]
	private RectTransform selfTextName;

	[SerializeField]
	private RectTransform enemyTextName;

	[SerializeField]
	private RectTransform selfTextBattlePower;

	[SerializeField]
	private RectTransform enemyTextBattlePower;

	[SerializeField]
	private RectTransform scoreReward;

	[SerializeField]
	private RectTransform propReward;

	[SerializeField]
	private RectTransform dmgText;

	private const float MoveDuration = 0.2f;

	private const float ShakeDuration = 0.1f;

	private const float ReturnDuration = 0.2f;

	private const float ShakeStrength = 10f;

	private const float ShowVsFadeTime = 0.3f;

	private const float AvatarMoveDis = 100f;

	private const float RewardScrollMoveTime = 1f;

	private const float TextFadeTime = 1.5f;

	private const float DetailOriginPos = -100f;

	private const float DetailFinalPosWithProp = 100f;

	private const float DetailBgMoveTime = 0.3f;

	private const float ResultBgPlayTime = 0.6f;

	private const float OriginMinScale = 0.3f;

	private const float OriginMinScalePlayTime = 0.3f;

	private const float OriginMaxScale = 1.5f;

	private const float OriginMaxScalePlayTime = 0.3f;

	private const float OriginPropMaxScale = 1.5f;

	private const float PropScaleAniTime = 0.12f;

	private const float ShowMaxRowProp = 3f;

	private Vector3 SquashedScale;

	private const float SquashDuration = 0.05f;

	private const float RecoverDuration = 0.08f;

	private float resultBgOriginY;

	private SequencePool pool;

	private Sequence curAni;

	private bool haveReward;

	private Vector2 leftOriginStart;

	private Vector2 rightOriginStart;

	private SailingShipManager SailingShipManager => null;

	private SailingShipGameData SailingShipGameData => null;

	private SailingShipBattleResultData SailingShipBattleResultData => null;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void PlayAni()
	{
	}

	public void JumpAni()
	{
	}

	public void StopAni()
	{
	}

	private void SetStatus(bool isInit)
	{
	}
}
