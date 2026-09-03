using System.Collections.Generic;
using TableTool;

public class SailingGiftItemData
{
	public int type;

	public int gid;

	public int subType;

	public List<int> conds;

	public int position;

	public string productId;

	public int needType;

	public int needId;

	public int needCount;

	public List<Drop_DropModel.DropData> rewards;

	public int discount;

	public int have;

	public int max;

	public int time;

	public long beginTime;

	public bool trigger;

	public int triggerCount;

	public long lastTime;

	public long LeftTime => 0L;

	public int Left => 0;
}
