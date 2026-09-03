using System;
using UnityEngine;
using UnityEngine.UI;

public class UISliderTween : MonoBehaviour
{
	public float tweenTime;

	public Slider slider;

	private Action onTweenEnd;

	private Action onLoopEnd;

	private bool isTweening;

	private float tweenSpeed;

	private float tweenTarget;

	private int lastLoopTime;

	private float delayTime;

	private float tickTime;

	public void Tween(int loopTime, float targetValue, Action endAction, Action loopEndAction, float delay = 0f)
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}
}
