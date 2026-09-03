using System.Collections.Generic;

public class BadgeBoxItemData
{
	public int boxId;

	public bool isClaimed;

	public int needPoint;

	public int ability;

	public List<string> rewards;

	public bool isAbility => false;
}
