using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

namespace ActivityConsumeCommon
{
	public class ActConsumeCommonUICtrl : MediatorCtrlBase
	{
		[SerializeField]
		private ButtonCtrl btn_close;

		[SerializeField]
		private ConTabBtnPair[] tabBtnPairs;

		[SerializeField]
		private ConTabPanel[] tabPanels;

		[SerializeField]
		private Transform goPanelsRoot;

		[SerializeField]
		private DxxText txt_btnDiamond;

		[SerializeField]
		private DxxText txt_btnLife;

		[SerializeField]
		private DxxText txt_btnBox25;

		[SerializeField]
		private DxxText txt_btnBox41;

		[SerializeField]
		private DxxText txt_btnBox42;

		[SerializeField]
		private DxxText txt_btnBox43;

		[SerializeField]
		private DxxText txt_btnBox44;

		[SerializeField]
		private DxxText txt_btnBox45;

		[SerializeField]
		private DxxText txt_btnBox46;

		[SerializeField]
		private DxxText txt_btnBox47;

		[SerializeField]
		private RedNodeCtrl[] redNodes;

		[SerializeField]
		private DxxImage image_Rigft;

		[SerializeField]
		private DxxImage image_Left;

		[SerializeField]
		private ScrollRectBase scroll_Bottom;

		private ConsumeTab crtTab;

		private ConsumePanelBase crtPanel;

		private Dictionary<ConsumeTab, ConsumePanelBase> openPanelsDir;

		public virtual WindowID windowID => WindowID.WindowID_Invaild;

		protected override void OnInit()
		{
		}

		protected override void OnOpen()
		{
		}

		private void RegisterUICallbacks()
		{
		}

		private void SelectPanel(ConsumeTab tab)
		{
		}

		public bool IsPanelOpen(ConsumeTab tab)
		{
			return false;
		}

		protected override void OnClose()
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		public void RefreshRedNode()
		{
		}

		public override void OnLanguageChange()
		{
		}
	}
}
