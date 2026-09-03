using TableTool;
using UnityEngine;
using XLua;

namespace Activity.Lattice
{
	public class RewardPreviewTab : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtInfo;

		[SerializeField]
		private RectTransform rtContentRoot;

		[SerializeField]
		private PropOneEquip template;

		private PropOneEquip[] items;

		private Drop_DropModel.DropData[] rewards;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_CreateReward;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void Open()
		{
		}

		private PropOneEquip CreateReward(int i)
		{
			return null;
		}

		public void Close()
		{
		}
	}
}
