using System.Collections.Generic;

namespace TableTool
{
	public class PlayerCharacter_CharacterModel : LocalModel<PlayerCharacter_Character, int>
	{
		private const string _Filename = "PlayerCharacter_Character";

		protected override string Filename => null;

		protected override int GetBeanKey(PlayerCharacter_Character bean)
		{
			return 0;
		}

		public int GetRedCount()
		{
			return 0;
		}

		public bool GetCanGet(PlayerCharacter_Character data)
		{
			return false;
		}

		public List<PlayerCharacter_Character> GetSortList()
		{
			return null;
		}
	}
}
