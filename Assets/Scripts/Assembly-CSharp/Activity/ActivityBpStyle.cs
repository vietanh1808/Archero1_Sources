using System;
using UnityEngine;
using XLua;

namespace Activity
{
	[Serializable]
	public class ActivityBpStyle
	{
		public ActivityMgr.Event eventName;

		[SerializeField]
		private string atlas;

		[SerializeField]
		private string iconFree;

		[SerializeField]
		private string iconBp;

		[SerializeField]
		private string iconBpBig;

		[SerializeField]
		private string bgRewardUnlocked;

		[SerializeField]
		private string bgDetail;

		[SerializeField]
		private string bgUnlockItemLevel;

		[SerializeField]
		private string bglockItemLevel;

		[HideInInspector]
		public Sprite spIconFree;

		[HideInInspector]
		public Sprite spIconBp;

		[HideInInspector]
		public Sprite spIconBpBig;

		[HideInInspector]
		public Sprite spBgDetail;

		[HideInInspector]
		public Sprite spBgRewardUnlocked;

		[HideInInspector]
		public Sprite spBgUnlockItemLevel;

		[HideInInspector]
		public Sprite spBglockItemLevel;

		private static DelegateBridge __Hotfix0_Load;

		private static DelegateBridge __Hotfix0_Unload;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void Load()
		{
		}

		public void Unload()
		{
		}
	}
}
