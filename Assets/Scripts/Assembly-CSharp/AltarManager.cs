using System;
using System.Collections.Generic;

public sealed class AltarManager
{
	private static AltarManager instance;

	private static object Locker;

	public bool havePullData;

	public const int MaxLevel = 160;

	public const int MaxBreakId = 15;

	public const int MaxWish = 6;

	public const int BloodStone = 38001;

	public List<string> blessEquipList;

	public List<string> blessEquipList2;

	public List<string> blessEquipList3;

	private bool isAltarRelicsOpen;

	public static AltarManager Instance => null;

	private void init()
	{
	}

	public bool isOpen()
	{
		return false;
	}

	public List<string> GetAltarLevelEffects(int level, SelfAttributeData selfAttributeData)
	{
		return null;
	}

	public List<string> GetAltarBreakEffects(int bid)
	{
		return null;
	}

	public int GetEffectAdder(List<string> list, string effect)
	{
		return 0;
	}

	public List<AltarAttrData> getAltarAttrList(List<string> pre)
	{
		return null;
	}

	public List<AltarAttrData> getAltarAttrList(List<string> pre, List<string> next)
	{
		return null;
	}

	public List<AltarAttrData> getNextAltarAttrList(List<string> pre, List<string> next)
	{
		return null;
	}

	public void requestAltar(int operation, int type, List<ulong> list = null, List<uint> hlist = null, Action<int> callback = null)
	{
	}

	public List<LocalSave.EquipOne> getEquipList(int bid)
	{
		return null;
	}

	public int getNeedStoneNum(List<ulong> list, int bid, ref int progress)
	{
		return 0;
	}

	public long getLeftEffectTime()
	{
		return 0L;
	}

	public List<AltarAttrData> getAltarAttrLines(List<string> pre, List<string> next)
	{
		return null;
	}

	public List<string> getAltarEffects(SelfAttributeData selfAttributeData)
	{
		return null;
	}

	public string GetCurrentAltarEffect()
	{
		return null;
	}

	public int GetCurrentAltarEffectValue(string name)
	{
		return 0;
	}

	public void checkFreeAltarTime()
	{
	}

	public bool isOpenAltarHero()
	{
		return false;
	}

	public int heroNeedStoneList(List<uint> list, int bid, ref int progress)
	{
		return 0;
	}

	public int heroNeedStoneDict(Dictionary<int, int> dict, int bid, ref int progress)
	{
		return 0;
	}

	public List<LocalSave.EquipOne> getHeroFragmentList(int bid)
	{
		return null;
	}

	public List<string> GetAltarLevelEffects_Hero(int level)
	{
		return null;
	}

	public List<string> GetAltarBreakEffects_Hero(int bid)
	{
		return null;
	}

	public bool isOpenHeroExchange()
	{
		return false;
	}

	public bool isOpenAltarRelics()
	{
		return false;
	}

	public int RelicsNeedStoneList(List<uint> list, int bid, ref int progress)
	{
		return 0;
	}

	public int RelicsNeedStoneDict(Dictionary<int, int> dict, int bid, ref int progress)
	{
		return 0;
	}

	private int CalculateNeedStone(int totalProgress, int bloodRate)
	{
		return 0;
	}

	public List<LocalSave.EquipOne> getRelicsFragmentList(int bid)
	{
		return null;
	}

	public List<string> GetAltarLevelEffects_Relics(int level)
	{
		return null;
	}

	public List<string> GetAltarBreakEffects_Relics(int bid)
	{
		return null;
	}

	public int GetRelicsAddMaxLevel()
	{
		return 0;
	}
}
