using UnityEngine;
using XLua;

namespace RichDialog
{
	public class RichDialogItemText : MonoBehaviour, IRichDialogItem
	{
		[SerializeField]
		private DxxText txtText;

		private RichDialogUICtrl ctrl;

		private RichDialogTextData data;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Register;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void SetData(RichDialogTextData data)
		{
		}

		public void Register(RichDialogUICtrl ctrl)
		{
		}

		public void Refresh()
		{
		}
	}
}
