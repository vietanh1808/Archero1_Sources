using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Dxx;
using Habby.LoadAsset;
using UnityEngine;
using UnityEngine.Networking;

public class ResourceManager
{
	private class ResourceData
	{
		private DxxSpriteAtlas _atlas;

		public float time;

		public DxxSpriteAtlas atlas
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int refCnt { get; private set; }

		public bool CheckRelease(bool bForce = false)
		{
			return false;
		}

		public void Retain()
		{
		}

		public void Release()
		{
		}
	}

	private class AnimationClipData
	{
		public DxxAnimationAsset asset;

		public float time;
	}

	public enum ResourceMode
	{
		eDefault = 0,
		eEditor = 1,
		eLocal = 2,
		eRemote = 3
	}

	public sealed class ResourceDownloadHelper
	{
		public sealed class DownloadInfo
		{
			public string BundleName { get; private set; }

			public string Url { get; private set; }

			public string Path { get; private set; }

			public int Length { get; private set; }

			public int HashCode { get; private set; }

			public int ZipLength { get; private set; }

			public int ZipHashCode { get; private set; }

			public int RetryTimes { get; set; }

			public int CurrentDownloadSize { get; private set; }

			public DownloadInfo(string name, string url, string path, int len, int hashcode, int zipLen, int zipHash, int retry)
			{
			}

			public void AddRetryTime()
			{
			}

			public void RestRetyTimes()
			{
			}

			public void SetDownloadedSize(int downloadSize)
			{
			}
		}

		private ResourceManager resourceManager;

		private List<DownloadInfo> DownloadWaitingList;

		private List<DownloadInfo> DownloadingList;

		private List<DownloadInfo> AllToDownloadList;

		private List<DownloadInfo> DownloadGroupList;

		private BundleGroup CurrentDownloadGroup;

		private int downloadRetryCount;

		private int downloadTaskCount;

		public Action<BundleGroup, bool, bool> OnGroupDownloadComplete;

		public Action<DownloadInfo> OnBundleDownloadStart;

		public Action<DownloadInfo, float> OnBundleDownloading;

		public Action<DownloadInfo> OnBundleDownloadSuccess;

		public Action<DownloadInfo, string> OnBundleDownloadFail;

		private bool ifHaveFailDownload;

		public int GroupDownloadSize { get; private set; }

		public int WaitingCount => 0;

		public int DownloadingCount => 0;

		public int ToDownloadCount => 0;

		public int CurrentCount { get; private set; }

		public ResourceDownloadHelper(ResourceManager resMgr)
		{
		}

		private void UpdateDownloadTask()
		{
		}

		public void ClearCallBacks()
		{
		}

		public void RegisterCallBacks(Action<BundleGroup, bool, bool> onComplete, Action<DownloadInfo> onStart, Action<DownloadInfo, float> onDownloading, Action<DownloadInfo> onSuccess, Action<DownloadInfo, string> onFail)
		{
		}

		public void DeInit()
		{
		}

		public void AddAllToDownload(string bundleName, string url, string path, int len, int hashCode, int zipLen, int zipHash)
		{
		}

		public void DownloadBundleGroup(BundleGroup bundleGroup)
		{
		}

		public void CancelAllDownload()
		{
		}

		private void OnDownloadStart(object sender, DownloadInfo info)
		{
		}

		private void OnDownloading(object sender, DownloadInfo info, float progress)
		{
		}

		private void OnDownloadSuccess(object sender, DownloadInfo info)
		{
		}

		private void OnDownloadFail(object sender, DownloadInfo info, string errorInfo)
		{
		}

		public int GetTotalDownloadLength()
		{
			return 0;
		}
	}

	public sealed class ResourceCheckHelper
	{
		public sealed class ValidInfo
		{
			public enum ValidState
			{
				eNone = 0,
				eValid = 1,
				eInValid = 2,
				eNotExist = 3,
				eNeedless = 4
			}

			public struct ValidData
			{
				public bool IfExist;

				public int Length;

				public int HashCode;

				public ValidData(bool ifExist, int length, int hashCode)
				{
					IfExist = false;
					Length = 0;
					HashCode = 0;
				}
			}

			public string BundleName { get; private set; }

			public ValidState BundleState => ValidState.eNone;

			public ValidData RemoteInfo { get; set; }

			public ValidData LocalInfo { get; set; }

			public ValidInfo()
			{
			}

			public ValidInfo(string bundleName)
			{
			}
		}

		private ResourceManager resourceManager;

		public Dictionary<string, ValidInfo> ValidDictionary;

		public ResourceCheckHelper(ResourceManager resMgr)
		{
		}

		public void InitAllCheckData()
		{
		}

		public void CheckAllResources(bool ifUpdate, bool ifGetList, Action<bool, int, int, List<string>> onCheckFinish)
		{
		}

		public void CheckGroupResources(string groupName, bool ifUpdate, bool ifGetList, Action<string, bool, int, int, List<string>> onCheckFinish)
		{
		}

		public ValidInfo GetValidInfo(string bundleName)
		{
			return null;
		}
	}

	public sealed class ResourcePackageHelper
	{
	}

	public sealed class ResourceLoadHelper
	{
		public class EncryptionStream : FileStream
		{
			public byte EncryptionKey { get; set; }

			public EncryptionStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
				: base(null, (FileMode)0)
			{
			}

			public EncryptionStream(string path, FileMode mode)
				: base(null, (FileMode)0)
			{
			}

			public void SetEncrytionKey(byte key)
			{
			}

			public override int Read(byte[] array, int offset, int count)
			{
				return 0;
			}

			public override void Write(byte[] array, int offset, int count)
			{
			}
		}

		public delegate void OnUserLoadGroup(string groupName, bool ifFinish, float percent);

		public delegate void OnLoadGroup(string groupName, bool ifFinish, float percent);

		public delegate void OnLoadBundle(string groupName, string bundleName, AssetBundle bundle);

		public delegate void OnLoadAsset(string assetName, bool ifSuccess, object asset);

		public sealed class GroupLoadInfo
		{
			private ResourceManager resourceManager;

			private ResourceLoadHelper loadHelper;

			private BundleGroup groupInfo;

			private List<string> bundleLoadList;

			private int bundleLoadIndex;

			private OnLoadBundle onLoadBundle;

			private OnLoadGroup onLoadGroup;

			private OnUserLoadGroup onUserLoadGroup;

			public string GroupName { get; set; }

			public bool IfLoading { get; private set; }

			public GroupLoadInfo(string name, ResourceManager resMgr, ResourceLoadHelper helper)
			{
			}

			public bool IfDownloaded()
			{
				return false;
			}

			public void LoadAllAsync(OnLoadBundle loadBundle, OnLoadGroup loadGroup, OnUserLoadGroup userLoadGroup)
			{
			}

			private void LoadBundleCallBack(AsyncOperation loadOp)
			{
			}

			private void LoadEncryptionBundleCallBack(AsyncOperation loadOp)
			{
			}
		}

		private HashSet<string> bundleGroupNames;

		private Dictionary<string, AssetBundle> bundlesDictionary;

		private Dictionary<string, int> bundlesReference;

		private Dictionary<string, GroupLoadInfo> loadingGroups;

		private ResourceManager resourceManager;

		public ResourceLoadHelper(ResourceManager resMgr)
		{
		}

		public bool IfHaveAsset(string assetName)
		{
			return false;
		}

		public void LoadAssetTemp(string assetName, OnLoadAsset onLoadAsset)
		{
		}

		public void UnloadAssetTemp(string assetName)
		{
		}

		public void LoadBundleGroup(string groupName, OnUserLoadGroup onUserLoadGroup)
		{
		}

		public bool UnloadBundleGroup(string groupName)
		{
			return false;
		}

		public void OnLoadBundleComplete(string groupName, string bundleName, AssetBundle bundle)
		{
		}

		public void OnLoadingGroup(string groupName, bool ifFinish, float percent)
		{
		}
	}

	public delegate void LoadBytesCallback(string filePath, bool ifSuccess, byte[] data, string errorMsg);

	[Serializable]
	public class LevelAssets
	{
		public string LevelName;

		public List<MapAssetData> MapAssets;
	}

	[Serializable]
	public class MapAssetData
	{
		public enum MapAssetType
		{
			eMapObj = 0,
			eAtlas = 1,
			eOther = 2
		}

		public string Name;

		public string AssetName;

		public MapAssetType AssetType;

		public MapAssetData()
		{
		}

		public MapAssetData(string assetName)
		{
		}
	}

	[Serializable]
	public sealed class AssetInfo
	{
		public string AssetName { get; private set; }

		public string BundleName { get; private set; }

		public string[] DependencyAssets { get; private set; }

		public AssetInfo()
		{
		}

		public AssetInfo(string assetName, string bundleName, string[] dependencyAssets)
		{
		}
	}

	[Serializable]
	public sealed class BundleGroup
	{
		public Dictionary<string, BundleInfo> RemoteBundleInfos;

		[NonSerialized]
		public Dictionary<string, BundleInfo> AllBundleInfos;

		public string GroupName { get; private set; }

		public long TotalLength { get; private set; }

		public long TotalZipLength { get; private set; }

		public long ReadyLength => 0L;

		public int TotalCount => 0;

		public int ReadyCount => 0;

		public bool IsReady => false;

		public float Progress => 0f;

		public BundleGroup()
		{
		}

		public BundleGroup(string name)
		{
		}

		public void SetAllBundleInfo(Dictionary<string, BundleInfo> bundleInfos)
		{
		}

		public Dictionary<string, BundleInfo> GetAllRemoteBundleInfos()
		{
			return null;
		}

		public bool HasBundleInGroup(string bundleName)
		{
			return false;
		}

		public void AddRemoteBundleInfo(string bundleName, int length, int hashCode, int zipLength, int zipHashCode)
		{
		}
	}

	[Serializable]
	public sealed class BundleInfo
	{
		public string BundleName { get; private set; }

		public int Length { get; private set; }

		public int HashCode { get; private set; }

		public BundleInfo()
		{
		}

		public BundleInfo(string name, int length, int hashCode)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CLoadBytes_003Ed__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string filePath;

		public LoadBytesCallback onLoaded;

		private UnityWebRequest _003CunityWebRequest_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CLoadBytes_003Ed__96(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static ResourceManager _instance;

	private Dictionary<string, UnityEngine.Object> resMap;

	private Dictionary<string, UnityEngine.Object> mapMap;

	private static ResourceUpdater updateObject;

	private AssetMap assetMap;

	public const string ATLAS_PATH = "Atlas";

	private const float remove_time = 300f;

	private static Dictionary<string, ResourceData> mAtlasList;

	private static float time;

	private const float RELEASE_TIME = 30f;

	private const string Tag = "ResourceManager";

	private static Dictionary<string, ResourceData> mMapAtlasList;

	private const string ANIASSET_PATH = "AniAssets";

	private static Dictionary<string, AnimationClipData> mAnisList;

	private static RelationMap relationManager;

	private static StringBuilder strTemp;

	private static Dictionary<string, AssetBundle> bundleDict;

	private List<IResourcesLoader> asyncLoaderList;

	public static readonly string CDNUrl;

	public static readonly string RootDir;

	public static readonly string persistentDataPath;

	public static readonly string streamingAssetsPath;

	public static readonly string PlatformType;

	public static readonly string VersionInfoFile;

	public static readonly string ResourceInfoFile;

	public static readonly string RelationInfoFile;

	public static readonly string RelationPathDir;

	public static readonly string MainMenu_HeroResource;

	public readonly int DownloadRetryCount;

	private VersionInfo versionInfo;

	public LocalResourceInfo localResourceInfo;

	public ResourceDownloadHelper resourceDownloadHelper;

	public ResourceCheckHelper resourceCheckHelper;

	public ResourceLoadHelper resourceLoadHelper;

	public Action<BundleGroup, bool> OnDownloadBundleGroupComplete;

	public static Dictionary<string, GameObject> mapObjDictionary;

	public static LevelAssets CurrentLevelAssets;

	public static ResourceManager Instance => null;

	public Dictionary<string, BundleGroup> bundleGroups => null;

	private Dictionary<string, AssetInfo> assetInfos => null;

	public Dictionary<string, BundleInfo> bundleInfos { get; private set; }

	public string GameVersion => null;

	public string ResourceVersion => null;

	public int GroupCount => 0;

	public int AssetCount => 0;

	public int BundleCount => 0;

	public ResourceMode CurrentResMode { get; private set; }

	private ResourceManager()
	{
	}

	public static void LoadAtlas(int windowId)
	{
	}

	public static void UnloadAtlas(int windowId)
	{
	}

	public static DxxSpriteAtlas GetAtlas(string name)
	{
		return null;
	}

	public void AddAtlas(string name, DxxSpriteAtlas atlas)
	{
	}

	public void RemoveAtlas(string name)
	{
	}

	public static void GetAtlasAsync(string name, Action<DxxSpriteAtlas> onComplete)
	{
	}

	private static void ChcekReleaseAtlas(bool bForce = false)
	{
	}

	public static void UnloadUnusedAssets()
	{
	}

	public static void ForceReleaseAtlas(string name)
	{
	}

	public static void ReleaseAtlases()
	{
	}

	public static void ReleaseCache()
	{
	}

	public static void Log(string msg)
	{
	}

	public static DxxSpriteAtlas GetMapAtlas(string name)
	{
		return null;
	}

	public static DxxAnimationAsset GetAniAsset(string name)
	{
		return null;
	}

	public static void ReleaseAniAsset(string name, DxxAnimationAsset.AniType type = DxxAnimationAsset.AniType.Model)
	{
	}

	public static void Init()
	{
	}

	public static T LoadMap<T>(string path) where T : UnityEngine.Object
	{
		return null;
	}

	public static T Load<T>(string path) where T : UnityEngine.Object
	{
		return null;
	}

	public static void RemoveModel(string id)
	{
	}

	public static void Remove(string path)
	{
	}

	public static bool TryLoad<T>(string path, out T t) where T : UnityEngine.Object
	{
		t = null;
		return false;
	}

	public static bool TryLoad(string path)
	{
		return false;
	}

	public static Sprite GetSprite(string atlasName, string spriteName)
	{
		return null;
	}

	public static Sprite GetMapSprite(string atlasName, string spriteName)
	{
		return null;
	}

	public static AnimationClip GetAnimationClip(string aniAssetName, string clipName, DxxAnimationAsset.AniType type = DxxAnimationAsset.AniType.Model)
	{
		return null;
	}

	public static AnimationClip GetAnimationClip(string aniAssetName, string clipName, string subPath, DxxAnimationAsset.AniType type = DxxAnimationAsset.AniType.Model)
	{
		return null;
	}

	public static List<AnimationClip> GetAnimationClips(string aniAssetName, DxxAnimationAsset.AniType type = DxxAnimationAsset.AniType.Model)
	{
		return null;
	}

	public static void UnloadUnusedMap(bool bReleaseMapRes = false, string used = "")
	{
	}

	public static void UnloadAllBattleAssets()
	{
	}

	public static void ClearPool()
	{
	}

	protected static void ClearAnimations()
	{
	}

	protected void ClearMaps()
	{
	}

	protected void RemoveUnusedMap(string used)
	{
	}

	protected static void ClearMapAtlas()
	{
	}

	public static void Release(UnityEngine.Object assetToUnload)
	{
	}

	private static AssetBundle GetAssetBundle(string bundlePath)
	{
		return null;
	}

	public static void UnloadBundleAsset(UnityEngine.Object assetToUnload)
	{
	}

	public static AssetMap.AssetObject GetAssetInfo(string pPathName)
	{
		return null;
	}

	public static string GetRealPath(string pPath)
	{
		return null;
	}

	public static IResourcesLoader LoadAnsyc<T>(string path, Action<T> onLoadComplete) where T : UnityEngine.Object
	{
		return null;
	}

	public void Release(string pPath)
	{
	}

	public void Update()
	{
	}

	static ResourceManager()
	{
	}

	public static string GetStorageCachePath()
	{
		return null;
	}

	public static string GetRemoteVersionFile(string gameVersion)
	{
		return null;
	}

	public static string GetLocalVersionFile()
	{
		return null;
	}

	public static string GetBuildInVersionFile(string platformType)
	{
		return null;
	}

	public static string GetResourceVersionFile(string platformType)
	{
		return null;
	}

	public static string GetRemoteDataPath(string bundleName, string gameVersion, string resourceVersion)
	{
		return null;
	}

	public static string GetLocalDataPath(string bundleName)
	{
		return null;
	}

	public static string GetBuildInDataPath(string platformVersion, string gameVersion, string resourceVersion, string bundleName)
	{
		return null;
	}

	public static string GetLocalRelationPath()
	{
		return null;
	}

	public static string GetLocalRelationDataPath(string assetPath)
	{
		return null;
	}

	public static string GetLocalResourceListFile()
	{
		return null;
	}

	public static string GetBuildInResourceListFile(string platformType, string gameVersion, string resourceVersion)
	{
		return null;
	}

	public static string GetResourceResourceListFile(string platformType)
	{
		return null;
	}

	public static string GetLevelAssetListPath(string levelName)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadBytes_003Ed__96))]
	public static IEnumerator LoadBytes(string filePath, LoadBytesCallback onLoaded)
	{
		return null;
	}

	public void InitManagerAB()
	{
	}

	public void CheckResources()
	{
	}

	public void DeInit()
	{
	}

	public void SetResourceMode(ResourceMode resMode)
	{
	}

	public void LoadAssetAsyn(string name, ResourceLoadHelper.OnLoadAsset onLoadAsset)
	{
	}

	public void LoadBundleGroupAsyn(string groupName, ResourceLoadHelper.OnUserLoadGroup onUserLoadGroup)
	{
	}

	public bool UnloadBundleGroup(string groupName)
	{
		return false;
	}

	public void UpdateBundleInfo(string bundleName, int length, int hashCode)
	{
	}

	public void UpdateValidInfo(string bundleName, bool ifExist, int length, int hashCode)
	{
	}

	public void UpdateLocalInfo(string bundleName, int length, int hashCode)
	{
	}

	public void SaveLocalResourceList()
	{
	}

	public void DownloadBundleGroup(string groupName, Action<BundleGroup, bool> downloadCallback)
	{
	}

	public bool IfHaveBundleGroup(string groupName)
	{
		return false;
	}

	public BundleGroup GetBundleGroup(string groupName)
	{
		return null;
	}

	private void OnBundleDownloadStart(ResourceDownloadHelper.DownloadInfo downloadInfo)
	{
	}

	private void OnBundleDownloading(ResourceDownloadHelper.DownloadInfo downloadInfo, float progress)
	{
	}

	private void OnBundleDownloadSuccess(ResourceDownloadHelper.DownloadInfo downloadInfo)
	{
	}

	private void OnBundleDownloadFail(ResourceDownloadHelper.DownloadInfo downloadInfo, string errorInfo)
	{
	}

	private void OnGroupDownloadComplete(BundleGroup bundleGroup, bool ifSuccess, bool ifAll)
	{
	}

	public void ClearAllCached()
	{
	}

	public static LevelAssets OnLoadLevelInfo(string name, string content)
	{
		return null;
	}

	public static void OnUnloadLevelInfo()
	{
	}

	public static bool OnLoadAtlas(string name, DxxSpriteAtlas atlas)
	{
		return false;
	}

	public static bool OnUnloadAtlas(string name)
	{
		return false;
	}

	public static void OnLoadMapObject(string name, GameObject mapObj)
	{
	}

	public static void OnTransportMapObjects(RoomGenerateBase roomMgr)
	{
	}

	public static void OnUnloadMapObjects()
	{
	}
}
