using System.Collections.Generic;
using UnityEngine;

namespace Activity.Christmas
{
	public class ChristmasSignInTaskItem : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtBtnGet;

		[SerializeField]
		private DxxText txtClaimed;

		[SerializeField]
		private ButtonCtrl btnGet;

		[SerializeField]
		private RectTransform rtContentRoot;

		private ChristmasRewardItem data;

		private LocalUnityObjctPool pool;

		private List<PropOneEquip> list;

		private ActivityChristmasMgr instance => null;

		public void SetData(ChristmasRewardItem data, LocalUnityObjctPool pool)
		{
		}

		private void OnGetClick()
		{
		}

		private void Refresh()
		{
		}
	}
}
