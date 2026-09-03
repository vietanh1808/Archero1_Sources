using System.Collections.Generic;
using Newtonsoft.Json;

public class CampTeamData
{
	public int teamid;

	public string name;

	public List<CampTeamItemData> itemList;

	[JsonIgnore]
	public bool inTeam => false;

	[JsonIgnore]
	public int memberCount => 0;
}
