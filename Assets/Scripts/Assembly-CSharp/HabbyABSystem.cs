using System;
using System.Collections;
using Habby.AssetExpress.Asset;
using Habby.AssetExpress.Model;
using Habby.AssetExpress.Util;
using UnityEngine;

public class HabbyABSystem : SingletonScript<HabbyABSystem>
{
	public const string AssetMappingFile = "AssetMapping.json";

	public const string BuildInfoFile = "BuildInfo.json";

	public const int VERSION = 272;

	public bool DebugLocalLoad;

	private bool m_isInited;

	public Action<DownloadDescription> OnBundleDownloadedStart;

	public Action<DownloadDescription> OnBundleDownloadedFinish;

	public Action<DownloadDescription> OnBundleDownloadedFail;

	public Action<ResourceInfo> OnHotfixDownloadStarted;

	public Action<ResourceInfo> OnHotfixDownloadFinished;

	public string AssetPath;

	[HideInInspector]
	public int ServerIndex;

	public string ResourceServer;

	[HideInInspector]
	public DownloadStatusType DownloadStatus;

	private RemoteAssetResolver m_RemoteAssetResolver;

	public static bool IsInited => false;

	public static string AppLanguage { get; set; }

	public static string PlatformPath => null;

	public int BuiltinVersion => 0;

	public int DownloadingVersion => 0;

	public HotfixUpdateType HotfixType => HotfixUpdateType.None;

	public bool IsDownloading => false;

	public UpdateStatus UpdateStatus => null;

	public static string AssetRootPath => null;

	public void Init(string serverPath, string appLanguage)
	{
	}

	public override void Awake()
	{
	}

	public void FetchGroup(int group)
	{
	}

	public void FetchGroup(BundleGroup group)
	{
	}

	public void FetchBundle(string bundle, Action<bool> callback)
	{
	}

	public void PatchDownloadedAssets()
	{
	}

	private void Update()
	{
	}

	public override void OnDestroy()
	{
	}

	public void PauseDownloading()
	{
	}

	public void ResumeDownloading()
	{
	}

	public void HandleCoroutine(IEnumerator coroutine)
	{
	}
}
