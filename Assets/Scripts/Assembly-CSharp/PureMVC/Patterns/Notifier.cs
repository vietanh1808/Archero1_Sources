using PureMVC.Interfaces;

namespace PureMVC.Patterns
{
	public class Notifier : INotifier
	{
		protected const string MULTITON_MSG = "Multiton key for this Notifier not yet initialized!";

		public string MultitonKey { get; protected set; }

		protected IFacade Facade => null;

		public virtual void SendNotification(string notificationName)
		{
		}

		public virtual void SendNotification(string notificationName, object body)
		{
		}

		public virtual void SendNotification(string notificationName, object body, string type)
		{
		}

		public void InitializeNotifier(string key)
		{
		}
	}
}
