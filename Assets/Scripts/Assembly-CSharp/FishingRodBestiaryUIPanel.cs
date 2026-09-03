using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class FishingRodBestiaryUIPanel : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private FishingRodBestiaryItem rodBestiaryItem;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private Transform parent;

	private LocalUnityObjctPool pool;

	private FishingManager FishingManager => null;

	private FishingRodBestiaryData FishingRodBestiaryData => null;

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

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}
}
