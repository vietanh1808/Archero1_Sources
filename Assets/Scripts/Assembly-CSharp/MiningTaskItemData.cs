using System.Collections.Generic;
using TableTool;
using XLua;

public class MiningTaskItemData
{
	public int tid;

	public int type;

	public int pos;

	public int need;

	public int needShow;

	public int have;

	public bool haveGet;

	public List<int> argsList;

	public List<Drop_DropModel.DropData> rewards;

	private static DelegateBridge _c__Hotfix0_ctor;
}
