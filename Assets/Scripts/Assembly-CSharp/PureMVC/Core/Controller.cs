using System;
using System.Collections.Generic;
using PureMVC.Interfaces;

namespace PureMVC.Core
{
	public class Controller : IController, IDisposable
	{
		protected string m_multitonKey;

		private IView m_view;

		private readonly IDictionary<string, object> m_commandMap;

		protected static readonly IDictionary<string, IController> m_instanceMap;

		public const string DEFAULT_KEY = "PureMVC";

		protected const string MULTITON_MSG = "Controller instance for this Multiton key already constructed!";

		public static IController Instance => null;

		public IEnumerable<string> ListNotificationNames => null;

		public Controller(string key)
		{
		}

		public Controller()
		{
		}

		public void ExecuteCommand(INotification notification)
		{
		}

		public void RegisterCommand(string notificationName, Type commandType)
		{
		}

		public void RegisterCommand(string notificationName, ICommand command)
		{
		}

		public bool HasCommand(string notificationName)
		{
			return false;
		}

		public object RemoveCommand(string notificationName)
		{
			return null;
		}

		public static IController GetInstance()
		{
			return null;
		}

		public static IController GetInstance(string key)
		{
			return null;
		}

		static Controller()
		{
		}

		private void InitializeController()
		{
		}

		public void Dispose()
		{
		}

		public static void RemoveController(string key)
		{
		}
	}
}
