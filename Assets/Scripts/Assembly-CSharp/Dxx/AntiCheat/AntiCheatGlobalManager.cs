using CodeStage.AntiCheat.ObscuredTypes;

namespace Dxx.AntiCheat
{
	public class AntiCheatGlobalManager
	{
		public static int MAX_PAUSE_COUNT;

		public const int PAUSE_BUFF_ID = 1167;

		public const float DELAY_REMOVE_BUFF_TIME = 1f;

		private static AntiCheatGlobalManager _instance;

		public AntiCheatLegalData legalData;

		public AntiCheatGameData gameData;

		public AntiCheatValidator validator;

		public AntiCheatTimer timer;

		public static AntiCheatGlobalManager Instance => null;

		public bool IsPauseDeadEnabled => false;

		public void Init()
		{
		}

		private void initConfig()
		{
		}

		private ObscuredInt getConfigValue(int configId)
		{
			return default;
		}

		private void initDetection()
		{
		}

		private void OnObscuredCheatingDetected()
		{
		}

		public void OnResumeGameFromPause()
		{
		}

		public void OnOtherResumGameFromPause(bool IsOtherPause)
		{
		}
	}
}
