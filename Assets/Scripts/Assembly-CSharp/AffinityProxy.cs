using System.Collections.Generic;
using PureMVC.Patterns;

public class AffinityProxy : Proxy
{
	public class Transfer
	{
		public List<int> ids { get; private set; }

		public Transfer(List<int> ids)
		{
		}
	}

	public new const string NAME = "AffinityProxy";

	public AffinityProxy(object data)
	{
	}
}
