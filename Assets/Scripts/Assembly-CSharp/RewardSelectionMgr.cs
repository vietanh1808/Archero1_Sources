using System;
using System.Collections.Generic;
using TableTool;

public class RewardSelectionMgr : CInstance<RewardSelectionMgr>
{
	private readonly Dictionary<string, object> rewardCache;

	private Dictionary<int, int> _fragToChar;

	private Tuple<string, string, int[]> realCachedSelectionJsonAndIds;

	private Dictionary<int, ChoiceBox> cachedConfig;

	public Tuple<string, string, int[]> cachedSelectionJsonAndIds
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<int, int> fragToChar => null;

	public void ParseConfig()
	{
	}

	public ChoiceBox GetById(int id)
	{
		return null;
	}

	public void SaveSelection(string sourceName, RewardSelectionData data, bool forceOverwrite)
	{
	}

	public RewardSelectionData GetSelection(string source)
	{
		return null;
	}

	private void ResetSelection(string source)
	{
	}

	public void RemoveAllContains(string containing)
	{
	}

	public static Drop_DropModel.DropData GetChoiceBox(string[] rewards)
	{
		return null;
	}

	public static Drop_DropModel.DropData GetChoiceBox(int[][] rewards)
	{
		return null;
	}

	public static Drop_DropModel.DropData GetChoiceBox(List<Drop_DropModel.DropData> rewards)
	{
		return null;
	}

	public static Drop_DropModel.DropData GetChoiceBox(string reward)
	{
		return null;
	}

	public static Drop_DropModel.DropData GetChoiceBox(Drop_DropModel.DropData reward)
	{
		return null;
	}

	public static void ProcessCharFragmentData(int[][] input, out List<Drop_DropModel.DropData> result, out List<RewardSelectionDisplayConfig> configs, bool filterChars)
	{
		result = null;
		configs = null;
	}

	public static void ProcessCharFragmentData(List<Drop_DropModel.DropData> input, out List<Drop_DropModel.DropData> result, out List<RewardSelectionDisplayConfig> configs, bool filterChars)
	{
		result = null;
		configs = null;
	}
}
