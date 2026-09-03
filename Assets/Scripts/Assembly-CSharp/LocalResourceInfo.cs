using System;
using System.Collections.Generic;
using System.IO;

[Serializable]
public class LocalResourceInfo
{
	[Serializable]
	public class LocalBundleInfo
	{
		public int Length;

		public int HashCode;

		public string BundleName;
	}

	public Dictionary<string, LocalBundleInfo> LocalResources;

	public int LocalResourceCount => 0;

	public void AddLocalInfo(string bundleName, int length, int hashCode)
	{
	}

	public void Clear()
	{
	}

	public static void WriteToFile(string path, LocalResourceInfo resInfo)
	{
	}

	public static bool ReadFromFile(string path, out LocalResourceInfo resInfo)
	{
		resInfo = null;
		return false;
	}

	public static bool ReadFromStream(Stream stream, out LocalResourceInfo resInfo)
	{
		resInfo = null;
		return false;
	}

	public static bool ReadFromBytes(byte[] bytes, out LocalResourceInfo resInfo)
	{
		resInfo = null;
		return false;
	}

	public string GetAllInfo()
	{
		return null;
	}
}
