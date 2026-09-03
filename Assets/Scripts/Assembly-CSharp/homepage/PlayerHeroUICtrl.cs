using UnityEngine;

namespace homepage
{
	public class PlayerHeroUICtrl : MediatorCtrlBase
	{
		public ButtonCtrl btn_close;

		public ButtonCtrl btn_ok;

		public DxxText txt_title;

		public DxxText txt_info;

		public ScrollRectBase HeroListScrollRect;

		public RectTransform HeroListContentTrans;

		public GameObject HeroListItemPrefab;

		public DxxText txt_ok;

		public HeroVO heroVO;

		public override void OnLanguageChange()
		{
		}

		protected override void OnInit()
		{
		}

		protected override void OnOpen()
		{
		}

		private void android_escape()
		{
		}

		private void onClose()
		{
		}

		private void initHeroList()
		{
		}

		private void createHeroListItem(HeroListItemVO itemVO)
		{
		}
	}
}
