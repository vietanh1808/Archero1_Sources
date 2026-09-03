using System;
using PureMVC.Interfaces;

namespace PureMVC.Patterns
{
	[Serializable]
	public class Observer : IObserver
	{
		public string NotifyMethod { private get; set; }

		public object NotifyContext { private get; set; }

		public Observer(string notifyMethod, object notifyContext)
		{
		}

		public void NotifyObserver(INotification notification)
		{
		}

		public bool CompareNotifyContext(object obj)
		{
			return false;
		}
	}
}
