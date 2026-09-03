using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity
{
	public class TreasureProgressPop : MonoBehaviour
	{
		[SerializeField]
		private ActivityCommonUICtrl ctrl;

		[SerializeField]
		private TreasurePanel panel;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtContent;

		[SerializeField]
		private DxxText txtTotal;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private UIPopClose popClose;

		[SerializeField]
		private PropOneEquip[] props;

		[SerializeField]
		private Image[] imgTags;

		[SerializeField]
		private RedNodeCtrl[] redNodes;

		[SerializeField]
		private DxxText[] txtProgress;

		private static DelegateBridge __Hotfix0_get_TreasureData;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_OnClickBox;

		private static DelegateBridge _c__Hotfix0_ctor;

		private ActivityTreasureData TreasureData => null;

		private void Awake()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void Refresh()
		{
		}

		private void OnClickBox(int i)
		{
		}
	}
}
