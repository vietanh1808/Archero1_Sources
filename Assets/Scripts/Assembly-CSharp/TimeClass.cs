using System;
using System.Collections.Generic;

public class TimeClass
{
	private float StartTime;

	private float DelayTime;

	private Action callback;

	private List<TimeClass> m_TimeList;

	private List<Action> m_TimePerFrameList;

	private int TimeCount;

	private int TimePerFrameCount;

	private bool IsDelayOver(float CurrentTime)
	{
		return false;
	}

	public void StartCallBack(float AliveTime, float DelayTime, Action callback)
	{
	}

	public void StartCallBack(float AliveTime, Action callback)
	{
	}

	public void RemoveCallBack(Action callback)
	{
	}

	public bool IsCallBackOver(Action callback)
	{
		return false;
	}

	public void UpdateTimeClass(float AliveTime)
	{
	}

	public void StartPerFrame(Action callback)
	{
	}

	public void StopPerFrame(Action callback)
	{
	}

	public void Reset()
	{
	}
}
