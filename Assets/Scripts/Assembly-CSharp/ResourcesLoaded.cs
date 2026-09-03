using System;
using UnityEngine;

public class ResourcesLoaded<T> : IResourcesLoader where T : UnityEngine.Object
{
	private Action<T> onComplete;

	public string resPath { get; private set; }

	public UnityEngine.Object res { get; private set; }

	public bool IsStart { get; private set; }

	public bool IsDone { get; private set; }

	public ResourcesLoaded(string path, UnityEngine.Object obj, Action<T> delegateOnComplete)
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

	private void CallComplete()
	{
	}
}
