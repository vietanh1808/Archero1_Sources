using System;
using XLua;

namespace RichDialog
{
	public class RichDialogSliderData : IRichDialogData
	{
		public bool isInt;

		public bool showButtons;

		public bool autoHide;

		public bool showValue;

		public Func<float> getter;

		public Action<float> setter;

		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
