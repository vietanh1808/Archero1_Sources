using System;
using System.Collections.Generic;
using System.IO;

[Serializable]
public sealed class VersionInfo
{
	public bool IfUpdatable;

	public bool IfEncryption;

	public byte EncrypationKey;

	public string GameVersion;

	public string ResourceVersion;

	public int GroupCounts;

	public int AssetCounts;

	public Dictionary<string, ResourceManager.BundleGroup> BundleGroups;

	public Dictionary<string, ResourceManager.AssetInfo> AssetInfos;

	public Dictionary<string, string[]> BundleDependencys;

	public void AppendLoadedData(ResourceManager resMgr)
	{
	}

	public static void WriteToFile(string path, VersionInfo versionInfo)
	{
	}

	public static bool ReadFromFile(string path, out VersionInfo versionInfo)
	{
		versionInfo = null;
		return false;
	}

	public static bool ReadFromStream(Stream stream, out VersionInfo versionInfo)
	{
		versionInfo = null;
		return false;
	}

	public static bool ReadFromBytes(byte[] bytes, out VersionInfo versionInfo)
	{
		versionInfo = null;
		return false;
	}

	public void Clear()
	{
	}

	public string GetAllInfo()
	{
		return null;
	}
}
