using PureMVC.Interfaces;
using UnityEngine.UI;

namespace homepage
{
	public class PlayerHomePageUI : MediatorCtrlBase
	{
		public DxxText txt_title;

		public HeadItemOne headItem;

		public DxxText txt_id;

		public DxxRtlText txt_name;

		public HomePageCharUICtrl CharUICtrl;

		public Image stage_Icon;

		public DxxText txt_stage;

		public DxxText txt_hero;

		public DxxText txt_monster;

		public ButtonCtrl btn_stage;

		public ButtonCtrl btn_hero;

		public ButtonCtrl btn_monster;

		public ButtonCtrl btn_close;

		private HeroVO heroVO;

		public MedalItem medalItem;

		public HeroAssistLine heroLine;

		public PetShowItem petShow;

		public ImprintLevelShowItem imprintItem;

		public override void OnLanguageChange()
		{
		}

		protected override void OnInit()
		{
		}

		protected override void OnSetArgs(object o)
		{
		}

		protected override void OnOpen()
		{
		}

		private void android_escape()
		{
		}

		protected override void OnClose()
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		public override object OnGetEvent(string eventName)
		{
			return null;
		}

		public void freshStageInfo()
		{
		}
	}
}
