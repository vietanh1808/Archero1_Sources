using System;
using PureMVC.Interfaces;

namespace PureMVC.Patterns
{
	public class DelegateCommand : Notifier, ICommand, INotifier
	{
		private readonly Action<INotification> m_action;

		public DelegateCommand(Action<INotification> action)
		{
		}

		public virtual void Execute(INotification notification)
		{
		}
	}
}
