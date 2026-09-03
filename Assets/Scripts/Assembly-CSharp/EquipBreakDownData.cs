using System.Collections.Generic;
using GameProtocol;
using TableTool;

public sealed class EquipBreakDownData
{
	public List<Drop_DropModel.DropData> DropList;

	public LocalSave.EquipOne EquipData;

	public string EquipName { get; private set; }

	public EquipBreakDownData(LocalSave.EquipOne equipData)
	{
	}

	public bool CheckResponeInfo(CRespEquipDecompose servData)
	{
		return false;
	}
}
