using System;
using XLua;

namespace RichDialog
{
	public class RichDialogGotoData : IRichDialogData
	{
		public string strDesc;

		public string strBtn;

		public Func<string> countDownGetter;

		public Action callback;

		public long expireTime;

		public Func<bool> btnEnableGetter;

		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
