using System.Collections.Generic;
using UnityEngine;

public class PlinkoUtility : CInstance<PlinkoUtility>
{
	[HideInInspector]
	public List<PlinkoPathJsonData> pathJsonList;

	[HideInInspector]
	public Dictionary<int, List<PlinkoPathInfo>> pathDict;

	[HideInInspector]
	public static Dictionary<int, int> row_column_dict;

	public bool isPathReady()
	{
		return false;
	}

	public void initPath()
	{
	}

	public void PlinkoPath_ParseJson()
	{
	}

	public PlinkoPathJsonData GetPlinkoPathJsonData(int pathId)
	{
		return null;
	}

	private void parsePathData()
	{
	}

	public PlinkoPathInfo GetPlinkoPathInfo(int id)
	{
		return null;
	}

	public PlinkoPathInfo GetPlinkoPathInfo(int hole, int id)
	{
		return null;
	}

	public PlinkoPathInfo GetPlinkoPathInfo_Random(int hole)
	{
		return null;
	}
}
