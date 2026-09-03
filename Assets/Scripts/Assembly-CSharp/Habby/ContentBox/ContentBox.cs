using System;
using Habby.AssetExpress.Util;
using UnityEngine;

namespace Habby.ContentBox
{
	public class ContentBox : StaticSingletonScript<ContentBox>
	{
		private bool _isInitialize;

		public ContentCore Core { get; private set; }

		public override void Awake()
		{
		}

		public void Initialize()
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

		private new void OnDestroy()
		{
		}
	}
}
