using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace RichDialog
{
	public class RichDialogUICtrl : MediatorCtrlBase
	{
		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private RichDialogItemGoto itemGotoPrefab;

		[SerializeField]
		private RichDialogItemCheckBox itemCheckBoxPrefab;

		[SerializeField]
		private RichDialogItemText itemTextPrefab;

		[SerializeField]
		private RichDialogItemSlider itemSliderPrefab;

		[SerializeField]
		private RichDialogItemSpace itemSpacePrefab;

		[SerializeField]
		private RectTransform rtItemsRoot;

		private List<IRichDialogItem> list;

		private static DelegateBridge __Hotfix0_OnInit;

		private static DelegateBridge __Hotfix0_OnOpen;

		private static DelegateBridge __Hotfix0_RefreshItems;

		private static DelegateBridge __Hotfix0_OnClose;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge _c__Hotfix0_ctor;

		protected override void OnInit()
		{
		}

		protected override void OnOpen()
		{
		}

		public void RefreshItems()
		{
		}

		protected override void OnClose()
		{
		}

		public override void OnLanguageChange()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnInit()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnOpen()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnClose()
		{
		}
	}
}
