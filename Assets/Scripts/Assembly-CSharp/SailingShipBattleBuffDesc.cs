using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;

public class SailingShipBattleBuffDesc : MonoBehaviour
{
	[SerializeField]
	private GameObject obj;

	[SerializeField]
	private DxxText desc;

	private const float DelayRecycleTime = 3f;

	private SailingShipBattleFighter fighter;

	private SailingShipBattleBuffItemData showBuffData;

	private Tween delayCall;

	private SailingShipManager SailingShipManager => null;

	private SailingShipEntityData SailingShipEntityData => null;

	public void Refresh(SailingShipBattleFighter fighter)
	{
	}

	public void ShowStatus(SailingShipBattleBuffItemData showBuffData, bool isShow)
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	private void RefreshBuffDesc()
	{
	}
}
