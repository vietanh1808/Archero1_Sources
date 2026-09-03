using System;
using UnityEngine;

namespace Activity
{
	[Serializable]
	public class RedeemPanelStyle
	{
		public ActivityMgr.Event eventName;

		[SerializeField]
		private string atlasName;

		[SerializeField]
		private string bgPanel;

		[SerializeField]
		private string bgDesc;

		[SerializeField]
		private string bgDescText;

		[SerializeField]
		private string bgItemEqual;

		[SerializeField]
		private string bgItemPlus;

		[SerializeField]
		private string bgItemTarget;

		[SerializeField]
		private string bgItemPanel;

		public Color colorDescText;

		public Color colorArrow;

		public Color colorArrowEmpty;

		public Color colorItemBgNormal;

		public Color colorItemBgEmpty;

		public Color colorBgNum;

		[HideInInspector]
		public Sprite spBgPanel;

		[HideInInspector]
		public Sprite spBgDesc;

		[HideInInspector]
		public Sprite spBgDescText;

		[HideInInspector]
		public Sprite spIcon1;

		[HideInInspector]
		public Sprite spIcon2;

		[HideInInspector]
		public Sprite spBgItemPanel;

		[HideInInspector]
		public Sprite spBGItemEqual;

		[HideInInspector]
		public Sprite spBgItemPlus;

		[HideInInspector]
		public Sprite spBgItemTarget;

		public void Load()
		{
		}

		public void Unload()
		{
		}
	}
}
