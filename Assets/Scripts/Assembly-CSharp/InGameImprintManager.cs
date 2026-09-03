using System.Collections.Generic;
using TableTool;
using imprint;

public class InGameImprintManager
{
	public const string LOG_TAG = "[Imprint_Skill]";

	public const int ImprintOriginStone1 = 39406;

	public const int ImprintOriginStone2 = 39407;

	public const int ImprintOriginStone3 = 39408;

	public const int ImprintDrop1 = 31009;

	public const int ImprintDrop2 = 31010;

	public const int ImprintDrop3 = 31011;

	public const int WingFeather = 31012;

	private static InGameImprintManager instance;

	private List<LocalSave.ImprintOne> m_availableImprintOnes;

	private List<ImprintSkillVO> m_availableImprintSkillVOs;

	public int[] ImprintAllProp => null;

	public int[] WingAllProp => null;

	public static InGameImprintManager Instance => null;

	public List<LocalSave.ImprintOne> AvailableImprintOnes => null;

	public List<ImprintSkillVO> AvailableImprintSkillVOs => null;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public Dictionary<string, Goods_goods.GoodData> GetImprintAttrs(SelfAttributeData attributeData)
	{
		return null;
	}

	public int[] GetTrickoffSkills(int[] trickoffSkills)
	{
		return null;
	}

	private List<LocalSave.ImprintOne> GetImprintOnesForSkillPool()
	{
		return null;
	}

	private ImprintSkillVO GetImprintSkillVO(int protoSkillId)
	{
		return null;
	}

	private List<ImprintSkillVO> GetImprintSkillVOs(List<LocalSave.ImprintOne> imprintOnes)
	{
		return null;
	}

	public List<int> convert2AvailableSkillIds(List<int> skillIdList)
	{
		return null;
	}

	private List<int> GetAvailableSkillIds(Dictionary<int, List<int>> groupDict)
	{
		return null;
	}

	public static bool IsImprintSkillId(int skillId)
	{
		return false;
	}

	private Dictionary<int, List<int>> createSkillGroupDict(List<int> skillIdList)
	{
		return null;
	}

	public void printGroupDictInfo(Dictionary<int, List<int>> groupDict)
	{
	}

	private void printImprintSkillVOsInfo(List<ImprintSkillVO> imprintSkillVOs)
	{
	}
}
