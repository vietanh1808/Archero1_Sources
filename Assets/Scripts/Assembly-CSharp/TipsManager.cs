using System.Collections.Generic;
using UnityEngine;

public class TipsManager : CInstance<TipsManager>
{
	private struct TipsData
	{
		public string value1;

		public string value2;
	}

	private int tipsCount;

	private Queue<TipsData> mCacheList;

	private Transform get_parent()
	{
		return null;
	}

	private TipsCtrl Get()
	{
		return null;
	}

	public void Cache(GameObject o)
	{
	}

	public void CanShowNext()
	{
	}

	public void Show(string value1, string value2 = "")
	{
	}

	private void ShowMust(string value1, string value2)
	{
	}

	public void ShowSkill(int skillId)
	{
	}

	public void ShowSuperSkillTips()
	{
	}

	public new void Clear()
	{
	}
}
