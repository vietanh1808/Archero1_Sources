using UnityEngine;
using XLua;

namespace Activity.Anniversary
{
	public class TDPopSelectItem : MonoBehaviour
	{
		[SerializeField]
		private DxxImage imgIcon;

		[SerializeField]
		private DxxImage imgBase;

		[SerializeField]
		private Sprite spEmpty;

		[SerializeField]
		private Sprite spSelected;

		[SerializeField]
		private ButtonCtrl btn;

		[SerializeField]
		private TDPopPanel panel;

		private int id;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnClick;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Show;

		private static DelegateBridge __Hotfix0_Hide;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void OnClick()
		{
		}

		public void Refresh()
		{
		}

		public void SetData(int id)
		{
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}

		public void Close()
		{
		}
	}
}
