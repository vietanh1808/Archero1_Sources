namespace Activity7thAnniversary
{
	public class Activity7thAnniversaryChooseHeroUICtrl : SeasonChooseHeroUICtrl
	{
		private Activity7thAnniversaryMgr _mgr;

		protected override WindowID WindowID => WindowID.WindowID_Invaild;

		protected override int[] HeroIds => null;

		protected override int SelectedHero => 0;

		protected override void OnInit()
		{
		}

		protected override void OnClick(SeasonHeroCardOne card)
		{
		}

		protected override void UpdateUI()
		{
		}

		public override void OnLanguageChange()
		{
		}
	}
}
