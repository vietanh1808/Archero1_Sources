using UnityEngine;
using XLua;

namespace RichDialog
{
	public class RichDialogItemCheckBox : MonoBehaviour, IRichDialogItem
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private ButtonCtrl btnCheckBox;

		[SerializeField]
		private GameObject goTick;

		private RichDialogUICtrl ctrl;

		private RichDialogCheckBoxData data;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Register;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_SetValue;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void SetData(RichDialogCheckBoxData data)
		{
		}

		public void Register(RichDialogUICtrl ctrl)
		{
		}

		public void Refresh()
		{
		}

		private void SetValue(bool value)
		{
		}
	}
}
