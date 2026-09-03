using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactAppraisaUIPanel : MediatorCtrlBase
{
	public enum EffectEnum
	{
		ChargingSmall = 0,
		ChargingSmallFailed = 1,
		ChargingSmallSuccess = 2,
		ChargingSuper = 3,
		ChargingSuperFailed = 4,
		ChargingSuperSuccess = 5,
		OpenBlue = 6,
		OpenGolden = 7
	}

	private class TimeLineActiveBox : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public ArtifactAppraisaManager.BoxNet net;

			internal bool _003CDo_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDo_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

			public TimeLineActiveBox _003C_003E4__this;

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
			public _003CDo_003Ed__2(int _003C_003E1__state)
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

		private ArtifactAppraisaUIPanel mCtrl;

		public TimeLineActiveBox(ArtifactAppraisaUIPanel mCtrl)
		{
		}

		[IteratorStateMachine(typeof(_003CDo_003Ed__2))]
		private IEnumerator Do()
		{
			return null;
		}
	}

	private class TimeLineOpenBox : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public ArtifactAppraisaManager.BoxNet net;

			internal bool _003CDo_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDo_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineOpenBox _003C_003E4__this;

			private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

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
			public _003CDo_003Ed__2(int _003C_003E1__state)
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

		private ArtifactAppraisaUIPanel mCtrl;

		public TimeLineOpenBox(ArtifactAppraisaUIPanel mCtrl)
		{
		}

		[IteratorStateMachine(typeof(_003CDo_003Ed__2))]
		private IEnumerator Do()
		{
			return null;
		}
	}

	private class TimeLineUpBox : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public ArtifactAppraisaManager.UpBoxNet net;

			internal bool _003CDo_003Eb__0()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDo_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineUpBox _003C_003E4__this;

			private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

			private bool _003CisBig_003E5__2;

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
			public _003CDo_003Ed__3(int _003C_003E1__state)
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

		private ArtifactAppraisaUIPanel mCtrl;

		private bool mIsAuto;

		public TimeLineUpBox(ArtifactAppraisaUIPanel mCtrl, bool isAuto)
		{
		}

		[IteratorStateMachine(typeof(_003CDo_003Ed__3))]
		private IEnumerator Do()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CPlayCountChange_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Text NumTex;

		public int num_2;

		private float _003Coffset_003E5__2;

		private float _003Cstep_003E5__3;

		private float _003Cresult_003E5__4;

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
		public _003CPlayCountChange_003Ed__92(int _003C_003E1__state)
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

	public DxxText titleTex;

	public DxxText timeText;

	public DxxText keyNumText;

	public DxxText taskBtnText;

	public DxxText giftBtnText;

	public DxxText previewBtnText;

	public DxxText openBtnText;

	public DxxText needKeyText;

	public DxxText UpBtnText;

	public DxxText autoBtnText;

	public DxxText autoText;

	public DxxText autoDescText;

	public DxxText previewText;

	public DxxText leftUpText;

	public DxxText shopBtnText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl infoBtn;

	public ButtonCtrl taskBtn;

	public ButtonCtrl giftBtn;

	public ButtonCtrl previewBtn;

	public ButtonCtrl openBtn;

	public ButtonCtrl upBtn;

	public ButtonCtrl autoBtn;

	public ButtonCtrl quickBuyBtn;

	public ButtonCtrl shopBtn;

	public ArtifactAppraisaPreviewPanel artifactAppraisaPreviewPanel;

	public ArtifactAppraisaAutoPanel artifactAppraisaAutoPanel;

	public GameObject buttonsObj;

	public GameObject autoObj;

	public Transform boxTabsParent;

	public Transform previewItemsParent;

	public ArtifactApprasaPreviewRewardItem copyPreviewItemObj;

	public ArtifactAppraseBoxTab copyBoxTabOne;

	public Image boxImg;

	public Image matIcon;

	public Image matIcon2;

	public Transform autoIcon;

	public Animator ani;

	public Transform effectParent;

	public DxxText mat1NumTex;

	public DxxText mat2NumTex;

	public DxxText diamondNumTex;

	public RedNodeCtrl taskNode;

	public RedNodeCtrl giftNode;

	public RedNodeCtrl openNode;

	public RedNodeCtrl shopNode;

	[SerializeField]
	private Image Image_ShopPropA;

	[SerializeField]
	private Image Image_ShopPropB;

	public GameObject repreviewObj;

	private TimeLineContainer timeLine;

	private ArtifactAppraseBoxTab[] boxTabs;

	private List<ArtifactApprasaPreviewRewardItem> previewRewardItems;

	[HideInInspector]
	public bool isAutoing;

	[HideInInspector]
	public int AutoTargetGear;

	private bool isPlaying;

	private int nodeCount;

	private const string guideKey = "ArtifactAppraisaGuide";

	protected override void OnInit()
	{
	}

	private void InitTabs()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnReqInfoCallBack(bool obj)
	{
	}

	public void Refresh(bool isRefreshMat = true)
	{
	}

	protected override void OnClose()
	{
	}

	public void PlayEffect(EffectEnum effectEnum)
	{
	}

	private void RefreshBoxTabs()
	{
	}

	private void RefreshBox()
	{
	}

	private void RefreshKey()
	{
	}

	private void RefreshPreview()
	{
	}

	public void RefreshMatNum(bool isAni = false)
	{
	}

	private void RefreshRed()
	{
	}

	private void ClosePanel()
	{
	}

	private void ClickInfo()
	{
	}

	private void ClickTask()
	{
	}

	private void ClickGift()
	{
	}

	private void ClickShop()
	{
	}

	private void ClickQuickBuy()
	{
	}

	private void ClickPreview()
	{
	}

	private void clickAuto()
	{
	}

	private void ClickOpen()
	{
	}

	private void ClickUp()
	{
	}

	private void RefreshBottom()
	{
	}

	private void freshAutoDesc()
	{
	}

	private void freshBoxIdle()
	{
	}

	private void freshTime()
	{
	}

	private void OnStartAuto(int gear, bool isLoop)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnLanguageChange()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayCountChange_003Ed__92))]
	public IEnumerator PlayCountChange(Text NumTex, int num_2)
	{
		return null;
	}

	public void StartGuide()
	{
	}
}
