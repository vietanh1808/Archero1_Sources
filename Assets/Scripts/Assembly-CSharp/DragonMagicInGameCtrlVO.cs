using System;
using System.Collections.Generic;

public class DragonMagicInGameCtrlVO
{
	private const float MAGIC_VALUE_PER_SEC = 1f;

	public EntityBase HostEntity;

	private Dictionary<DragonType, float> CDTimeDict;

	private Dictionary<DragonType, float> curTotalCDTimeDict;

	private Dictionary<DragonType, float> curCDTimeDict;

	private int timerId;

	public Action OnMagicValueChanged;

	public Action<DragonType> OnCDTimeChanged;

	private const float RECOVER_MP_TIME_INTERVAL = 1f;

	private float curTime;

	public float CurMagicValue => 0f;

	public int MaxMagicValue => 0;

	public float GetMagicPercent()
	{
		return 0f;
	}

	public float InitCurMagicValue(float value)
	{
		return 0f;
	}

	public float UpdateCurMagicValue(float deltaValue)
	{
		return 0f;
	}

	public void InitTimer()
	{
	}

	public void StartTimer()
	{
	}

	public void StopTimer()
	{
	}

	public void UpdateCDTimeDict(DragonType dragonType)
	{
	}

	public float GetCDTime(DragonType dragonType)
	{
		return 0f;
	}

	public void UpdateCurTotalCDTimeDict(DragonType dragonType, float cdTime)
	{
	}

	public float GetCurTotalCDTime(DragonType dragonType)
	{
		return 0f;
	}

	public void ClearCurCDTime()
	{
	}

	public void ClearCurCDTime(DragonType dragonType)
	{
	}

	public void UpdateCurCDTimeDict(DragonType dragonType, float value)
	{
	}

	public float GetRemainTime(DragonType dragonType)
	{
		return 0f;
	}

	private bool hasNoEnemy()
	{
		return false;
	}

	private void onTimer(float delta)
	{
	}

	public void DeInit()
	{
	}
}
