using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

namespace Activity.WorldCup
{
	public class ActivityWorldCupUICtrl : MediatorCtrlBase, IActivityUI
	{
		private const int Prop33006ID = 33006;

		private const int Prop33007ID = 33007;

		[SerializeField]
		private DxxText txtBtnTabTask;

		[SerializeField]
		private DxxText txtBtnTabBet;

		[SerializeField]
		private DxxText txtBtnRedeem;

		[SerializeField]
		private DxxText txtBtnChampBet;

		[SerializeField]
		private DxxText txtPopTitle;

		[SerializeField]
		private DxxText txtPopContent;

		[SerializeField]
		private DxxText txtDiamond;

		[SerializeField]
		private DxxText txt33006;

		[SerializeField]
		private DxxText txt33007;

		[SerializeField]
		private DxxText txtBtnTabChampBet;

		[SerializeField]
		private DxxText txtBtnClosePop;

		[SerializeField]
		private DxxText txtBtnRectord;

		[SerializeField]
		private DxxImage _imgAdd33006;

		[SerializeField]
		private DxxImage _imgAdd33007;

		[SerializeField]
		protected RectTransform rcFringeRoot;

		[SerializeField]
		protected RectTransform rcBg;

		[SerializeField]
		protected RectTransform rcMaterials;

		[SerializeField]
		protected GameObject goPanelsRoot;

		[SerializeField]
		protected GameObject goTabBtnRoot;

		public GameObject goPop;

		[SerializeField]
		protected TabPanelPair[] tabPanelPairs;

		[SerializeField]
		protected TabBtnPair[] tabBtnPairs;

		[SerializeField]
		protected ButtonCtrl btnClose;

		[SerializeField]
		protected RedNodeCtrl[] redNodes;

		[SerializeField]
		private GameObjectActivator activator;

		[SerializeField]
		private ButtonCtrl btnClosePop;

		[SerializeField]
		private ButtonCtrl btn33006;

		[SerializeField]
		private ButtonCtrl btn33007;

		[SerializeField]
		private RecordPage recordPage;

		[SerializeField]
		private ButtonCtrl btnRecord;

		[SerializeField]
		private RedNodeCtrl redNodeReward;

		private PanelBase curPanel;

		private List<Tab> openTabs;

		private WindowID windowID => WindowID.WindowID_Invaild;

		WindowID IActivityUI.windowID => WindowID.WindowID_Invaild;

		protected override void OnInit()
		{
		}

		private void RegisterCallbacks()
		{
		}

		private void BuyProp(int id)
		{
		}

		private void FixPanelRect()
		{
		}

		private void InitPanels()
		{
		}

		protected override void OnOpen()
		{
		}

		protected override void OnClose()
		{
		}

		private void android_escape()
		{
		}

		public void SetOpenTabs()
		{
		}

		public void OpenPopPanel(string title, string content, Action onClose)
		{
		}

		public void SetGlobalButtons(bool enabled)
		{
		}

		public void RefreshUI()
		{
		}

		private void RefreshRedNode()
		{
		}

		private void UpdateCurrency()
		{
		}

		private void ShowTabButtons()
		{
		}

		private bool IsFirstOpenToday()
		{
			return false;
		}

		private void ShowPanel()
		{
		}

		private void ShowRedNode()
		{
		}

		public void SetStyle(ActivityMgr.Event curEvent)
		{
		}

		public void SelectPanel(Tab tab, object arg = null)
		{
		}

		public override void OnLanguageChange()
		{
		}

		public RectTransform GetPanelRoot()
		{
			return null;
		}

		public T GetPop<T>(string path) where T : Component
		{
			return null;
		}

		public override void OnHandleNotification(INotification notification)
		{
		}
	}
}
