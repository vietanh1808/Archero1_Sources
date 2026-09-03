using UnityEngine;
using XLua;

namespace RichDialog
{
	public class RichDialogItemInput : MonoBehaviour, IRichDialogItem
	{
		[SerializeField]
		private DxxInput input;

		private RichDialogUICtrl ctrl;

		private RichDialogInputData data;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Register;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_SetValue;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void SetData(RichDialogInputData data)
		{
		}

		public void Register(RichDialogUICtrl ctrl)
		{
		}

		public void Refresh()
		{
		}

		private void SetValue(string value)
		{
		}
	}
}
