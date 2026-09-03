using TableTool;
using UnityEngine;
using XLua;

namespace Activity.Lattice
{
	public class RewardSelectItem : MonoBehaviour
	{
		[SerializeField]
		private PropOneEquip prop;

		[SerializeField]
		private GameObject goGot;

		[SerializeField]
		private GameObject goSelected;

		[SerializeField]
		private ButtonCtrl btn;

		private RewardSelectTab _tab;

		private int index;

		private static DelegateBridge __Hotfix0_get_isGot;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_OnClick;

		private static DelegateBridge _c__Hotfix0_ctor;

		private bool isGot => false;

		private void Awake()
		{
		}

		public void SetData(int index, Drop_DropModel.DropData dropData, RewardSelectTab tab)
		{
		}

		public void Refresh()
		{
		}

		public void OnClick()
		{
		}
	}
}
