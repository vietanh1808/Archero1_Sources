using UnityEngine;
using XLua;

namespace Activity
{
	public class TreasureSelectItem : MonoBehaviour
	{
		[SerializeField]
		private PropOneEquip prop;

		[SerializeField]
		private DxxText txtQuota;

		[SerializeField]
		private ButtonCtrl btn;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void SetData(bool isTreasure, int index, TreasureSelectPanel panel)
		{
		}
	}
}
