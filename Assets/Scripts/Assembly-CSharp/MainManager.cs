using System.Collections.Generic;

public class MainManager : CInstance<MainManager>
{
	public bool EnableExecuteWrapper;

	public List<string> tagList;

	public bool HasNewlockedChapter { get; set; }

	public void Initialize()
	{
	}

	public bool OnlyKeepOutsidePercentAttr()
	{
		return false;
	}

	public void ExecuteWrapper(SelfAttributeData selfAttribute, string attrStr, string tag = "[ExecuteWrapper]", bool showAttrLog = false)
	{
	}

	private void executeInternal(SelfAttributeData selfAttribute, string attrStr, string tag, bool showAttrLog)
	{
	}
}
