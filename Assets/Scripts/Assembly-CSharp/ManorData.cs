using System;
using System.Collections.Generic;
using XLua;

[Serializable]
public class ManorData : LocalSave.ICloneable<ManorData>
{
	public bool init;

	public ulong userid;

	public int level;

	public int exp;

	public int coin;

	public List<ManorBuildingData> buildingList;

	public List<ManorWorkerData> workerList;

	public List<ManorExchData> exchList;

	public int order;

	public List<int> charerList;

	private static DelegateBridge __Hotfix0_clear;

	private static DelegateBridge __Hotfix0_Clone;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void clear()
	{
	}

	public void Clone(ManorData source)
	{
	}
}
