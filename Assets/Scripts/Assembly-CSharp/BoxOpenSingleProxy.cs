using System;
using PureMVC.Patterns;
using TableTool;

public class BoxOpenSingleProxy : Proxy
{
	public class Transfer
	{
		public EquipSource source;

		public LocalSave.TimeBoxType boxtype;

		public int childtype;

		public Drop_DropModel.DropData data;

		public int[] diamonds;

		public int count;

		public Action<Action> retry_callback;

		public BoxOpenFrom boxFrom;

		public int GetCurrentDiamond()
		{
			return 0;
		}

		public int GetStartDiamond()
		{
			return 0;
		}

		public void AddCount()
		{
		}

		public void ResetCount()
		{
		}
	}

	public new const string NAME = "BoxOpenSingleProxy";

	public BoxOpenSingleProxy(object data)
	{
	}
}
