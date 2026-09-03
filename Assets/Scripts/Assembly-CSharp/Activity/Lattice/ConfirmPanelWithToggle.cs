using System;
using UnityEngine;
using XLua;

namespace Activity.Lattice
{
	public class ConfirmPanelWithToggle : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtContent;

		[SerializeField]
		private DxxText txtSkipTip;

		[SerializeField]
		private DxxText txtBtnConfirm;

		[SerializeField]
		private GameObject goTick;

		[SerializeField]
		private ButtonCtrl btnTick;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private ButtonCtrl btnConfirm;

		private Action callback;

		private bool isSelected;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_OnEnable;

		private static DelegateBridge __Hotfix0_OnDisable;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		public void Open(Action callback)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Close()
		{
		}
	}
}
