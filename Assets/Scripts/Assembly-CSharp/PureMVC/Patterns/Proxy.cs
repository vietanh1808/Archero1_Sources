using System;
using PureMVC.Interfaces;

namespace PureMVC.Patterns
{
	public class Proxy : Notifier, IProxy, INotifier
	{
		public static string NAME;

		public string ProxyName { get; protected set; }

		public object Data { get; set; }

		public Action Event_Para0 { get; set; }

		public Action<object> Event_Para1 { get; set; }

		public Proxy()
		{
		}

		public Proxy(string proxyName)
		{
		}

		public Proxy(string proxyName, object data)
		{
		}

		public virtual void OnRegister()
		{
		}

		public virtual void OnRemove()
		{
		}
	}
}
