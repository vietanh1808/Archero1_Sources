using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Activity.Anniversary;
using DG.Tweening;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using XLua;

namespace Activity.Bingo
{
	public class BingoPanel : PanelBase
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass61_0
		{
			public BingoItem item;

			internal void _003CShowRewards_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowBigReward_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BingoPanel _003C_003E4__this;

			public List<int> bigs;

			public Vector3 normalPos;

			private int _003Ci_003E5__2;

			private BingoLineRewardItem _003Citem_003E5__3;

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
			public _003CShowBigReward_003Ed__62(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CShowRewards_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BingoPanel _003C_003E4__this;

			public int normalIndex;

			public List<Drop_DropModel.DropData> rewards;

			public List<int> bigs;

			private _003C_003Ec__DisplayClass61_0 _003C_003E8__1;

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
			public _003CShowRewards_003Ed__61(int _003C_003E1__state)
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
		private DxxText txtTitle;

		[SerializeField]
		private DxxText txtDesc;

		[SerializeField]
		private DxxText txtRefreshTips;

		[SerializeField]
		private DxxText txtTimeCountdown;

		[SerializeField]
		private DxxText txtBtnDraw;

		[SerializeField]
		private DxxText txtBtnCost;

		[SerializeField]
		private DxxText txtBtnRefresh;

		[SerializeField]
		private DxxText txtKeyCount;

		[SerializeField]
		private DxxText txtLeftTimes;

		[SerializeField]
		private DxxText txtKeyCostFloat;

		[SerializeField]
		private DxxText textTask;

		[SerializeField]
		private ButtonCtrl btnFlip;

		[SerializeField]
		private ButtonCtrl btnNext;

		[SerializeField]
		private ButtonCtrl btnBuyKey;

		[SerializeField]
		private ButtonCtrl btnInfo;

		[SerializeField]
		private ButtonCtrl btnTask;

		[SerializeField]
		private BingoItem bingoItemTemplate;

		[SerializeField]
		private BingoLineRewardItem lineRewardTemplate;

		[SerializeField]
		private GameObject goUseKey;

		[SerializeField]
		private GameObject effectObj;

		[SerializeField]
		private RectTransform rtNormalItemsRoot;

		[SerializeField]
		private RectTransform rtBigRewardsRoot;

		[SerializeField]
		private RectTransform rtInfoRoot;

		[SerializeField]
		private RectTransform rtIconKey;

		[SerializeField]
		private RedNodeCtrl redNodeDraw;

		[SerializeField]
		private RedNodeCtrl redNodeTask;

		[SerializeField]
		private BingoTicketBuyPanel ticketBuyPanel;

		[SerializeField]
		private BingoTaskPanel bingoTaskPanel;

		[SerializeField]
		private InfoPopPanel infoPopPanel;

		private List<BingoItem> normalItems;

		private List<BingoLineRewardItem> lineRewards;

		private LocalUnityObjctPool pool;

		private static readonly Vector3 lineRewardScale;

		private static readonly Vector3 normalRewardScale;

		private const float ITEM_COUNT_HORIZONTAL = 7.5f;

		private const float ITEM_COUNT_VERTICAL = 7f;

		private const float PADDING_MINIMUM = 8f;

		private const int ITEM_COUNT_HORIZONTAL_NORMAL = 5;

		[SerializeField]
		private float left;

		[SerializeField]
		private float top;

		[SerializeField]
		private float space;

		[SerializeField]
		private float edge;

		private float timer;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_OnBtnBuyKeyClick;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_RefreshOnNextLevel;

		private static DelegateBridge __Hotfix0_RefreshButtons;

		private static DelegateBridge __Hotfix1_Refresh;

		private static DelegateBridge __Hotfix0_SetPositions;

		private static DelegateBridge __Hotfix0_GetPosition;

		private static DelegateBridge __Hotfix0_SetNormalItemPositions;

		private static DelegateBridge __Hotfix0_SetBigRewardPositions;

		private static DelegateBridge __Hotfix0_SetInfoPosAndSize;

		private static DelegateBridge __Hotfix0_SetBarPosAndSize;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_Update;

		private static DelegateBridge __Hotfix0_RefreshCountDown;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge __Hotfix0_OnReqDraw;

		private static DelegateBridge __Hotfix0_ShowRewards;

		private static DelegateBridge __Hotfix0_ShowBigReward;

		private static DelegateBridge __Hotfix0_OnReqNext;

		private static DelegateBridge __Hotfix0_UseKey;

		private static DelegateBridge _c__Hotfix0_ctor;

		public override void Init(IActivityUI ctrl)
		{
		}

		private void OnBtnBuyKeyClick()
		{
		}

		public override void Open()
		{
		}

		private void Refresh(bool init)
		{
		}

		private void RefreshOnNextLevel()
		{
		}

		private void RefreshButtons()
		{
		}

		public override void Refresh()
		{
		}

		private void SetPositions()
		{
		}

		private Vector2 GetPosition(float x, float y)
		{
			return default;
		}

		private void SetNormalItemPositions(Sequence sequence)
		{
		}

		private void SetBigRewardPositions(Sequence sequence)
		{
		}

		private void SetInfoPosAndSize(Sequence sequence)
		{
		}

		private void SetBarPosAndSize(Sequence sequence)
		{
		}

		public override void OnLanguageChange()
		{
		}

		private void Update()
		{
		}

		private void RefreshCountDown()
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		private void OnReqDraw()
		{
		}

		[IteratorStateMachine(typeof(_003CShowRewards_003Ed__61))]
		private IEnumerator ShowRewards(int normalIndex, List<int> bigs, List<Drop_DropModel.DropData> rewards)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CShowBigReward_003Ed__62))]
		private IEnumerator ShowBigReward(Vector3 normalPos, List<int> bigs)
		{
			return null;
		}

		private void OnReqNext()
		{
		}

		private void UseKey()
		{
		}

		private void _003C_003ExLuaBaseProxy_Init(IActivityUI P0)
		{
		}

		private void _003C_003ExLuaBaseProxy_Open()
		{
		}

		private void _003C_003ExLuaBaseProxy_Refresh()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnLanguageChange()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
		{
		}
	}
}
