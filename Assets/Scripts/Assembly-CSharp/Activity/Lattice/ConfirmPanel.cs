using System;
using UnityEngine;
using XLua;

namespace Activity.Lattice
{
	public class ConfirmPanel : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtContent;

		[SerializeField]
		private DxxText txtBtnConfirm;

		[SerializeField]
		private DxxText txtBtnCancel;

		[SerializeField]
		private ButtonCtrl btnConfirm;

		[SerializeField]
		private ButtonCtrl btnCancel;

		private Action onConfirm;

		private Action onCancel;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_OnEnable;

		private static DelegateBridge __Hotfix0_OnDisable;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		public void Open(string txt, Action onConfirm, Action onCancel)
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
