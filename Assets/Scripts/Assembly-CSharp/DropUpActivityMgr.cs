using System;
using System.Collections.Generic;

public class DropUpActivityMgr : CInstance<DropUpActivityMgr>
{
	private Dictionary<DropUpPropType, DropUpPropData> dropUpData;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	private void ClearDropUpData()
	{
	}

	public bool HaveAnyDropUpShow()
	{
		return false;
	}

	public bool HaveDropUpShow(DropUpPropType dropType)
	{
		return false;
	}

	public Dictionary<DropUpPropType, DropUpPropData> GetDropUpPropData()
	{
		return null;
	}

	public DropUpPropData GetDropUpPropData(DropUpPropType type)
	{
		return null;
	}

	public DropUpPropType GetDropUpPropType(int type)
	{
		return DropUpPropType.None;
	}

	public bool HaveAnyRedPoint()
	{
		return false;
	}

	public bool HaveRedPoint(DropUpPropType dropUpPropType)
	{
		return false;
	}

	public void requestDropUp(int type, Action action = null)
	{
	}
}
