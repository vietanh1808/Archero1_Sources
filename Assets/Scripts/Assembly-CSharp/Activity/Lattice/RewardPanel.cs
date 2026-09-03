using UnityEngine;
using XLua;

namespace Activity.Lattice
{
	public class RewardPanel : MonoBehaviour
	{
		[SerializeField]
		private GameObject goTabSelectOn;

		[SerializeField]
		private GameObject goTabSelectOff;

		[SerializeField]
		private GameObject goTabPreviewOn;

		[SerializeField]
		private GameObject goTabPreviewOff;

		[SerializeField]
		private RewardPreviewTab tabPreview;

		[SerializeField]
		private RewardSelectTab tabSelect;

		[SerializeField]
		private DxxText txtTabSelectOn;

		[SerializeField]
		private DxxText txtTabSelectOff;

		[SerializeField]
		private DxxText txtTabPreviewOn;

		[SerializeField]
		private DxxText txtTabPreviewOff;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private ButtonCtrl btnBg;

		[SerializeField]
		private ButtonCtrl btnTabSelect;

		[SerializeField]
		private ButtonCtrl btnTabPreview;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_SetTab;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		public void Close()
		{
		}

		public void Open()
		{
		}

		private void SetTab(bool isSelect)
		{
		}
	}
}
