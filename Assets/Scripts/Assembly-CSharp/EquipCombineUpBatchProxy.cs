using System;
using System.Collections.Generic;
using PureMVC.Patterns;
using TableTool;

public class EquipCombineUpBatchProxy : Proxy
{
	public class Transfer
	{
		public Action onClose;

		public List<LocalSave.EquipOne> equipResults;

		public List<Drop_DropModel.DropData> rewards;

		public uint transId;
	}

	public new const string NAME = "EquipCombineUpBatchProxy";

	public EquipCombineUpBatchProxy(Transfer data)
	{
	}
}
