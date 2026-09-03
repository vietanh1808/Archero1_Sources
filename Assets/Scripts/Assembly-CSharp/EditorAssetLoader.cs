using System;
using UnityEngine;

public class EditorAssetLoader<T> : IResourcesLoader where T : UnityEngine.Object
{
	private Action<T> onComplete;

	private Func<string, Type, UnityEngine.Object> assetLoader;

	public string resPath { get; private set; }

	public UnityEngine.Object res { get; private set; }

	public bool IsStart { get; private set; }

	public bool IsDone { get; private set; }

	public EditorAssetLoader(string path, Func<string, Type, UnityEngine.Object> loadFun, Action<T> delegateOnComplete)
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
