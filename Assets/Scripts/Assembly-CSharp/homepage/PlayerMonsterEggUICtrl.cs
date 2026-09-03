using UnityEngine;

namespace homepage
{
	public class PlayerMonsterEggUICtrl : MediatorCtrlBase
	{
		public ButtonCtrl btn_close;

		public ButtonCtrl btn_ok;

		public DxxText txt_title;

		public DxxText txt_info;

		public DxxText txt_empty_tip;

		public ScrollRectBase MonsterListScrollRect;

		public RectTransform MonsterListContentTrans;

		public GameObject MonsterListItemPrefab;

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

		private void initMonsterList()
		{
		}

		private void createMonsterListItem(MonsterListItemVO itemVO)
		{
		}
	}
}
