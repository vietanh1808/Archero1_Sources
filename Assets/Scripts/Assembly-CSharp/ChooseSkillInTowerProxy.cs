using System.Collections.Generic;
using PureMVC.Patterns;

public class ChooseSkillInTowerProxy : Proxy
{
	public class Transfer
	{
		public List<int> ids;

		public int num;

		public (List<int>, int) GetDatas()
		{
			return default;
		}

		private (List<int>, int) GetSlotIdDatas()
		{
			return default;
		}
	}

	public new const string NAME = "ChooseSkillInTowerProxy";

	public ChooseSkillInTowerProxy(object data)
	{
	}
}
