using System;
using TableTool;

public class SelectCharacterPopData
{
	public string title;

	public string content;

	public Action<PlayerCharacter_Character> callBack;

	public int resource;

	public int value;

	public PlayerCharacter_Character param;

	public SelectCharacterPopData()
	{
	}

	public SelectCharacterPopData(string t, string c, Action<PlayerCharacter_Character> back, int type, int v)
	{
	}
}
