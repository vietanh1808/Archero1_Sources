using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity
{
	public class BPDetailPanel : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTick_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BPDetailPanel _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CTick_003Ed__51(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private DxxText txtPurchasePrice;

		[SerializeField]
		private DxxText txtRewardUnlocked;

		[SerializeField]
		private DxxText txtRewardTotal;

		[SerializeField]
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtDiamondPrice;

		[SerializeField]
		private DxxText txtCritContent;

		[SerializeField]
		private DxxText txtCritValue;

		[SerializeField]
		private DxxText txtCountDown;

		[SerializeField]
		private GameObject goTemplate;

		[SerializeField]
		private GameObject goImgCheckIn;

		[SerializeField]
		private GameObject goImgActive;

		[SerializeField]
		private GameObject goPurchase;

		[SerializeField]
		private GameObject goDiamondPrice;

		[SerializeField]
		private RectTransform unlockedRoot;

		[SerializeField]
		private RectTransform totalRoot;

		[SerializeField]
		private ScrollRect sr1;

		[SerializeField]
		private ScrollRect sr2;

		[SerializeField]
		private ButtonCtrl btnBuy;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private DxxImage imgBg;

		[SerializeField]
		private DxxImage imgNormalRewardBg;

		[SerializeField]
		private DxxImage imgPremiumRewardBg;

		[SerializeField]
		private DxxImage imgIcon;

		[SerializeField]
		private StarDiamondItem starItem;

		private LocalUnityObjctPool pool;

		private string productId;

		private ushort type;

		private ActivityMgr.Event eventType;

		private BPPanelStyle style;

		private const string STEP_DIAMOND = "diamond";

		private const string STEP_MONEY = "money";

		private const string STEP_STARDIAMOND = "Star_diamond";

		private const string RESULT_SUCCESS = "success";

		private const string RESULT_FAIL = "fail";

		public VIPFlagItem vipItem;

		public ButtonCtrl Button_Star;

		public DxxText Text_Star;

		private float m_fTime;

		private const int TimeInterval = 5;

		private bool updatingInfo;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_onButtonDiamond;

		private static DelegateBridge __Hotfix0_onButtonStar;

		private static DelegateBridge __Hotfix0_DCDiamond;

		private static DelegateBridge __Hotfix0_DCPurchase;

		private static DelegateBridge __Hotfix0_DCStarDiamond;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_SetStyle;

		private static DelegateBridge __Hotfix0_checkBuy;

		private static DelegateBridge __Hotfix0_purchaseCallback;

		private static DelegateBridge __Hotfix0_Tick;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void onButtonDiamond()
		{
		}

		private void onButtonStar()
		{
		}

		private void DCDiamond(string result)
		{
		}

		private void DCPurchase(string result)
		{
		}

		private void DCStarDiamond(string result)
		{
		}

		public void Close()
		{
		}

		internal void Open(ushort type, BPPanelStyle style)
		{
		}

		private void SetStyle()
		{
		}

		private bool checkBuy()
		{
			return false;
		}

		private void purchaseCallback(CRespInAppPurchase data, bool success)
		{
		}

		[IteratorStateMachine(typeof(_003CTick_003Ed__51))]
		private IEnumerator Tick()
		{
			return null;
		}
	}
}
