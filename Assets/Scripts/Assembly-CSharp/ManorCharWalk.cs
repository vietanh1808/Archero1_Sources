using System.Collections.Generic;
using UnityEngine;
using XLua;

public class ManorCharWalk : MonoBehaviour
{
	public GameObject Node;

	private List<ManorRoad> roadPointList;

	private ManorRoad currentMR;

	private ManorRoadData currentMRD;

	private Vector3 fromPoint;

	private Vector3 toPoint;

	private int charZ;

	private float TotalTime;

	private float mtime;

	private float fromx;

	private float tox;

	private float fromy;

	private float toy;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge __Hotfix0_setRoadPoint;

	private static DelegateBridge __Hotfix0_GetNextPointIndex;

	private static DelegateBridge __Hotfix0_LoadChar3D;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(int charid, List<ManorRoad> roadPointList)
	{
	}

	public void Update()
	{
	}

	private void setRoadPoint(int index)
	{
	}

	private int GetNextPointIndex(string name)
	{
		return 0;
	}

	public void LoadChar3D(int charid)
	{
	}
}
