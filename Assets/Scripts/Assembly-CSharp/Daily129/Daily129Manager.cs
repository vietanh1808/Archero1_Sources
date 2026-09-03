namespace Daily129
{
	public class Daily129Manager : Singleton<Daily129Manager>
	{
		private const string TAG = "Daily129Manager";

		public const float CameraEndSize = 14f;

		private Daily129TowerController _towerController;

		private Daily129InGameController _inGameController;

		private long _lStartTime;

		public Daily129TowerController TowerController => null;

		public Daily129InGameController InGameController => null;

		public bool Game_Result
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long StartTime => 0L;

		public int Game_Score => 0;

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		private void OnCloseUI(WindowID id)
		{
		}
	}
}
