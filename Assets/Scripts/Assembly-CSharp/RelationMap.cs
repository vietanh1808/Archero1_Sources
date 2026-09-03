using System;
using System.Collections.Generic;

[Serializable]
public sealed class RelationMap
{
	public static readonly RelationMap Instance;

	public Dictionary<string, string> RelationInfos;

	static RelationMap()
	{
	}

	public bool TryGetAssetPath(string path, out string assetPath)
	{
		assetPath = null;
		return false;
	}

	public string ToJson()
	{
		return null;
	}
}
