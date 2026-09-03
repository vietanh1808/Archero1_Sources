using System;
using UnityEngine;

public class ResourcesLoader<T> : IResourcesLoader where T : UnityEngine.Object
{
	private Action<T> onComplete;

	private T resObejct;

	private ResourceRequest request;

	public string resPath { get; private set; }

	public UnityEngine.Object res => null;

	public bool IsStart { get; private set; }

	public bool IsDone { get; private set; }

	public ResourcesLoader(string path, Action<T> delegateOnComplete)
	{
	}

	public bool StartLoad()
	{
		return false;
	}

	public void Update()
	{
	}

	private void LoadEnd()
	{
	}

	public void CallComplete()
	{
	}
}
