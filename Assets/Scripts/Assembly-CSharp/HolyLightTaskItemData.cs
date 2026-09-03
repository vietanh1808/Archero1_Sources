using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class HolyLightTaskItemData
{
	private STCommonTaskData taskData;

	public int needShow;

	public int tid => 0;

	public int type => 0;

	public int pos => 0;

	public int need => 0;

	public int have => 0;

	public bool haveGet => false;

	public List<int> argsList => null;

	public List<Drop_DropModel.DropData> rewards => null;

	public bool canGet => false;

	public HolyLightTaskItemData(STCommonTaskData _Data)
	{
	}

	public void SetHaveGet()
	{
	}

	public void AddHave(int count)
	{
	}
}
