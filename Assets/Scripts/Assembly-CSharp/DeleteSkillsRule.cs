using System.Collections.Generic;
using TableTool;

public class DeleteSkillsRule
{
	public const string LOG_TAG = "[DeleteSkillsRule]";

	private static DeleteSkillsRule _instance;

	private int MAX_SKILL_COUNT;

	private Dictionary<int, List<int>> skillGroupDict;

	private Dictionary<int, int> deleteSkillCountDict;

	public static DeleteSkillsRule Instance => null;

	private void initDicts()
	{
	}

	private bool isInRemainSkillGroupList(List<KeyValuePair<int, List<int>>> remainSkillGroupList, int skillId)
	{
		return false;
	}

	public List<Skill_slotin> GetFilteredSkillList(List<Skill_slotin> filteredSkillList)
	{
		return null;
	}

	private List<KeyValuePair<int, List<int>>> populateDeleteSkillPool(List<Skill_slotin> filteredSkillList)
	{
		return null;
	}

	private void populateSkillGroupDict(List<Skill_slotin> filteredSkillList)
	{
	}
}
