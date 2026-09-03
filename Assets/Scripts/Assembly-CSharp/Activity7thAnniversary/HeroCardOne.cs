using UnityEngine;

namespace Activity7thAnniversary
{
	public class HeroCardOne : SeasonHeroCardOne
	{
		[SerializeField]
		private DxxText mExtraAttrText;

		[SerializeField]
		private DxxText _textTry;

		protected override bool IsUnlock => false;

		protected override bool SelectState => false;

		protected override void OnClickSelectBtn()
		{
		}

		protected override void UpdateUI()
		{
		}

		protected override bool CheckHasCharacter(int id)
		{
			return false;
		}

		private void UpdateExtraAttributeText()
		{
		}

		private string BuildExtraAttributeDescription(string config)
		{
			return null;
		}
	}
}
