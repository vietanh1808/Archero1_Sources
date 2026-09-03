using System;
using Habby.AssetExpress.Model;
using ILRuntime.Runtime.Enviorment;
using UnityEngine;

namespace Habby.ContentBox
{
	public class ContentCore
	{
		public const string API_GET = "";

		public static ContentCore Instance => null;

		public ILRuntime.Runtime.Enviorment.AppDomain AppDomain => null;

		public ILRuntimeManager ILRuntimeManager { get; private set; }

		public AssetManager AssetManager { get; private set; }

		public MoudleManager MoudleManager { get; private set; }

		public ViewManager ViewManager { get; private set; }

		public void Initialize()
		{
		}

		private void FetchContentFromServer()
		{
		}

		private void OnDownloadFinish(ResourceInfo resource)
		{
		}

		public Content GetContent(string content)
		{
			return null;
		}

		public void ReleaseContent(string content)
		{
		}

		public void LoadAssetAsync(string content, string bundle, Action<string, Content> callback, bool open = false, params object[] args)
		{
		}

		public void ReleaseAsset(string content)
		{
		}

		public ContentView LoadView(string content, bool open = false, params object[] args)
		{
			return null;
		}

		public ContentView OpenView(string content, params object[] args)
		{
			return null;
		}

		public ContentView GetView(string content)
		{
			return null;
		}

		public void CloseView(string content, params object[] args)
		{
		}

		public void ReleaseView(string content, bool releaseAsset = true, params object[] args)
		{
		}

		public void CreateViewContainer(ViewType viewType, Transform parent)
		{
		}

		public void DestroyViewContainer(ViewType viewType, bool releaseAsset = true)
		{
		}

		public void Destroy()
		{
		}
	}
}
