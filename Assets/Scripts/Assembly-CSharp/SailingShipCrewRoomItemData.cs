using System.Collections.Generic;
using TableTool;

public class SailingShipCrewRoomItemData
{
	private SailingShipCrewRoomItemSourceData SourceData { get; set; }

	private PlayerCharacter_Character CrewConfig => null;

	public int RoomID => 0;

	public int CrewID => 0;

	public int CrewStar => 0;

	public int Power => 0;

	public Dictionary<string, SailingShipPartAttributeItemData> Abilities => null;

	public static SailingShipCrewRoomItemData Create(SailingShipCrewRoomItemSourceData sourceData)
	{
		return null;
	}

	private Dictionary<string, SailingShipPartAttributeItemData> GetAbilities()
	{
		return null;
	}
}
