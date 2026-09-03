using System;
using System.Collections.Generic;

public class ModuleUnlockMgr : CInstance<ModuleUnlockMgr>
{
	private Queue<UnlockModuleData> unlockedModules;

	public UnlockModuleData curModuleData;

	private readonly HashSet<ushort> systems;

	public bool IsEmpty()
	{
		return false;
	}

	public bool IsInQueue(UnlockModuleData.ModuleName name)
	{
		return false;
	}

	public UnlockModuleData GetNext()
	{
		return null;
	}

	public void ResetCurrent()
	{
	}

	public void TryAdd(LocalSave.GuideTransfer data, Action display)
	{
	}

	public void Add(UnlockModuleData.ModuleName name, Action showTip, Action goToModule)
	{
	}

	public bool IfUnlockModule(UnlockModule module)
	{
		return false;
	}

	public bool Lock_Module_Talent()
	{
		return false;
	}

	public bool Lock_Module_Tower()
	{
		return false;
	}
}
