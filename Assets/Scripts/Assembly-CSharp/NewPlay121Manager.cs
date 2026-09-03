using System.Collections.Generic;

public class NewPlay121Manager : CInstance<NewPlay121Manager>
{
	public int[] NPCRoomIds;

	public const int DRAGON_COIN_EQUIP_ID = 38204;

	public const int NPC_ID = 9033;

	public const int DAILY_ID = 121;

	public const string LOG_TAG = "[NewPlay121]";

	private const int ACTIVE_SKILL_FLAG = 1;

	private const int PASSIVE_SKILL_FLAG = 3;

	public const int MAX_ACTIVE_SKILL_COUNT = 6;

	public List<int> AssembledSkills;

	public int CurDragonCoin => 0;

	public int DragonRefreshCost => 0;

	public void UpdateDragonCoin(int delta)
	{
	}

	public bool IsDragonCoinEnough(int cost)
	{
		return false;
	}

	public new void Init()
	{
	}

	public bool IsInNPCRoom(int roomId)
	{
		return false;
	}

	public void Add2AssembledSkills(int skillId)
	{
	}

	public bool IsActiveDragonSkill(int skillId)
	{
		return false;
	}

	public bool IsPassiveDragonSkill(int skillId)
	{
		return false;
	}

	public void AddSkillIdWrapper(int skillId)
	{
	}

	public void CheckDuplicates(List<int> list)
	{
	}

	public void AddSkillId(int skillId)
	{
	}

	public DragonVO CreateDragonVO(int dragonEquipId)
	{
		return null;
	}

	public void Add2LearnedSkills(int skillId)
	{
	}

	public bool hasLearnedSkill(int skillId)
	{
		return false;
	}

	public bool HasActiveSkill()
	{
		return false;
	}

	public List<int> PickFirstSkills(int pickedCount)
	{
		return null;
	}

	public List<int> PickNPCSkills(int pickedCount)
	{
		return null;
	}

	private List<int> populatePickedSkills(int pickedCount, int allWeight, List<TowerLevelManager.SkillWeight> skillWeightList, int defaultSkillId)
	{
		return null;
	}

	public List<int> GetAlternativeSkills()
	{
		return null;
	}

	public bool IsMaxActiveSkillsReached()
	{
		return false;
	}

	public List<int> GetFirstAlternativeSkills()
	{
		return null;
	}

	public List<int> GetConfigSkills()
	{
		return null;
	}

	public List<int> GetActiveSkills(List<int> originalList)
	{
		return null;
	}

	public List<int> RemoveList(List<int> originalList, List<int> removedList)
	{
		return null;
	}
}
