using System.Collections.Generic;

namespace NewPlay125
{
	public class WavesVO
	{
		private const string LOG_TAG = "[NewChapterWavesVO]";

		public List<SingleWaveVO> wavesList;

		public WavesController WaveController;

		private IStageLayerManager stageLayerManager;

		private bool initialized;

		public WavesVO(WavesController _waveController)
		{
		}

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		public SingleWaveVO GetWaveVO(int roomId)
		{
			return null;
		}
	}
}
