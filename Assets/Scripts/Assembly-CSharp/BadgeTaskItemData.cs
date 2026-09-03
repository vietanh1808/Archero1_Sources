using System.Collections.Generic;

public class BadgeTaskItemData
{
	public int tid;

	public int type;

	public int pos;

	public int need;

	public int needShow;

	public int have;

	public bool haveGet;

	public List<int> argsList;

	public List<string> rewards;

	public bool isBPType => false;
}
