using PureMVC.Interfaces;
using UnityEngine;

public class SailingGhostFleetRanking : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private ButtonCtrl rankingBtn;

	[SerializeField]
	private SailingGhostFleetRankingItem rankingItem;

	[SerializeField]
	private Transform rankingItemParent;

	[SerializeField]
	private SailingGhostFleetRankingItem selfRankingItem;

	[SerializeField]
	private SailingGhostFleetRankingDefaultItem defaultRankingItem;

	public const int SailingGhostFleetRankingShowItemCount = 3;

	private LocalUnityObjctPool pool;

	private SailingGhostFleetManager SailingGhostFleetManager => null;

	private SailingGhostFleetRankingData SailingGhostFleetRankingData => null;

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

	public void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void ClickRankingBtn()
	{
	}
}
