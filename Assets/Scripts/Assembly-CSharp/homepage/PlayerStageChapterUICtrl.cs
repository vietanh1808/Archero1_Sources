using UnityEngine;
using UnityEngine.UI;

namespace homepage
{
	public class PlayerStageChapterUICtrl : MediatorCtrlBase
	{
		public ButtonCtrl btn_close;

		public ButtonCtrl btn_ok;

		public DxxText txt_title;

		public DxxText txt_info;

		public ScrollRectBase StageChapterListScrollRect;

		public RectTransform StageChapterListContentTrans;

		public GameObject StageChapterListItemPrefab;

		public DxxText txt_ok;

		public HeroVO heroVO;

		public Dropdown dropDown;

		public GameObject hellFrame;

		private int chooseStageIndex;

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

		private void initStageChapterList()
		{
		}

		private void createStageChapterListItem(StageChapterListItemVO itemVO)
		{
		}

		public void onDropDownValueChanged()
		{
		}

		private void freshStageContent()
		{
		}
	}
}
