using System.Collections.Generic;
using PureMVC.Patterns;

public class ChooseSkillsOfBossChallengeProxy : Proxy
{
	public class Transfer
	{
		public List<int> GetSkillIds()
		{
			return null;
		}
	}

	public new const string NAME = "ChooseSkillsOfBossChallengeProxy";

	public ChooseSkillsOfBossChallengeProxy(object data)
	{
	}
}
