using System;
using System.Collections.Generic;
using UnityEngine;

public class SilentDownloader : MonoBehaviour
{
	public enum SilentState
	{
		None = 0,
		Download = 1,
		Load = 2,
		Fail = 3,
		Success = 4
	}

	private int levelAssetCount;

	public int tryTime;

	public static readonly string MainMenuGroupName;

	public static readonly string[] AtlasToLoad;

	public static SilentState CurrentState;

	public static Action<bool> OnLoaded;

	public static void TryStartSlientDownload(Action<bool> onLoad = null)
	{
	}

	private void Start()
	{
	}

	private void OnCheckFinish(string groupName, bool ifFinish, int downloadCount, int downloadSize, List<string> downloadList)
	{
	}

	private void OnDownloadGroup(ResourceManager.BundleGroup group, bool ifSuccess)
	{
	}

	private void OnLoadGroup(string groupName, bool ifFinish, float percent)
	{
	}

	private void OnLoadAsset(string assetName, bool ifSuccess, object obj)
	{
	}

	private void OnDestroy()
	{
	}
}
