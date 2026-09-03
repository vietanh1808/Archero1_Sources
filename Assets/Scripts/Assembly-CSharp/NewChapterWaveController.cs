using System;
using UnityEngine;

public class NewChapterWaveController
{
	private const string UPDATE_NAME = "NewChapterWaveController-UPDATE";

	public const float CameraEndSize = 14f;

	public const int ResourceId = 6;

	public RoomGenerateBase roomGenerate;

	private Coroutine testCoroutine;

	private NewChapterWavesVO wavesVO;

	private bool IsWavesStarted;

	private bool IsWaveWorking;

	public Action<SingleNewChapterWaveVO> OnCurWaveFinished;

	private int curNPCCount;

	private ActionBasic delayAction;

	public NewChapterWaveGoodsCtrl newChapterWaveGoodsCtrl;

	private ConditionTime timeInterval;

	private float zeroMonsterDuration;

	private float updateInterval;

	private float preUpdateTime;

	private float preZeroTime;

	private float waveInterval;

	private float preRefreshMonsterTime;

	public int EnterDoorRoomID { get; set; }

	public int FinishedWaveNPCCount => 0;

	public NewChapterWaveController(RoomGenerateBase _value)
	{
	}

	public void Init()
	{
	}

	public void Deinit()
	{
	}

	private void onUpdate(float obj)
	{
	}

	private void GuaranteeForDailyNewWave()
	{
	}

	private void CheckNextWave()
	{
	}

	private void onTimer()
	{
	}

	private void onEventNPCStartDisappear(EventWindowCtrl ctrl)
	{
	}

	private void onCurWaveFinished(SingleNewChapterWaveVO finishedWaveVO)
	{
	}

	private void saveCurrentWave(SingleNewChapterWaveVO vo, bool enableAbsorb = true)
	{
	}

	private void startNextWave()
	{
	}

	private void Play129End()
	{
	}

	public bool IsCreatingMonsters()
	{
		return false;
	}

	public SingleNewChapterWaveVO GetWaveVO(int roomId)
	{
		return null;
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	public void CreateGameType5Enemies()
	{
	}

	private void onOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void startWave()
	{
	}
}
