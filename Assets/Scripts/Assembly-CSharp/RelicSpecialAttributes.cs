using System.Collections.Generic;

public class RelicSpecialAttributes
{
	private Dictionary<int, int> serverSpecialDict;

	public List<RelicSpecialCountVO> specialCountVOList;

	private int[] specialEquipTypes;

	private int[] specialPetTypes;

	public Dictionary<int, int> GetServerSpecialDict()
	{
		return null;
	}

	public List<RelicSpecialCountVO> GetSpecialCountVOList()
	{
		return null;
	}

	public void Init()
	{
	}

	public void SetServerSpecialDict(string jsonStr)
	{
	}

	public void RefreshServerSpecialInfos()
	{
	}

	public void AddSpecialCountVO(RelicSpecialCountVO vo)
	{
	}

	public RelicSpecialCountVO GetSpecialCountVOBySpecialId(int specialId)
	{
		return null;
	}

	public RelicSpecialCountVO GetSpecialCountVOByRelicID(int relicId)
	{
		return null;
	}

	private RelicSpecialCountVO createRelicSpecialCountVO(LocalSave.EquipOne relicOne)
	{
		return null;
	}

	private bool IsCountType(int type)
	{
		return false;
	}
}
