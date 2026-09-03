using System;
using UnityEngine;

public class CatAnimatorReceiver : MonoBehaviour
{
	private Action<string> OnAnimationEnd;

	public void OnJumpStartEnd()
	{
	}

	public void OnJumpIdleEnd()
	{
	}

	public void OnJumpEndEnd()
	{
	}

	public void OnJumpMiddle()
	{
	}

	public void OnJumpMiddleEnd()
	{
	}

	public void SetListener(Action<string> action)
	{
	}
}
