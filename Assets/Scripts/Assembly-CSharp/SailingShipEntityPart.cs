using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SailingShipEntityPart : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private RectTransform posRectTrans;

	[SerializeField]
	private RectTransform beHitRectTrans;

	[SerializeField]
	private RectTransform fireRectTrans1;

	[SerializeField]
	private RectTransform fireRectTrans2;

	[SerializeField]
	private SailingShipBattleCircle charging;

	[SerializeField]
	private SailingShipBattleCircle repairing;

	[SerializeField]
	private SailingShipCannonFireAni cannonFireAni;

	[SerializeField]
	private ParticleSystem firePar;

	[SerializeField]
	private ParticleSystem beHitPar;

	[SerializeField]
	private RectTransform matchPartSize;

	[SerializeField]
	private Transform partEffectParent;

	[SerializeField]
	private ParticleSystem beHitBossAttackPar;

	[SerializeField]
	private ParticleSystem beHitBossBuffPar;

	[SerializeField]
	private ParticleSystem beHitDurabilityUpPar;

	private const float BeHitEffectShowTime = 0.5f;

	private const float SailIconAlpha = 0.6f;

	private SailingShipEntityPartData shipEntityPartData;

	private int shipLevel;

	private int shipSkinID;

	private int shipConfigID;

	private Queue<(Vector3, SailingShipEntityPartData)> beHitDataQueue;

	private const int CannonBuffID = 1026;

	private const int CannonBuffFxBaseID = 7000000;

	private GameObject cannonBuffEffect;

	private SailingShipManager ShipManager => null;

	private SailingShipGameData ShipGameData => null;

	private SailingShipEntityData ShipEntityData => null;

	private SailingShipBattleResultData SailingShipBattleResultData => null;

	public void Refresh(SailingShipEntityPartData shipEntityPartData, int shipConfigID, int shipLevel, int shipSkinID)
	{
	}

	private void RefreshImg()
	{
	}

	private void RefreshPar()
	{
	}

	private void RefreshStatus()
	{
	}

	private void TriggerRecoverDurabilityPar(SailingShipBattleMsgItemData battleMsg)
	{
	}

	private void TriggerCannonBuffPar()
	{
	}

	public Image GetIconImage()
	{
		return null;
	}

	public RectTransform GetBeHitRectTrans()
	{
		return null;
	}

	public RectTransform GetFireRectTrans()
	{
		return null;
	}

	public void SetBeHitData((Vector3, SailingShipEntityPartData) beHitPos)
	{
	}

	public (Vector3, SailingShipEntityPartData) GetRealBeHitData()
	{
		return default;
	}

	public Vector3 CheckRealBeHitPos()
	{
		return default;
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	private void RefreshIcon()
	{
	}

	private void TriggerFirePar()
	{
	}

	private void TriggerBeHitPar()
	{
	}
}
