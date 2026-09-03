using System.Collections.Generic;
using GameProtocol;

public class StageAttributeController : CInstance<StageAttributeController>
{
	public const int StageDivide = 100;

	private Dictionary<int, int> stagePassedStepDict;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public void parseActData(STRespActivityAngelPurify data)
	{
	}

	public long getStageDownActTimePre()
	{
		return 0L;
	}

	public List<string> getStageAttributeListDown(int stage)
	{
		return null;
	}

	private int GetATKDown(int stage, int level)
	{
		return 0;
	}

	private int GetHPMaxDown(int stage, int level)
	{
		return 0;
	}

	public long getStageOpenTime(int stage)
	{
		return 0L;
	}

	public bool isOpenStageTime(int stage)
	{
		return false;
	}

	public void parseStagePassDict(STRespActivityAngelPurify data)
	{
	}

	public int getStagePassedStep(int chapter)
	{
		return 0;
	}

	public string getStepReward(int stage, int step)
	{
		return null;
	}

	public string getStagePassReward(int stage)
	{
		return null;
	}

	public string getStagePassRewardPreview(int stage)
	{
		return null;
	}

	public float getDropRateAdd()
	{
		return 0f;
	}
}
