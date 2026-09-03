using System;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedMeshAnimation : MonoBehaviour
{
	[SerializeField]
	private List<AnimationFrameInfo> FrameInformations;

	[SerializeField]
	private MaterialPropertyBlockController PropertyBlockController;

	private static float _singleFrameTime;

	[SerializeField]
	public float Speed;

	public bool enable;

	private int _currentFrame;

	private AnimationFrameInfo _currentAnimation;

	private bool _loop;

	private bool _isPlaying;

	private bool _pause;

	private float _currentTime;

	private int m_currentFrameKeyIndex;

	private Action<GameObject, string> m_onListen;

	private static int _propertyId;

	public float singleFrameTime => 0f;

	public MaterialPropertyBlockController GetMaterialPropertyBlockController()
	{
		return null;
	}

	public void Setup(List<AnimationFrameInfo> frameInformations, MaterialPropertyBlockController propertyBlockController)
	{
	}

	public void ResetLastAnimation()
	{
	}

	public void Play(string animationName, bool loop, float speed)
	{
	}

	public bool IsPlaying(string animationName)
	{
		return false;
	}

	private void Update()
	{
	}

	public void Stop()
	{
	}

	private void SetFrame(int frame)
	{
	}

	private void GetNextFrame()
	{
	}

	private void SendAnimationStartEvent(string animationName)
	{
	}

	private void SendAnimationEndEvent(string animationName)
	{
	}

	public float GetCurrentNormalizedTime()
	{
		return 0f;
	}

	public float GetCurrentLength()
	{
		return 0f;
	}

	public void PauseAnimation(bool pause)
	{
	}

	public void SetSpeed(float speed)
	{
	}

	public void AddAnimationListen(Action<GameObject, string> listen)
	{
	}

	public void RemoveAnimationListen(Action<GameObject, string> listen)
	{
	}

	public bool IsHaveAnimation(string name)
	{
		return false;
	}

	public float GetCurAnimationLength()
	{
		return 0f;
	}
}
