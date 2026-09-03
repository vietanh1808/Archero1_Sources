using System;
using XLua;

namespace RichDialog
{
	public class RichDialogInputData : IRichDialogData
	{
		public string strPlaceHolder;

		public Func<string> getter;

		public Action<string> setter;

		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
