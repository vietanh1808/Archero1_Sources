using System;
using System.Collections.Generic;
using UnityEngine.UI;
using XLua;

namespace newplay122
{
	public class RandomMapAnim
	{
		private const string UPDATE_NAME = "RandomMapAnim-UPDATE";

		private const float TOTAL_TIME = 2f;

		private const float TIME_OUT = 15f;

		private const float SHOW_INTERVAL = 0.08f;

		private float curTime;

		private float curTotalTime;

		private List<RawImage> imgList;

		private int showIndex;

		private bool canBeStopped;

		private RawImage curPickedImg;

		private List<int> curIndexPool;

		public bool hasNewLevel;

		public DailyChooseTDLevelPanel panel;

		public Action OnAnimFinished;

		private static DelegateBridge _c__Hotfix0_ctor;

		private static DelegateBridge __Hotfix0_HideAll;

		private static DelegateBridge __Hotfix0_AddImg;

		private static DelegateBridge __Hotfix0_ShowAnim;

		private static DelegateBridge __Hotfix0_ForceStopAnim;

		private static DelegateBridge __Hotfix0_IsPlaying;

		private static DelegateBridge __Hotfix0_onUpdate;

		private static DelegateBridge __Hotfix0_DeInit;

		public RandomMapAnim(DailyChooseTDLevelPanel _panel)
		{
		}

		public void HideAll()
		{
		}

		public void AddImg(RawImage img)
		{
		}

		public void ShowAnim()
		{
		}

		public void ForceStopAnim()
		{
		}

		public bool IsPlaying()
		{
			return false;
		}

		private void onUpdate(float obj)
		{
		}

		public void DeInit()
		{
		}
	}
}
