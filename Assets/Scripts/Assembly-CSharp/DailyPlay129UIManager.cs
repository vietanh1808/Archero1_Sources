using System;
using System.Collections.Generic;
using System.Text;
using GameProtocol;

public sealed class DailyPlay129UIManager : CInstance<DailyPlay129UIManager>
{
	public bool isPullNewData;

	public DailyPlay129ActData actData;

	public int[] heroChoosed;

	private StringBuilder _stringBuilder;

	public List<DailyPlay129BoxItemData> boxDataList;

	public DailyPlay129BoxItemData boxExtraData;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public void init()
	{
	}

	public void requestActData(Action<STRespActivityFrozenFortress, int> action = null)
	{
	}

	private void parseActBasicData(STRespActivityFrozenFortress data)
	{
	}

	public long LeftTime()
	{
		return 0L;
	}

	public bool isOpen()
	{
		return false;
	}

	public string GetHeroList()
	{
		return null;
	}

	public List<DailyPlay129CharItemData> GetCharShowList()
	{
		return null;
	}

	public bool isFullHero()
	{
		return false;
	}

	public int getHeroIdInPos(int pos)
	{
		return 0;
	}

	public int findPositionEmpty()
	{
		return 0;
	}

	public int isHeroChoosed(int heroId)
	{
		return 0;
	}

	public void setHeroInPosition(int pos, int heroId)
	{
	}

	public void saveHeroList()
	{
	}

	public void requestChooseDifficult(int diftId, Action<STRespActivityFrozenFortress, int> action = null)
	{
	}

	public List<DailyPlay129DifficultItemData> getDifficultShowList()
	{
		return null;
	}

	public void setChooseDifficultId(int dfid)
	{
	}

	public int getChooseDifficultId()
	{
		return 0;
	}

	public bool isChooseDifficultId(int diftId)
	{
		return false;
	}

	public bool isUnlockDifficultId(int diftId)
	{
		return false;
	}

	public int GetUnlockMaxDifficultId()
	{
		return 0;
	}

	public bool isHaveNewUnlockHero(int diftId)
	{
		return false;
	}

	private void parseBoxData(STRespActivityFrozenFortress data)
	{
	}

	public void requestBoxGet(int itemId, Action<STRespActivityFrozenFortress, int> action = null)
	{
	}

	public DailyPlay129BoxItemData GetBoxItemData(int boxid)
	{
		return null;
	}

	public List<DailyPlay129BoxItemData> getBoxShowList()
	{
		return null;
	}

	public bool checkBoxHaveGet(int index)
	{
		return false;
	}

	public bool checkBoxCommonAllGet()
	{
		return false;
	}

	public bool isHaveBoxCanGet()
	{
		return false;
	}

	public int GetBoxCommonTotalScore()
	{
		return 0;
	}

	public int GetBoxCommonPreScore(int boxid)
	{
		return 0;
	}

	public int GetBoxCommonNextScore(int boxid)
	{
		return 0;
	}

	public LocalSave.GamePlayActivityOneData getActBasicData()
	{
		return null;
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}
}
