using System.Collections.Generic;
using System.IO;

namespace Habby.AssetExpress.IO
{
	public class FileHelper
	{
		public static bool CopyFile(string src, string dest, bool overwrite = false)
		{
			return false;
		}

		public static int GetAllFileSize(string filePath)
		{
			return 0;
		}

		public static long GetFileSize(string file_path)
		{
			return 0L;
		}

		public static void CopyAndDeleteFiles(DirectoryInfo source, DirectoryInfo target, List<string> files)
		{
		}

		public static bool CopyAll(DirectoryInfo source, DirectoryInfo target)
		{
			return false;
		}

		public static void CopyAllAsync(DirectoryInfo source, DirectoryInfo target)
		{
		}

		public static void RemoveDir(string path)
		{
		}

		public static void RemoveDir(DirectoryInfo dir)
		{
		}

		public static void PurgeContents(string path)
		{
		}

		public static void PurgeContents(DirectoryInfo dir)
		{
		}

		public static void MakeDir(string path)
		{
		}
	}
}
