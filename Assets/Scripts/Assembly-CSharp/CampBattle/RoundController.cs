using System;
using XLua;

namespace CampBattle
{
	public class RoundController
	{
		private const string UPDATE_NAME = "RoundController-Update";

		public int maxRound;

		private float configWaitTime;

		public Action<RoundVO> OnRoundFinished;

		private float waitTime;

		private int oldWaitTimeInSeconds;

		private int currentRound;

		public RoundVO curRoundVO;

		private float curWaitTime;

		private bool enableCountDown;

		private bool isRoundRest;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_DebugSetMaxRound;

		private static DelegateBridge __Hotfix0_DeInit;

		private static DelegateBridge __Hotfix0_IsMaxRoundFinished;

		private static DelegateBridge __Hotfix0_Start;

		private static DelegateBridge __Hotfix0_GetCurRoundMapAttr;

		private static DelegateBridge __Hotfix0_GetCurRoundAttr;

		private static DelegateBridge __Hotfix0_startRound;

		private static DelegateBridge __Hotfix0_onRoundFinishedHandler;

		private static DelegateBridge __Hotfix0_onUpdate;

		private static DelegateBridge __Hotfix0_CheckIfRoundRest;

		private static DelegateBridge __Hotfix0_CheckIfStartNewRound;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void Init()
		{
		}

		public void DebugSetMaxRound(int round)
		{
		}

		public void DeInit()
		{
		}

		public bool IsMaxRoundFinished()
		{
			return false;
		}

		public void Start(bool resumeGame = false)
		{
		}

		public string[] GetCurRoundMapAttr()
		{
			return null;
		}

		public string[] GetCurRoundAttr()
		{
			return null;
		}

		private void startRound()
		{
		}

		public void onRoundFinishedHandler(RoundVO roundVO)
		{
		}

		private void onUpdate(float obj)
		{
		}

		private void CheckIfRoundRest()
		{
		}

		private void CheckIfStartNewRound()
		{
		}
	}
}
