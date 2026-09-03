using UnityEngine;
using UnityEngine.UI;

namespace Activity.WorldCup
{
	public class RedeemWorldCupPanel : PanelBase
	{
		[SerializeField]
		private DxxText txtTime;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtDesc;

		[SerializeField]
		private DxxText txtTitleRare;

		[SerializeField]
		private DxxText txtItemCount1;

		[SerializeField]
		private DxxText txtItemCount2;

		[SerializeField]
		private ButtonCtrl btnTip;

		[SerializeField]
		private ShrinkDxxText txtDesc2;

		[SerializeField]
		private GameObject template;

		[SerializeField]
		private RectTransform rtRare;

		[SerializeField]
		private RectTransform rtNormal;

		[SerializeField]
		private ScrollRect sr;

		private LocalUnityObjctPool pool;

		private void Awake()
		{
		}

		public override void Open()
		{
		}

		public new void Refresh()
		{
		}

		public override void Close()
		{
		}

		public override void OnLanguageChange()
		{
		}
	}
}
