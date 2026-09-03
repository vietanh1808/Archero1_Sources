using System;
using System.Collections.Generic;
using PureMVC.Interfaces;

namespace PureMVC.Core
{
	public class Model : IModel, IDisposable
	{
		protected string m_multitonKey;

		protected IDictionary<string, IProxy> m_proxyMap;

		protected static IModel m_instance;

		protected static readonly IDictionary<string, IModel> m_instanceMap;

		public const string DEFAULT_KEY = "PureMVC";

		protected const string MULTITON_MSG = "Model instance for this Multiton key already constructed!";

		public IEnumerable<string> ListProxyNames => null;

		public static IModel Instance => null;

		public Model(string key)
		{
		}

		public Model()
		{
		}

		public virtual void RegisterProxy(IProxy proxy)
		{
		}

		public virtual IProxy RetrieveProxy(string proxyName)
		{
			return null;
		}

		public virtual bool HasProxy(string proxyName)
		{
			return false;
		}

		public virtual IProxy RemoveProxy(string proxyName)
		{
			return null;
		}

		public static IModel GetInstance(string key)
		{
			return null;
		}

		static Model()
		{
		}

		protected virtual void InitializeModel()
		{
		}

		public static void RemoveModel(string key)
		{
		}

		public void Dispose()
		{
		}
	}
}
