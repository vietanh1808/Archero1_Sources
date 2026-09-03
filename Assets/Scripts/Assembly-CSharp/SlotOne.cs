using System;
using UnityEngine;

public class SlotOne : MonoBehaviour
{
	[HideInInspector]
	public int Location;

	public GameObject[] items;

	private float[] progress;

	private int[] y;

	private bool isAutoStop;

	private bool isStopUpdatePos;

	private int endIndex;

	public Action<SlotOne> scrollEnd;

	private FarmSlotData slotData;

	public float maxSpeed;

	public float minSpeed;

	public float runTime;

	public float downTime;

	public void init(int eventId, int index)
	{
	}

	private void Update()
	{
	}

	public void beginSlot(float max, float min, float time)
	{
	}

	public void setEndSlotIndex(int index)
	{
	}

	private void setWaitIndex(int index)
	{
	}
}
