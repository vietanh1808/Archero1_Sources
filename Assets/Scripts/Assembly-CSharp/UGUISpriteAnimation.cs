using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class UGUISpriteAnimation : MonoBehaviour
{
	private Image ImageSource;

	private int mCurFrame;

	private float mDelta;

	public float FPS;

	public List<Sprite> SpriteFrames;

	public bool IsPlaying;

	public bool Foward;

	public bool AutoPlay;

	public bool Loop;

	public int FrameCount => 0;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void SetSprite(int idx)
	{
	}

	public void Play()
	{
	}

	public void PlayReverse()
	{
	}

	private void Update()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void Stop()
	{
	}

	public void Rewind()
	{
	}
}
