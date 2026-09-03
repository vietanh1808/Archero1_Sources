using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HabbySdk.Common;
using UnityEngine;
using UnityEngine.Networking;

namespace HabbySdk.HabbyStore
{
	internal class HabbyStoreManager : MonoBehaviour, IHabbyStoreManager, ISdkBase
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass47_0
		{
			public bool isEligible;

			public string eligibilityReason;

			internal void _003C_CanShowStore_003Eb__0(bool eligible, string reason)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCallPaymentEligibilityAPI_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HabbyStoreManager _003C_003E4__this;

			public Action<bool, string> callback;

			private UnityWebRequest _003CwebRequest_003E5__2;

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
			public _003CCallPaymentEligibilityAPI_003Ed__49(int _003C_003E1__state)
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
		private sealed class _003CCheckAppStoreRegion_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HabbyStoreManager _003C_003E4__this;

			public Action<bool, string> callback;

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
			public _003CCheckAppStoreRegion_003Ed__48(int _003C_003E1__state)
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
		private sealed class _003CCreateWebViewControllerCoroutine_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HabbyStoreManager _003C_003E4__this;

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
			public _003CCreateWebViewControllerCoroutine_003Ed__62(int _003C_003E1__state)
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
		private sealed class _003CIsWriteList_003Ed__50 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public HabbyStoreManager _003C_003E4__this;

			private Action<bool> result;

			public Action<bool> _003C_003E3__result;

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
			public _003CIsWriteList_003Ed__50(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowStoreCoroutine_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HabbyStoreManager _003C_003E4__this;

			public string url;

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
			public _003CShowStoreCoroutine_003Ed__61(int _003C_003E1__state)
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
		private sealed class _003CTriggerLoginCoroutine_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HabbyStoreManager _003C_003E4__this;

			private float _003Ctimeout_003E5__2;

			private float _003Celapsed_003E5__3;

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
			public _003CTriggerLoginCoroutine_003Ed__69(int _003C_003E1__state)
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
		private sealed class _003C_CanShowStore_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HabbyStoreManager _003C_003E4__this;

			public Action<bool, string> callback;

			private _003C_003Ec__DisplayClass47_0 _003C_003E8__1;

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
			public _003C_CanShowStore_003Ed__47(int _003C_003E1__state)
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

		private static HabbyStoreManager instance;

		private const string SDK_VERSION = "1.0.0";

		private const string PAYMENT_ELIGIBILITY_PATH = "/habbyid/payment/eligibility";

		private const float API_TIMEOUT = 30f;

		private HabbyStoreConfig _config;

		private IHabbyStoreUserDataProvider _userDataProvider;

		private IHabbyStoreLoadingProvider _loadingProvider;

		private HabbyStoreWebViewController _webViewController;

		private bool _isInitialized;

		private bool _isStoreVisible;

		private string _currentStoreUrl;

		private Action<bool, string> _initializeCallback;

		private Action<bool, string> _showStoreCallback;

		private Action<bool> _loginCallback;

		private bool _isWaitingForStoreLogin;

		[CompilerGenerated]
		private Action m_OnStoreOpened;

		[CompilerGenerated]
		private Action m_OnStoreClosed;

		[CompilerGenerated]
		private Action<string> m_OnPaymentStarted;

		[CompilerGenerated]
		private Action<bool, string> m_OnPaymentCompleted;

		[CompilerGenerated]
		private Action<HabbyStoreError> m_OnError;

		[CompilerGenerated]
		private Action m_OnLoginFlowStarted;

		[CompilerGenerated]
		private Action<bool> m_OnLoginFlowCompleted;

		[CompilerGenerated]
		private Action<PaymentSuccessInfo> m_OnPaySuccess;

		[CompilerGenerated]
		private Action<PaymentFailureInfo> m_OnPayFailure;

		internal static HabbyStoreManager Instance => null;

		public bool IsInitialized => false;

		public bool IsStoreVisible => false;

		public event Action OnStoreOpened
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnStoreClosed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<string> OnPaymentStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<bool, string> OnPaymentCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<HabbyStoreError> OnError
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnLoginFlowStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<bool> OnLoginFlowCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<PaymentSuccessInfo> OnPaySuccess
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<PaymentFailureInfo> OnPayFailure
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void CanShowStore(Action<bool, string> callback)
		{
		}

		[IteratorStateMachine(typeof(_003C_CanShowStore_003Ed__47))]
		private IEnumerator _CanShowStore(Action<bool, string> callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCheckAppStoreRegion_003Ed__48))]
		private IEnumerator CheckAppStoreRegion(Action<bool, string> callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCallPaymentEligibilityAPI_003Ed__49))]
		private IEnumerator CallPaymentEligibilityAPI(Action<bool, string> callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CIsWriteList_003Ed__50))]
		[Obsolete("白名单检查已集成到服务器 API 中，不再需要单独调用")]
		public IEnumerable IsWriteList(Action<bool> result)
		{
			return null;
		}

		public string GetAppStoreCountryCode()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void Initialize(HabbyStoreConfig config, Action<bool, string> onInitialized = null)
		{
		}

		public void SetUserDataProvider(IHabbyStoreUserDataProvider provider)
		{
		}

		public void SetLoadingProvider(IHabbyStoreLoadingProvider provider)
		{
		}

		public void SetStoreUrl(string url)
		{
		}

		public void ShowStore(Action<bool, string> onResult = null)
		{
		}

		[IteratorStateMachine(typeof(_003CShowStoreCoroutine_003Ed__61))]
		private IEnumerator ShowStoreCoroutine(string url)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCreateWebViewControllerCoroutine_003Ed__62))]
		private IEnumerator CreateWebViewControllerCoroutine()
		{
			return null;
		}

		private void SetupWebViewEvents()
		{
		}

		private void OnLoginRequiredHandler(Action<bool> onLoginComplete)
		{
		}

		private void OnWebViewClosedHandler()
		{
		}

		public void HideStore()
		{
		}

		public void DestroyStore()
		{
		}

		public void TriggerHabbyIdLogin(Action<bool> onComplete)
		{
		}

		[IteratorStateMachine(typeof(_003CTriggerLoginCoroutine_003Ed__69))]
		private IEnumerator TriggerLoginCoroutine()
		{
			return null;
		}

		private void OnHabbyIdLoginComplete(bool success)
		{
		}

		private void OnHabbyIdUIOpened()
		{
		}

		public void RefreshUserToken()
		{
		}

		public string GetVersion()
		{
			return null;
		}

		private string GetPlatformType()
		{
			return null;
		}

		private void HandleError(HabbyStoreError error)
		{
		}

		internal void TriggerPaymentSuccess(PaymentSuccessInfo paymentInfo)
		{
		}

		internal void TriggerPaymentFailure(PaymentFailureInfo paymentInfo)
		{
		}

		private void Log(string message)
		{
		}

		private void LogWarning(string message)
		{
		}

		private void LogError(string message)
		{
		}

		private void LogPayment(string message)
		{
		}
	}
}
