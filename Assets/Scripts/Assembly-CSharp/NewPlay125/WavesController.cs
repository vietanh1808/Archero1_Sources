namespace NewPlay125
{
	public class WavesController
	{
		private const float waitAbsorbTime = 4f;

		private const string LOG_TAG = "[WavesController]";

		public InGameController InGameController;

		private XmlParser xmlParser;

		private WavesVO wavesVO;

		private MonsterWaveGenerator monsterWaveGenerator;

		private SingleWaveController singleWaveController;

		private int killCount;

		private bool isEndWaveProcessing;

		private NewPlay125Manager manager => null;

		public XmlParser XmlParser => null;

		public MonsterWaveGenerator MonsterWaveGenerator => null;

		public WavesController(InGameController controller)
		{
		}

		public void Init()
		{
		}

		public void Deinit()
		{
		}

		private void onAddExpAnimFinished(bool willLevelUp)
		{
		}

		private void onMonsterDead(EntityBase monster)
		{
		}

		public void StartWave()
		{
		}

		private void syncExp()
		{
		}

		public void CheckIfStartEndWaveProcess()
		{
		}

		public bool IsCurWaveFinished()
		{
			return false;
		}

		public void SyncExpWrapper()
		{
		}

		private void endWave_saveData()
		{
		}

		private void endWave()
		{
		}

		private void log(string info)
		{
		}

		private void logError(string info)
		{
		}
	}
}
