using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cooperation.NetEvent;
using Habby.Net;
using PureMVC.Interfaces;
using TCPPacket.ProtoBuf;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class CooperationPVPCreateUICtrl : MediatorCtrlBase
{
	public enum CloseType
	{
		none = 0,
		KickOut_ClickStart = 1,
		ClickClose = 2,
		ConnectFail = 3,
		DisConnect = 4,
		OtherPlayerDisConnect = 5,
		MatchServerDisconnect = 6,
		Code_29 = 7
	}

	[CompilerGenerated]
	private sealed class _003CCreatRoomCoroutine_003Ed__132 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CooperationPVPCreateUICtrl _003C_003E4__this;

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
		public _003CCreatRoomCoroutine_003Ed__132(int _003C_003E1__state)
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
	private sealed class _003CHeartBeatCoroutine_003Ed__126 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CooperationPVPCreateUICtrl _003C_003E4__this;

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
		public _003CHeartBeatCoroutine_003Ed__126(int _003C_003E1__state)
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
	private sealed class _003CJoinRoomCoroutine_003Ed__131 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CooperationPVPCreateUICtrl _003C_003E4__this;

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
		public _003CJoinRoomCoroutine_003Ed__131(int _003C_003E1__state)
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
	private sealed class _003CMatchCoroutine_003Ed__133 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CooperationPVPCreateUICtrl _003C_003E4__this;

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
		public _003CMatchCoroutine_003Ed__133(int _003C_003E1__state)
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
	private sealed class _003CReTryConnect_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CooperationPVPCreateUICtrl _003C_003E4__this;

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
		public _003CReTryConnect_003Ed__116(int _003C_003E1__state)
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
	private sealed class _003CSelfModelAnimation_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CooperationPVPCreateUICtrl _003C_003E4__this;

		private float _003Ctpart_003E5__2;

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
		public _003CSelfModelAnimation_003Ed__80(int _003C_003E1__state)
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
	private sealed class _003CWaitInToGame_003Ed__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CooperationPVPCreateUICtrl _003C_003E4__this;

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
		public _003CWaitInToGame_003Ed__145(int _003C_003E1__state)
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
	private sealed class _003CWaitToMatch_003Ed__143 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CooperationPVPCreateUICtrl _003C_003E4__this;

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
		public _003CWaitToMatch_003Ed__143(int _003C_003E1__state)
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

	public RawImage img_clientHero;

	public RawImage img_serverHero;

	public RectTransform serverHeroShowStartPoint;

	public RectTransform serverHeroShowEndPoint;

	private HeroShow clientHeroShow;

	private HeroShow serverHeroShow;

	private RectTransform serverHeroShowRect;

	[Header("房间功能")]
	public DxxText Text_Title;

	public DxxText Text_RoomID;

	public DxxText Text_Content;

	public ButtonCtrl Button_Close;

	public DxxText textLastTime;

	public GameObject joinInObj;

	public GameObject waitingObj;

	public DxxText Text_JoinIn;

	public DxxText Text_WaitingLeader;

	public ButtonCtrl Button_CopyRoom;

	public DxxText Text_Copy;

	public Transform topParent;

	public DxxText Text_Begin;

	public ButtonCtrl Button_Start;

	public DxxText Text_EnergyMatchTip;

	public DxxText Text_RoomTitle;

	[Header("1号玩家信息")]
	public RectTransform playerOne;

	public Transform ServerSlot;

	public DxxText Text_ServerId;

	public Text Text_Player1;

	private GameObject serverModel;

	[Header("2号玩家信息")]
	public RectTransform playerTwo;

	public GameObject shadowModel;

	public Transform ClientSlot;

	public DxxText Text_ClientId;

	public Text Text_Player2;

	private GameObject clientModel;

	[Header("非匹配")]
	public RectTransform nomatchParent;

	public RectTransform nomatchTopParent;

	[Header("自动匹配")]
	public ButtonCtrl Button_StartMatch;

	public DxxText Button_MatchText;

	public RectTransform matchParent;

	public DxxText ingametime;

	public DxxText ingametitle;

	public DxxText matching;

	public RectTransform costRoot;

	public DxxText costText;

	public Image costIcon;

	public GameObject matchinglayer;

	public GameObject matchedlayer;

	private bool isMatched;

	private SCStartMatchEvent matchData;

	private int reConnectCount;

	private bool isClickMatch;

	private bool IsEnterBattleRoom;

	[Header("匹配动画定点")]
	public RectTransform animationSlot;

	public RectTransform startPoint;

	public RectTransform endPoint;

	private float startmatchTimeTag;

	private float startMatchTime;

	private int retryMathckCount;

	public ButtonCtrl btnTips;

	private bool isOpen;

	private bool isGotPlayerInfo;

	private bool isOtherPlayerEnter;

	public Daily_PvPConfig tableConfig;

	private bool waitSingl;

	private NetMessage sigMsg;

	private bool isConnect;

	private bool isMatching;

	private IEnumerator waitRetry;

	private IEnumerator waitInto;

	private void setIdInvisible()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnOpenUI()
	{
	}

	private void CreatRoomType()
	{
	}

	private void JoinRoomType()
	{
	}

	private void MatchRoomType()
	{
	}

	private void AutoMatchMode()
	{
	}

	private void NoMatchMode()
	{
	}

	private void SetRoomID(string pRoomID)
	{
	}

	private void ShowMatchTypeUI()
	{
	}

	private void ShowMatchingUI()
	{
	}

	private void ShowWaitMatchUI()
	{
	}

	private void InitMatchSlot()
	{
	}

	private void RestSlot()
	{
	}

	private void ShowMatchedUI()
	{
	}

	[IteratorStateMachine(typeof(_003CSelfModelAnimation_003Ed__80))]
	private IEnumerator SelfModelAnimation()
	{
		return null;
	}

	private void ShowPlayerTwoMatching()
	{
	}

	private void ShowModelRandomAnimation()
	{
	}

	private void ShowPlayerTwo()
	{
	}

	private void OnClickStartMatch()
	{
	}

	private void OnClickClose()
	{
	}

	private void CloseUI(CloseType pType)
	{
	}

	private void SendClosePoint(CloseType pType)
	{
	}

	private void OnClickStartBtn()
	{
	}

	private void OnClickCopyRoom()
	{
	}

	private void android_escape()
	{
	}

	private void RestMatchProcess()
	{
	}

	private void RestMatchObject()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	private void GetOtherPlayerInfo()
	{
	}

	private void OtherPlayerReady()
	{
	}

	private void WillStart()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void OnConnectFailed()
	{
	}

	private void OnOtherPlayerDisconnect()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void RefreshMySelf()
	{
	}

	private void CreateModel(bool isSelf)
	{
	}

	private void SetColorSkin(GameObject weapon, bool isSelf)
	{
	}

	private void RefreshOtherPlayer()
	{
	}

	private void SetPlayerInfo(int pPos, ulong nPlayerID)
	{
	}

	private int IsLeftPlayer(bool pisSelf)
	{
		return 0;
	}

	private string GetBodyString(string value)
	{
		return null;
	}

	public bool IsMatchMode()
	{
		return false;
	}

	private void ConnectToMatchServer()
	{
	}

	[IteratorStateMachine(typeof(_003CReTryConnect_003Ed__116))]
	private IEnumerator ReTryConnect()
	{
		return null;
	}

	private void TCPCallBack(NetMessage pMsg)
	{
	}

	private SdkManager.MatchPVPData GetMatchPointData(string pStep, string pRessult)
	{
		return null;
	}

	private void InitTCP()
	{
	}

	private void OnMatchCallBack(object pMsg)
	{
	}

	private void OnMatchHeartCallBack(object pMsg)
	{
	}

	private void OnCreatRoomCallBack(object pMsg)
	{
	}

	private void OnAllPlayerJoinCallBack(object pMsg)
	{
	}

	private void QuiteRoom()
	{
	}

	private void EnterBattleRoom()
	{
	}

	[IteratorStateMachine(typeof(_003CHeartBeatCoroutine_003Ed__126))]
	private IEnumerator HeartBeatCoroutine()
	{
		return null;
	}

	private void GoToJoin()
	{
	}

	private void GoToCreatRoom()
	{
	}

	private void GoToMatch()
	{
	}

	[IteratorStateMachine(typeof(_003CJoinRoomCoroutine_003Ed__131))]
	private IEnumerator JoinRoomCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCreatRoomCoroutine_003Ed__132))]
	private IEnumerator CreatRoomCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMatchCoroutine_003Ed__133))]
	private IEnumerator MatchCoroutine()
	{
		return null;
	}

	private uint GetProtocolVersion()
	{
		return 0u;
	}

	private GetAnotherPlayerInfo GetJoinRoomRequest()
	{
		return null;
	}

	private CreateFTFRoom GetCreatRoomRequest()
	{
		return null;
	}

	private MatchRequest GetMatchRequest()
	{
		return null;
	}

	public uint GetPowerValue(SelfAttributeData pData)
	{
		return 0u;
	}

	private float GetUserIDSum()
	{
		return 0f;
	}

	private float GetGemSum()
	{
		return 0f;
	}

	private void ReTryMatch()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitToMatch_003Ed__143))]
	private IEnumerator WaitToMatch()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitInToGame_003Ed__145))]
	private IEnumerator WaitInToGame()
	{
		return null;
	}

	private void StartIntoGame()
	{
	}

	private void StopIntoGame()
	{
	}
}
