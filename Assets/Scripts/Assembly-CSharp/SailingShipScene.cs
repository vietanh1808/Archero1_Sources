using PureMVC.Interfaces;
using UnityEngine;

public class SailingShipScene : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private Transform sailingMapObjParent;

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

	private void RefreshScene()
	{
	}
}
