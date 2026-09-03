using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1411 : SkillAloneBase
{
	public class PlayerVO
	{
		public long hp;

		public Vector3 pos;
	}

	private int capacity;

	private int buffId;

	private int[] effectIds;

	private List<GameObject> effects;

	private const string TIMER_NAME = "SkillAlone1411-Timer";

	private int timerId;

	private Queue queue;

	private Coroutine _coroutine;

	private string ValueKey => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void CacheEffects()
	{
	}

	private void onTimer()
	{
	}

	private void addToQueue()
	{
	}

	private void onWillDead()
	{
	}
}
