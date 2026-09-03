using PureMVC.Interfaces;
using UnityEngine;

public class CampKingScrambleTeamRankingUIPanel : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private CampTileContributeRank contributeRank;

	private CampKingScrambleManager KingScrambleManager => null;

	private CampKingScrambleTeamRankingData KingScrambleTeamRankingData => null;

	private int CurCampStyle => 0;

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
}
