using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class SailingShipEntity : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private RectTransform shipParent;

	[SerializeField]
	private SailingShipEntityItem shipEntityItem;

	[SerializeField]
	private Transform selfPos;

	[SerializeField]
	private Transform enemyPos;

	[SerializeField]
	private Transform bossPos;

	private LocalUnityObjctPool pool;

	private List<SailingShipEntityItem> allCreateShipEntity;

	private SailingShipManager ShipManager => null;

	private SailingShipGameData ShipGameData => null;

	private SailingShipEntityData ShipEntityData => null;

	private SailingShipBattleResultData SailingShipBattleResultData => null;

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

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}
}
