using System.Collections.Generic;
using DG.Tweening;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CampKingScrambleAutoSendArrowAni : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private RectTransform camp1StartPos;

	[SerializeField]
	private RectTransform camp2StartPos;

	[SerializeField]
	private RectTransform camp3StartPos;

	[SerializeField]
	private RectTransform camp4StartPos;

	[SerializeField]
	private RectTransform camp1EndPos;

	[SerializeField]
	private RectTransform camp2EndPos;

	[SerializeField]
	private RectTransform camp3EndPos;

	[SerializeField]
	private RectTransform camp4EndPos;

	[SerializeField]
	private CampKingScrambleHitEffect hitEffect;

	[SerializeField]
	private Transform effectParent;

	[SerializeField]
	private CampTileArrowAni arrowAni;

	[SerializeField]
	private Graphic graphic;

	private SequencePool sequencePool;

	private List<CampTileArrowAni> arrowItemList;

	private List<CampKingScrambleHitEffect> hitEffectList;

	private CampKingScrambleManager KingScrambleManager => null;

	private CampKingScrambleBaseData KingScrambleBaseData => null;

	private CampKingScrambleTeamAttackData KingScrambleTeamAttackData => null;

	private CampKingScrambleTeamRankingData KingScrambleTeamRankingData => null;

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

	private void Refresh()
	{
	}

	private void PlayAni()
	{
	}

	public void StopAni()
	{
	}

	private void SendArrow(int sendArrowCount, CampID campID)
	{
	}

	private Tweener PlayArrowAni(CampTileArrowType arrowType, Vector3 startPos, Vector3 endPos)
	{
		return null;
	}

	private void StopArrowAni()
	{
	}

	private void PlayTargetHitAni(Vector3 endPos)
	{
	}

	private void StopTargetHitAni()
	{
	}

	private (Vector3, Vector3) GetStartEndPos(CampID campID)
	{
		return default;
	}

	private float GetSendArrowTime()
	{
		return 0f;
	}
}
