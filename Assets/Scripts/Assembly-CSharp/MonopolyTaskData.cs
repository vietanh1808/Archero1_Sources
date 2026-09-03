using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class MonopolyTaskData
{
	public List<MonopolyTaskItemData> monopolyTaskItemDatas;

	[CompilerGenerated]
	private Action m_OnTaskGet;

	public long LeftTime => 0L;

	public event Action OnTaskGet
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public List<MonopolyTaskItemData> GetAll()
	{
		return null;
	}

	public void RequestMonopolyTask(MonopolyTaskItemData giftData, int count)
	{
	}
}
