using System.Collections.Generic;
using Newtonsoft.Json;
using XLua;

public class ManorBuildingData
{
	public int buildId;

	public int level;

	public int starIndex;

	public long ltime;

	public ulong workerRowId;

	public Dictionary<int, int> abilityDict;

	public Dictionary<int, ulong> abilityTimeDict;

	public int ui;

	public Dictionary<ulong, int> stealDict;

	private static DelegateBridge __Hotfix0_get_starId;

	private static DelegateBridge _c__Hotfix0_ctor;

	[JsonIgnore]
	public int starId => 0;
}
