using System.Collections.Generic;
using PureMVC.Patterns;

public class MainModuleProxy : Proxy
{
	public class Transfer
	{
		public List<WindowID> WindowIds { get; private set; }
	}

	public new const string NAME = "MainModuleProxy";

	public MainModuleProxy(object data)
	{
	}
}
