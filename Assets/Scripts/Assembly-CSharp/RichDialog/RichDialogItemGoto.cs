using UnityEngine;
using XLua;

namespace RichDialog
{
	public class RichDialogItemGoto : MonoBehaviour, IRichDialogItem
	{
		[SerializeField]
		private DxxText txtBtn;

		[SerializeField]
		private DxxText txtDesc;

		[SerializeField]
		private DxxText txtTimeCountdown;

		[SerializeField]
		private ButtonCtrl btn;

		private RichDialogGotoData data;

		private RichDialogUICtrl ctrl;

		private float timer;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Register;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_Update;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void SetData(RichDialogGotoData data)
		{
		}

		public void Register(RichDialogUICtrl ctrl)
		{
		}

		public void Refresh()
		{
		}

		private void Update()
		{
		}
	}
}
