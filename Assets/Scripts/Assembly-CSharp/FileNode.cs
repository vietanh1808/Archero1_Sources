using System.Collections.Generic;

public class FileNode
{
	public string Name;

	public string FullPath;

	public bool IsFolder;

	public long Size;

	public List<FileNode> Children;
}
