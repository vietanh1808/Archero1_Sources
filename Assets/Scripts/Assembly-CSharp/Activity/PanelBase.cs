using PureMVC.Interfaces;
using UnityEngine;
using XLua;

namespace Activity
{
	public class PanelBase : MonoBehaviour
	{
		protected IActivityUI ctrl;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_Escape;

		private static DelegateBridge __Hotfix0_OnGetEvent;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge _c__Hotfix0_ctor;

		public virtual void Open()
		{
		}

		public virtual void Close()
		{
		}

		public virtual void Init(IActivityUI ctrl)
		{
		}

		public virtual void Refresh()
		{
		}

		public virtual void OnLanguageChange()
		{
		}

		public virtual bool Escape()
		{
			return false;
		}

		public virtual void OnGetEvent(string eventName)
		{
		}

		public virtual void OnHandleNotification(INotification notification)
		{
		}
	}
}
