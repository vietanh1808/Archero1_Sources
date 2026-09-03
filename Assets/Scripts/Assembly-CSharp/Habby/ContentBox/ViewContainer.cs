using System.Collections.Generic;
using UnityEngine;

namespace Habby.ContentBox
{
	public class ViewContainer
	{
		private Transform _transform;

		private Dictionary<string, ContentView> _views;

		public ViewType ViewType { get; private set; }

		public List<string> AllViewNames => null;

		public ViewContainer(ViewType viewtype, Transform transform)
		{
		}

		public bool ExistView(string name)
		{
			return false;
		}

		public ContentView GetView(string name)
		{
			return null;
		}

		public ContentView AddView(string name, ContentView view)
		{
			return null;
		}

		public void OpenView(string name, params object[] args)
		{
		}

		public void CloseView(string name, params object[] args)
		{
		}

		public ContentView RemoveView(string name)
		{
			return null;
		}
	}
}
