using System.Collections.Generic;

public class NewChapterWavesVO
{
	private const string LOG_TAG = "[NewChapterWavesVO]";

	public List<SingleNewChapterWaveVO> wavesList;

	public NewChapterWaveController WaveController;

	private RoomGenerateBase roomGenerate;

	private IStageLayerManager stageLayerManager;

	private bool initialized;

	public NewChapterWavesVO(NewChapterWaveController _waveController)
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public SingleNewChapterWaveVO GetWaveVO(int roomId)
	{
		return null;
	}
}
