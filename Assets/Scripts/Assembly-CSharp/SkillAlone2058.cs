using System.Collections.Generic;

public class SkillAlone2058 : SkillAloneBase
{
	private class AttrItem
	{
		public long value;

		public long total;

		public long max;

		public long CanUp()
		{
			return 0L;
		}
	}

	private Dictionary<string, AttrItem> m_dicAttrItems;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnLevelUp(int lv)
	{
	}

	private void lvUp()
	{
	}

	private void OnSetCurrentExpLevel(float exp, int level)
	{
	}
}
