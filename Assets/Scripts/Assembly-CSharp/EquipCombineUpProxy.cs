using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using TableTool;

public class EquipCombineUpProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public LocalSave.EquipOne equip;

		public Action onClose;

		public List<LocalSave.EquipOne> mats;

		public uint transId;

		public List<Drop_DropModel.DropData> rewards;

		public void AddMatEquipID(LocalSave.EquipOne one)
		{
		}
	}

	public new const string NAME = "EquipCombineUpProxy";

	public EquipCombineUpProxy(object data)
	{
	}
}
