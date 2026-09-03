using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace Activity.Anniversary
{
	public class CheckInItem : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtContent;

		[SerializeField]
		private DxxText txtBtnClaim;

		[SerializeField]
		private GameObject goTick;

		[SerializeField]
		private ButtonCtrl btn;

		[SerializeField]
		private RectTransform rtContentRoot;

		private List<PropOneEquip> items;

		private int index;

		private LocalUnityObjctPool pool;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnClick;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void OnClick()
		{
		}

		public void SetData(int index, LocalUnityObjctPool pool)
		{
		}

		private void Refresh()
		{
		}
	}
}
