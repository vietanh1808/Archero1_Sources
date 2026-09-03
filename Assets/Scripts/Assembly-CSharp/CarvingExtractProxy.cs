using System.Collections.Generic;
using PureMVC.Patterns;
using TableTool;

public class CarvingExtractProxy : Proxy
{
	public class Transfer
	{
		public List<Drop_DropModel.DropData> list;

		public uint transId;

		public BoxOpenFrom boxFrom;
	}

	public new const string NAME = "CarvingExtractProxy";

	public CarvingExtractProxy(object data)
	{
	}
}
