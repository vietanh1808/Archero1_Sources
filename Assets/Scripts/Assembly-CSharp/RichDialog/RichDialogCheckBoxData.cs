using System;
using XLua;

namespace RichDialog
{
	public class RichDialogCheckBoxData : IRichDialogData
	{
		public string strTitle;

		public bool showTitle;

		public Func<bool> getter;

		public Action<bool> setter;

		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
