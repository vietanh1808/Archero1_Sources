using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class SailingGhostFleetShip : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private Transform shipItemParent;

	[SerializeField]
	private SailingGhostFleetShipItem shipItem;

	private LocalUnityObjctPool pool;

	private List<SailingGhostFleetShipItem> createShipItem;

	private SequencePool sequencePool;

	private const float ShipItemShowInterval = 0.2f;

	private SailingGhostFleetManager SailingGhostFleetManager => null;

	private SailingGhostFleetShipData SailingGhostFleetShipData => null;

	private void InitPool()
	{
	}

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

	public void Refresh(bool isPlayAni, int selectIndex)
	{
	}

	private void RefreshItem(bool isPlayAni, int selectIndex)
	{
	}
}
