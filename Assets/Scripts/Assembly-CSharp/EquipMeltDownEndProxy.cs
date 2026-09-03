using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using TableTool;

public class EquipMeltDownEndProxy : Proxy, IProxy, INotifier
{
	public class Transfer
	{
		public LocalSave.EquipOne meltEquip;

		public ulong a;

		public ulong b;

		public List<Drop_DropModel.DropData> drops;

		public uint transid;
	}

	public new const string NAME = "EquipMeltDownEndProxy";

	public EquipMeltDownEndProxy(object data)
	{
	}
}
