using System;
using PureMVC.Interfaces;
using UnityEngine;

public class SailingShipWarning : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private SailingShipWarningItem selfItem;

	[SerializeField]
	private SailingShipWarningItem enemyItem;

	[SerializeField]
	private SailingShipWarningAni warningAni;

	[SerializeField]
	private DxxText battleText;

	[SerializeField]
	private DxxText startText;

	private Action completeAction;

	private SailingShipManager SailingShipManager => null;

	private SailingShipGameData SailingShipGameData => null;

	private SailingShipWarningData SailingShipWarningData => null;

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

	public void PlayAni(Action completeAction)
	{
	}

	public void StopAni()
	{
	}
}
