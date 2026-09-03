using System.Collections.Generic;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;

public class SailingShipEntityItem : MonoBehaviour
{
	[SerializeField]
	private RectTransform shipBaseParentRect;

	[SerializeField]
	private RectTransform shipBaseRect;

	[SerializeField]
	private RectTransform shipShipBaseRect;

	[SerializeField]
	private SailingShipEntityPart sailingShipEntityPart;

	[SerializeField]
	private SailingShipEntityFireAni fireAni;

	[SerializeField]
	private SailingShipEntityBeHitAni beHitAni;

	[SerializeField]
	private RectTransform matchShipSize;

	[SerializeField]
	private RectTransform matchShipShipSize;

	[SerializeField]
	private SailingShipEntityExitGameAni exitGameAni;

	[SerializeField]
	private SailingShipEntityRandomMoveAni randomMoveAni;

	[SerializeField]
	private GameObject catchFireObj;

	[SerializeField]
	private ParticleSystem catchFirePar;

	[SerializeField]
	private RectTransform shipAniParentRect;

	[SerializeField]
	private SailingShipPlayerBlood shipBlood;

	[SerializeField]
	private GameObject moveEffect;

	private const float DelayExitGameTime = 0.8f;

	private const float OriginShipSize = 320f;

	private const float MaxAddParScale = 0.5f;

	private SailingShipEntityItemData shipEntityItemData;

	private LocalUnityObjctPool pool;

	private bool isInit;

	private Tween delayCall;

	private Tween exitDelayCall;

	private List<SailingShipEntityPart> allCreateEntityPart;

	private float curShipSize;

	private SailingShipManager ShipManager => null;

	private SailingShipGameData ShipGameData => null;

	private SailingShipEntityData ShipEntityData => null;

	private SailingShipBattleResultData SailingShipBattleResultData => null;

	private float DelayEndGameTime => 0f;

	private void Init()
	{
	}

	private void InitPool()
	{
	}

	public void Refresh(SailingShipEntityItemData shipEntityItemData)
	{
	}

	private void RefreshActive()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshBlood(bool needAni)
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	private void ShipExitGame()
	{
	}

	private void SetExitParStatus(bool isActive)
	{
	}
}
