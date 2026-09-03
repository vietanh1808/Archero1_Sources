using System;
using System.Collections.Generic;

public class KeySpeedAnimation
{
	public class KeyInfo
	{
		public float spdFrom;

		public float spdTo;

		public float time;
	}

	private List<KeyInfo> keyList;

	private int phaseIndex;

	private float timeCount;

	private float speed;

	private Action<int, float, float> onUpdate;

	public KeySpeedAnimation(List<KeyInfo> keyList, Action<int, float, float> onUpdate)
	{
	}

	public void Reset()
	{
	}

	public bool Update(float deltaTime)
	{
		return false;
	}

	public float GetTotalLength()
	{
		return 0f;
	}
}
