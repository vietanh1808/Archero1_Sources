using System;
using UnityEngine;

public class AutoDespawnSound : MonoBehaviour
{
	public float DespawnTime;

	public SoundManager.SoundData sounddata;

	public Action<string, SoundManager.SoundData> callback;

	private float pDespawnTime;

	private bool bStart;

	private void OnEnable()
	{
	}

	public void SetDespawnTime(float time)
	{
	}

	private void Update()
	{
	}
}
