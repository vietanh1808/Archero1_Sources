using System;
using UnityEngine;

public class TimeSchedule : MonoBehaviour
{
	[HideInInspector]
	public float time;

	[HideInInspector]
	public float delay;

	[HideInInspector]
	public float dtime;

	[HideInInspector]
	public Action action;

	private bool first;

	public void init(float time, float delay, float dtime, Action action = null)
	{
	}

	private void Update_Time()
	{
	}
}
