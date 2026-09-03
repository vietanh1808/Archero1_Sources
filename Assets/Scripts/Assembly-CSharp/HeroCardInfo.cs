using TableTool;
using UnityEngine;

public sealed class HeroCardInfo
{
	public int Index { get; private set; }

	public PlayerCharacter_Character Data { get; private set; }

	public string SpriteName => null;

	public Sprite RatingImage => null;

	public HeroCardInfo(int index, PlayerCharacter_Character data)
	{
	}
}
