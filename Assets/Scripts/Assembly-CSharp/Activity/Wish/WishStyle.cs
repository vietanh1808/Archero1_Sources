using System;
using UnityEngine;

namespace Activity.Wish
{
	[Serializable]
	public class WishStyle
	{
		public ActivityMgr.Event eventType;

		[SerializeField]
		private string atlasName;

		[SerializeField]
		private string kv;

		[SerializeField]
		private string wishBg;

		[SerializeField]
		private string itemTaskBg;

		[HideInInspector]
		public Sprite spKv;

		[HideInInspector]
		public Sprite spWishBg;

		[HideInInspector]
		public Sprite spItemTaskBg;

		public void Load()
		{
		}

		public void Unload()
		{
		}
	}
}
