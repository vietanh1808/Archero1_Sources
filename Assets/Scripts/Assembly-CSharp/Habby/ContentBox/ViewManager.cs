using System.Collections.Generic;
using UnityEngine;

namespace Habby.ContentBox
{
	public class ViewManager
	{
		private Dictionary<ViewType, ViewContainer> _containers;

		public static ViewManager Instance => null;

		private bool ExistContainer(ViewType type)
		{
			return false;
		}

		private ViewContainer GetContainer(ViewType type)
		{
			return null;
		}

		public void CreateViewContainer(ViewType type, Transform parent)
		{
		}

		public void DestroyViewContainer(ViewType type, bool releaseAsset = true)
		{
		}

		public bool ExistView(string name)
		{
			return false;
		}

		public bool GetView(string name, out ContentView view, out ViewContainer container)
		{
			view = null;
			container = null;
			return false;
		}

		public ContentView LoadView(string name, bool open = false, params object[] args)
		{
			return null;
		}

		public ContentView OpenView(string name, params object[] args)
		{
			return null;
		}

		public void CloseView(string name, params object[] args)
		{
		}

		public void ReleaseView(string name, bool releaseAsset = true, params object[] args)
		{
		}

		public void Destroy()
		{
		}
	}
}
