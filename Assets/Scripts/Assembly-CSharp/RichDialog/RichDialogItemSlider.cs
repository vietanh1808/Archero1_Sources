using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace RichDialog
{
	public class RichDialogItemSlider : MonoBehaviour, IRichDialogItem
	{
		[SerializeField]
		private DxxText txtValue;

		[SerializeField]
		private ButtonCtrl btnAdd;

		[SerializeField]
		private ButtonCtrl btnSub;

		[SerializeField]
		private Slider slider;

		private RichDialogSliderData data;

		private RichDialogUICtrl ctrl;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_RefreshValue;

		private static DelegateBridge __Hotfix0_RefreshButtons;

		private static DelegateBridge __Hotfix0_OnSetValue;

		private static DelegateBridge __Hotfix0_Register;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		public void SetData(RichDialogSliderData data)
		{
		}

		private void RefreshValue()
		{
		}

		private void RefreshButtons()
		{
		}

		private void OnSetValue(float value)
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
