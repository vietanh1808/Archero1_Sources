using System;
using UnityEngine;

namespace Activity
{
	[Serializable]
	public class TreasureEventStyle
	{
		public ActivityMgr.Event eventName;

		[Header("Atlas")]
		[SerializeField]
		private string atlas;

		[SerializeField]
		private string bar;

		[SerializeField]
		private string icon;

		[SerializeField]
		private string bgItems;

		public Color colorBgPage;

		public Color colorBgContent;

		[HideInInspector]
		public Sprite spBar;

		[HideInInspector]
		public Sprite spIcon;

		[HideInInspector]
		public Sprite spBgItems;

		public void Load()
		{
		}

		public void Unload()
		{
		}
	}
}
