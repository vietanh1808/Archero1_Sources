using UnityEngine;
using XLua;

namespace Activity.Lattice
{
	public class RewardPreviewItem : MonoBehaviour
	{
		[SerializeField]
		private GameObject goTick;

		[SerializeField]
		private GameObject goIconAdd;

		[SerializeField]
		private PropOneEquip prop;

		private int index;

		private static DelegateBridge __Hotfix0_SetIndex;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void SetIndex(int index)
		{
		}

		public void Refresh()
		{
		}
	}
}
