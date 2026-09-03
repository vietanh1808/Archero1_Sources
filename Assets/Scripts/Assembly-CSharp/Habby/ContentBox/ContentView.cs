using System.Collections.Generic;
using UnityEngine;

namespace Habby.ContentBox
{
	public class ContentView : ILRMono
	{
		public ViewType ViewType;

		[HideInInspector]
		public Content Content;

		[HideInInspector]
		public string ContentName;

		private Dictionary<string, Object> _assets;

		protected override string _ilrName => null;

		public virtual void OnLoad(params object[] args)
		{
		}

		public virtual void OnOpen(params object[] args)
		{
		}

		public virtual void OnClose(params object[] args)
		{
		}

		public virtual void OnRelease(params object[] args)
		{
		}

		public Object GetAsset(string name)
		{
			return null;
		}

		public Object GetAsset_ILR(string name)
		{
			return null;
		}
	}
}
