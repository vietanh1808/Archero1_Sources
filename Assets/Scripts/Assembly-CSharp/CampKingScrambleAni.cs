using System.Collections.Generic;
using DG.Tweening;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CampKingScrambleAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private Transform startPos;

	[SerializeField]
	private Transform endPos;

	[SerializeField]
	private RectTransform camp1AttackItem;

	[SerializeField]
	private RectTransform camp2AttackItem;

	[SerializeField]
	private RectTransform camp3AttackItem;

	[SerializeField]
	private RectTransform camp4AttackItem;

	[SerializeField]
	private Image circleCamp1;

	[SerializeField]
	private Image circleCamp2;

	[SerializeField]
	private Image circleCamp3;

	[SerializeField]
	private Image circleCamp4;

	[SerializeField]
	private DxxText arrowCount;

	[SerializeField]
	private CampTileArrowAni arrowAni;

	[SerializeField]
	private ButtonCtrl maskBtn;

	[SerializeField]
	private CampKingScrambleHitEffect hitEffect;

	[SerializeField]
	private CampTileNumFlyAni numFlyAni;

	[SerializeField]
	private Transform effectParent;

	private SequencePool sequencePool;

	private Sequence sequence;

	private LocalUnityObjctPool entityPool;

	private List<CampTileArrowAni> arrowItemList;

	private List<CampTileNumFlyAni> numFlyAniList;

	private ulong[] curAllScore;

	private CampKingScrambleManager KingScrambleManager => null;

	private CampKingScrambleTeamAttackData KingScrambleTeamAttackData => null;

	private CampKingScrambleTeamRankingData KingScrambleTeamRankingData => null;

	public void OnInit()
	{
	}

	private void InitPool()
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

	private void PlayAni(List<CampTileArrowDamageData> arrowData)
	{
	}

	private void StopAni()
	{
	}

	private Tweener PlayArrowAni(CampTileArrowType arrowType, Vector3 startPos, Vector3 endPos)
	{
		return null;
	}

	private void StopArrowAni()
	{
	}

	private void PlayTargetHitAni()
	{
	}

	private void StopTargetHitAni()
	{
	}

	private Tweener PlayNumFlyAni(CampTileArrowDamageData damageData)
	{
		return null;
	}

	private void StopNumFlyAni()
	{
	}

	public void Refresh()
	{
	}

	private void RefreshArrowCount(int count)
	{
	}

	private void RefreshCircle(ulong[] scores)
	{
	}

	private float GetUIAngle(Vector3 circleUIPos, Vector3 curTeamPos)
	{
		return 0f;
	}

	private void ClickMaskBtn()
	{
	}
}
