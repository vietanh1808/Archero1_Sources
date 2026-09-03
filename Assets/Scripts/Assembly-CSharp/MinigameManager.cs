using System.Collections.Generic;
using Habby.ContentBox;
using UnityEngine;

public class MinigameManager : CInstance<MinigameManager>
{
	private Dictionary<string, Content> _gameLoad;

	private Dictionary<string, Sprite> _gameIcon;

	private Dictionary<string, Sprite> _gameBanner;

	private int eventId;

	public void RequestGame(int minigameId)
	{
	}

	private void OnGameLoad(string name, Content view)
	{
	}

	private string GetBundleName(int minigameId)
	{
		return null;
	}

	private string GetAssetName(int minigameId)
	{
		return null;
	}

	public bool IsGamePresent(int minigameId)
	{
		return false;
	}

	public Sprite GetGameIcon(int minigameId)
	{
		return null;
	}

	public Sprite GetGameBanner(int minigameId)
	{
		return null;
	}

	public void SaveEventId(int eventId)
	{
	}

	public void RunGame(int minigameId, RectTransform parent)
	{
	}

	private void OnGameEnd(string contentName, bool win, int scroe)
	{
	}

	public void OnAndroidEscape(int minigameId)
	{
	}
}
