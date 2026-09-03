using System.Collections.Generic;

public class CombineMaterialDataGroup : List<LocalSave.EquipOne>
{
	public int breakNeedType;

	public int breakNeedQuality;

	public int breakNeedSubQuality;

	public int breakNeedS;

	public int BreakNeed2Id;

	public int BreakNeed2Cnt;

	public int Type45_2thType;

	public int Temp_CombineTips;

	public int Type5_SubType;

	public int Type5_breakNeedType;

	public int Type5_breakNeedQuality;

	public int Type5_breakNeedS;

	public int BreakType { get; private set; }

	public int BreakNeedEquipId { get; private set; }

	public bool BreakNeed2 { get; private set; }

	public bool Full => false;

	public bool IsEmpty => false;

	public int MaterialCountTotal { get; private set; }

	public int BreakNeedCnt { get; private set; }

	public int NeedEquipSCount => 0;

	public new void Add(LocalSave.EquipOne item)
	{
	}

	public new bool Remove(LocalSave.EquipOne item)
	{
		return false;
	}

	public bool CanCombine(LocalSave.EquipOne item)
	{
		return false;
	}

	public void setType4_2thType()
	{
	}

	private void checkType4_2thType()
	{
	}

	private bool canCombine_Type4_2thType(LocalSave.EquipOne item)
	{
		return false;
	}

	private void checkType5_2thType()
	{
	}

	private bool canCombine_Type5_2thType(LocalSave.EquipOne item)
	{
		return false;
	}

	public string printItems()
	{
		return null;
	}
}
