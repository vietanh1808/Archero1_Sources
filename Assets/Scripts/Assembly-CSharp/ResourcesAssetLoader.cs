using System;
using UnityEngine;

public class ResourcesAssetLoader<T> : IResourcesLoader where T : UnityEngine.Object
{
	private Action<T> onComplete;

	private T resObejct;

	public string resPath { get; private set; }

	public string realPath { get; private set; }

	public UnityEngine.Object res => null;

	public bool IsStart { get; private set; }

	public bool IsDone { get; private set; }

	public bool IsLoaded { get; private set; }

	public ResourcesAssetLoader(string path, string pRealPath, Action<T> delegateOnComplete)
	{
	}

	public bool StartLoad()
	{
		return false;
	}

	private void LoadCallBack(string pKey, object pRes)
	{
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
