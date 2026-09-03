using System;
using System.Collections.Generic;
using PureMVC.Interfaces;

namespace PureMVC.Core
{
	public class View : IView, IDisposable
	{
		protected string m_multitonKey;

		protected IDictionary<string, IMediator> m_mediatorMap;

		protected IDictionary<string, IList<IObserver>> m_observerMap;

		protected static IView m_instance;

		protected static readonly IDictionary<string, IView> m_instanceMap;

		public const string DEFAULT_KEY = "PureMVC";

		protected const string MULTITON_MSG = "View instance for this Multiton key already constructed!";

		public IEnumerable<string> ListMediatorNames => null;

		public static IView Instance => null;

		protected View(string key)
		{
		}

		protected View()
		{
		}

		public virtual void RegisterObserver(string notificationName, IObserver observer)
		{
		}

		public virtual void NotifyObservers(INotification notification)
		{
		}

		public virtual void RemoveObserver(string notificationName, object notifyContext)
		{
		}

		public virtual void RegisterMediator(IMediator mediator)
		{
		}

		public virtual IMediator RetrieveMediator(string mediatorName)
		{
			return null;
		}

		public virtual IMediator RemoveMediator(string mediatorName)
		{
			return null;
		}

		public virtual bool HasMediator(string mediatorName)
		{
			return false;
		}

		public static void RemoveView(string key)
		{
		}

		public void Dispose()
		{
		}

		public static IView GetInstance()
		{
			return null;
		}

		public static IView GetInstance(string key)
		{
			return null;
		}

		static View()
		{
		}

		protected virtual void InitializeView()
		{
		}
	}
}
