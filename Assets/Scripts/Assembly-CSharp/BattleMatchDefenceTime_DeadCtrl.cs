using System;
using DG.Tweening;
using UnityEngine;

public class BattleMatchDefenceTime_DeadCtrl : MonoBehaviour
{
	public GameObject child;

	public DxxText Text_DeadContent;

	public DxxText Text_DeadTime;

	private int mTime;

	private int mCurrentTime;

	private Action mCallback;

	private Sequence seq;

	public void Show(bool value)
	{
	}

	public void SetTime(int time, Action callback)
	{
	}

	private void OnUpdateSecond()
	{
	}

	private void SetTime(int time)
	{
	}

	public void Deinit()
	{
	}

	private void KillSequence()
	{
	}

	public void OnLanguageChange()
	{
	}
}
