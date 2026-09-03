using System;
using System.Collections.Generic;
using PureMVC.Interfaces;

namespace PureMVC.Patterns
{
	public class Facade : Notifier, IFacade, INotifier, IDisposable
	{
		protected IController m_controller;

		protected IModel m_model;

		protected IView m_view;

		protected static readonly IDictionary<string, IFacade> m_instanceMap;

		public const string DEFAULT_KEY = "PureMVC";

		protected new const string MULTITON_MSG = "Facade instance for this Multiton key already constructed!";

		public static IFacade Instance => null;

		public static IEnumerable<string> ListCore => null;

		public Facade(string key)
		{
		}

		public Facade()
		{
		}

		public void RegisterProxy(IProxy proxy)
		{
		}

		public IProxy RetrieveProxy(string proxyName)
		{
			return null;
		}

		public IProxy RemoveProxy(string proxyName)
		{
			return null;
		}

		public bool HasProxy(string proxyName)
		{
			return false;
		}

		public void RegisterCommand(string notificationName, Type commandType)
		{
		}

		public void RegisterCommand(string notificationName, ICommand command)
		{
		}

		public object RemoveCommand(string notificationName)
		{
			return null;
		}

		public bool HasCommand(string notificationName)
		{
			return false;
		}

		public void RegisterMediator(IMediator mediator)
		{
		}

		public IMediator RetrieveMediator(string mediatorName)
		{
			return null;
		}

		public IMediator RemoveMediator(string mediatorName)
		{
			return null;
		}

		public bool HasMediator(string mediatorName)
		{
			return false;
		}

		public void NotifyObservers(INotification notification)
		{
		}

		public override void SendNotification(string notificationName)
		{
		}

		public override void SendNotification(string notificationName, object body)
		{
		}

		public override void SendNotification(string notificationName, object body, string type)
		{
		}

		public static IFacade GetInstance()
		{
			return null;
		}

		public static IFacade GetInstance(string key)
		{
			return null;
		}

		public static bool HasCore(string key)
		{
			return false;
		}

		public static void RemoveCore(string key)
		{
		}

		public void Dispose()
		{
		}

		public static void BroadcastNotification(INotification notification)
		{
		}

		public static void BroadcastNotification(string notificationName)
		{
		}

		public static void BroadcastNotification(string notificationName, object body)
		{
		}

		public static void BroadcastNotification(string notificationName, object body, string type)
		{
		}

		static Facade()
		{
		}

		protected virtual void InitializeFacade()
		{
		}

		protected virtual void InitializeController()
		{
		}

		protected virtual void InitializeModel()
		{
		}

		protected virtual void InitializeView()
		{
		}
	}
}
