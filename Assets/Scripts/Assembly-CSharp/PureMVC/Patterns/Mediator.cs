using System.Collections.Generic;
using PureMVC.Interfaces;

namespace PureMVC.Patterns
{
	public class Mediator : Notifier, IMediator, INotifier
	{
		public const string NAME = "Mediator";

		protected string m_mediatorName;

		protected WindowID m_id;

		protected object m_viewComponent;

		public virtual IEnumerable<string> ListNotificationInterests => null;

		public virtual string MediatorName => null;

		public object ViewComponent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Mediator()
		{
		}

		public Mediator(string mediatorName)
		{
		}

		public Mediator(string mediatorName, object viewComponent)
		{
		}

		public virtual void HandleNotification(INotification notification)
		{
		}

		public virtual void OnRegister()
		{
		}

		public virtual void OnRemove()
		{
		}

		public virtual void PublicNotification(INotification notification)
		{
		}

		public virtual void Blur(bool blur)
		{
		}

		public virtual object GetEvent(string eventName)
		{
			return null;
		}
	}
}
