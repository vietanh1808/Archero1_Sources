using System.Collections.Generic;

namespace TableTool
{
	public class Box_ChapterHeroBoxModel : LocalModel<Box_ChapterHeroBox, int>
	{
		private const string _Filename = "Box_ChapterHeroBox";

		private int mMaxID;

		protected override string Filename => null;

		protected override int GetBeanKey(Box_ChapterHeroBox bean)
		{
			return 0;
		}

		public List<Drop_DropModel.DropData> GetDrops(int id)
		{
			return null;
		}

		public int GetNextLevel(int id)
		{
			return 0;
		}

		public int GetOpenCount(int currentlayer, int openedcount)
		{
			return 0;
		}

		private void InitMaxID()
		{
		}

		public List<Box_ChapterHeroBox> GetCurrentList()
		{
			return null;
		}

		public Box_ChapterHeroBox GetNext(int id)
		{
			return null;
		}
	}
}
