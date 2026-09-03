using System.Collections.Generic;

public class BeliefSkillData : RecycleData<BeliefSkillConfigData>
{
	public List<BeliefSkillItemData> SkillDatas => null;

	public int MaxStage => 0;

	public List<BeliefSkillItemData> GetSkillDatasByStage(int stage)
	{
		return null;
	}

	public List<BeliefSkillItemData> GetSkillDatasByLayer(int stage, int layer)
	{
		return null;
	}

	public List<BeliefSkillItemData> GetMaxVisibleSkills(int stage)
	{
		return null;
	}

	public BeliefSkillItemData GetProgressItemData(int row, int col)
	{
		return null;
	}

	public List<BeliefSkillItemData> GetProgressItemDataByRow(int row)
	{
		return null;
	}

	public BeliefSkillItemData GetDataByID(int id)
	{
		return null;
	}

	public int GetCrtShowStage()
	{
		return 0;
	}

	public int GetMaxProgressItemCount(int crtUnlockStage)
	{
		return 0;
	}
}
