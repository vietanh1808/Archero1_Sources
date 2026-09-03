using System.Collections.Generic;
using PureMVC.Patterns;
using TableTool;

public class BoxOpenProxy : Proxy
{
	public class Transfer
	{
		public List<Drop_DropModel.DropData> list;

		public uint transId;

		public BoxOpenFrom boxFrom;

		public BoxOpenSingleProxy.Transfer oneTransfer;

		public int TenPrice;
	}

	public new const string NAME = "BoxOpenProxy";

	public BoxOpenProxy(object data)
	{
	}
}
