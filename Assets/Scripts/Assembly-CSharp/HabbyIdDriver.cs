using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BestHTTP;
using HabbySdk.HabbyId;
using UnityEngine;
using UnityEngine.Networking;

public class HabbyIdDriver : MonoBehaviour, IHIDDriver, IChangeUI, IFinishState, ISDKConnect
{
	[Serializable]
	public class HabbyIdState
	{
		public bool enabled;

		public bool isLoggedIn;

		public string email;

		public string habbyId;
	}

	[CompilerGenerated]
	private sealed class _003CAutoCloseLoginSuccessUI_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HabbyIdDriver _003C_003E4__this;

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
		public _003CAutoCloseLoginSuccessUI_003Ed__68(int _003C_003E1__state)
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
	private sealed class _003CPrepareConnentionCoroutine_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HabbyIdDriver _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

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
		public _003CPrepareConnentionCoroutine_003Ed__85(int _003C_003E1__state)
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

	private IHIDManager hidManager;

	public static Action<bool> OnHideAll;

	private static HabbyIdDriver instance;

	public static LocalizationManager LocalizationManager;

	public HIDUIManager hidUiManager;

	private bool isPrepareConnention;

	private string gameId;

	private string _serverUrl;

	private bool isRefreshRedDot;

	private const string _isOpenHIDKey = "habbyIdEnabled";

	private HabbyIdState currentHIDData;

	private Action refreshCallback;

	private string _trackEventSessionId;

	private Dictionary<string, object> _dic;

	private static readonly int[] pcb;

	private static readonly int pxb;

	public static HabbyIdDriver Instance => null;

	public string GameId => null;

	private int IsBindHabbyId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private bool IsHabbyIdOpened
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowRedDot => false;

	public bool ShowBindReward => false;

	public bool isOpenHID { get; private set; }

	public string HabbyID => null;

	public string Language => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public void ExitHIDProcess()
	{
	}

	public void OnLanguageChanged()
	{
	}

	public string GetGameAccountId()
	{
		return null;
	}

	public string GetCurrentLanguage()
	{
		return null;
	}

	public UnityWebRequest AddHIDHeader(UnityWebRequest request)
	{
		return null;
	}

	public HTTPRequest AddHIDHeader(HTTPRequest request)
	{
		return null;
	}

	public void PrepareConnention()
	{
	}

	public void SetGameId(string gameId)
	{
	}

	public string GetServerUrl()
	{
		return null;
	}

	public void SetServerUrl(string url)
	{
	}

	public void RefreshRedDot()
	{
	}

	private void HideRedDot()
	{
	}

	public void SetHIDOpen(bool _enable)
	{
	}

	public HabbyIdState GetHIDData()
	{
		return null;
	}

	public void OnHIDStateChange(bool isLogin, string email, string HabbyId)
	{
	}

	public static bool IsHidEnabled()
	{
		return false;
	}

	public void RegisterRefreshCallBack(Action refreshCallback)
	{
	}

	public void OnClickSettingLogin()
	{
	}

	public void OnClickSelectProgressLogin()
	{
	}

	public void OnClickLoginSilent()
	{
	}

	public void OnClickSettingLogout()
	{
	}

	public bool CheckHabbyIdLogin()
	{
		return false;
	}

	public void LoginHabbyId(string authCode, ProcessType type, Action<bool, int> onResult)
	{
	}

	public void LogoutHabbyId(Action<bool, int> onResult)
	{
	}

	public string GetCustonUserInfo()
	{
		return null;
	}

	public void TrackEvent(SdkEventName eventName, V2V_TrackSdkEvent eventData = null)
	{
	}

	public void RegisterEvents()
	{
	}

	private void HandleLoginSuccessEvent(C2V_LoginSuccessEvent obj)
	{
	}

	[IteratorStateMachine(typeof(_003CAutoCloseLoginSuccessUI_003Ed__68))]
	private IEnumerator AutoCloseLoginSuccessUI()
	{
		return null;
	}

	private void HandleLogoutSuccessEvent(C2V_LogoutSuccess obj)
	{
	}

	public void HandleLoginEvent(C2V_LoginEvent eventData)
	{
	}

	private void HandleEmailSendSuccessEvent(C2V_EmailSendSuccessEvent obj)
	{
	}

	private void HandleWaitTenMiuneEvent(C2V_WaitTenMiuneEvent obj)
	{
	}

	private void HandleVerifyCodeInValid(C2V_VerifyCodeInValid obj)
	{
	}

	private void HandleServerBusiness(C2V_ServerBusiness obj)
	{
	}

	private void HandleSendTooManyEvent(C2V_SendTooManyEvent obj)
	{
	}

	private void HandleSendVerifyCodeByEmailEvent(C2V_SendVerifyCodeByEmailEvent obj)
	{
	}

	private void HandleHomeEvent(C2V_HomeEvent obj)
	{
	}

	private void HandleNotifyEvent(C2V_HandleNotifyEvent obj)
	{
	}

	private void HandleCloseAllUIEvent(C2V_CloseAllUIEvent obj)
	{
	}

	private void HandleShowToastEvent(C2V_ShowToast obj)
	{
	}

	private void HandleOnLoginInputVailedEmailEvent(C2V_OnLoginInputVailedEmailEvent obj)
	{
	}

	private void HandleTrackSdkEvent(V2V_TrackSdkEvent obj)
	{
	}

	private void HandleClickLoginSessionFinishEvent(V2C_ClickLoginSessionFinishEvent obj)
	{
	}

	public void UnRegisterEvents()
	{
	}

	[IteratorStateMachine(typeof(_003CPrepareConnentionCoroutine_003Ed__85))]
	private IEnumerator PrepareConnentionCoroutine()
	{
		return null;
	}

	public string GetSign(string email, string time)
	{
		return null;
	}

	private static void AddData(ref Dictionary<string, object> data, string key, object value)
	{
	}

	private void TrackHabbyId(string step, string sessionId, Dictionary<string, object> extras = null)
	{
	}

	private void TrackHabbyIdStep(string step, string sessionId, Dictionary<string, object> extras = null)
	{
	}

	private void ShowLoadingUi()
	{
	}

	private void HideLoadingUi()
	{
	}
}
