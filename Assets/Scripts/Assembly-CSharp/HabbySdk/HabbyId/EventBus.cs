using System;
using System.Collections.Generic;

namespace HabbySdk.HabbyId
{
	public class EventBus
	{
		private static readonly EventBus _instance;

		private Dictionary<Type, List<Action<object>>> listeners;

		private Dictionary<Delegate, Action<object>> delegateMap;

		public static EventBus Instance => null;

		static EventBus()
		{
		}

		private EventBus()
		{
		}

		public void Subscribe<T>(Action<T> handler) where T : HIDEvent
		{
		}

		public void Unsubscribe<T>(Action<T> handler) where T : HIDEvent
		{
		}

		public void Publish<T>(T eventData) where T : HIDEvent
		{
		}

		public void ClearAllEvents()
		{
		}
	}
}
