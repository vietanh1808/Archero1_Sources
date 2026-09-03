using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class LoginVideoCtrl : MonoBehaviour
{
	public RawImage image;

	public VideoPlayer mPlayer;

	public Action OnPlayEnd;

	private void Start()
	{
	}

	private void OnLoopPointReached(VideoPlayer video)
	{
	}

	private void Update()
	{
	}
}
