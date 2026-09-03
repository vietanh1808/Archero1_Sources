using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HabbySdk.HabbyStore;
using UnityEngine;

public class HabbyStoreWebViewController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCheckPaymentResultDelayed_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HabbyStoreWebViewController _003C_003E4__this;

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
		public _003CCheckPaymentResultDelayed_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CClearPaymentRecordDelayed_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HabbyStoreWebViewController _003C_003E4__this;

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
		public _003CClearPaymentRecordDelayed_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CLoadUrlAfterShow_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public UniWebView webView;

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
		public _003CLoadUrlAfterShow_003Ed__25(int _003C_003E1__state)
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

	[Header("WebView配置")]
	public UniWebView webView;

	private const bool ENABLE_AUTO_PAYMENT_REDIRECT = false;

	[Header("事件回调")]
	public Action OnWebViewClosed;

	public Action<Action<bool>> OnLoginRequired;

	private IHabbyStoreUserDataProvider _userDataProvider;

	private HabbyStoreConfig _config;

	private bool isWaitingForPaymentResult;

	private float paymentCheckTimer;

	private const float PAYMENT_CHECK_TIMEOUT = 60f;

	private string lastHandledPaymentUrl;

	private float lastPaymentTime;

	private const float PAYMENT_COOLDOWN = 10f;

	[Header("商店配置")]
	public string storeUrl;

	private const string LOGIN_EVENT = "uniwebview://login";

	private const string PAYMENT_SUCCESS_EVENT = "uniwebview://paymentSuccess";

	private const string PAYMENT_FAILED_EVENT = "uniwebview://paymentFailed";

	private void Start()
	{
	}

	public void SetConfig(HabbyStoreConfig config)
	{
	}

	private string GetStoreUrl()
	{
		return null;
	}

	public void SetUserDataProvider(IHabbyStoreUserDataProvider userDataProvider)
	{
	}

	public void OpenStore()
	{
	}

	private void OpenStore(string url)
	{
	}

	public void CloseStore()
	{
	}

	public void DestroyStore()
	{
	}

	private void RefreshWebViewWithNewToken()
	{
	}

	private void UpdateWebViewUserAgent()
	{
	}

	public void EnableLoadingSpinner()
	{
	}

	private void CreateWebView(string url = null)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadUrlAfterShow_003Ed__25))]
	private IEnumerator LoadUrlAfterShow(UniWebView webView, string url)
	{
		return null;
	}

	private void OnPageStarted(UniWebView webView, string url)
	{
	}

	private void OnPageFinished(UniWebView webView, int statusCode, string url)
	{
	}

	private void OnMessageReceived(UniWebView webView, UniWebViewMessage message)
	{
	}

	private void OnPaymentSuccessReceived(UniWebViewMessage message)
	{
	}

	private void OnPaymentFailedReceived(UniWebViewMessage message)
	{
	}

	private void OnLoginFinish(bool success)
	{
	}

	private void OnPageErrorReceived(UniWebView webView, int errorCode, string errorMessage)
	{
	}

	private bool OnWebViewShouldClose(UniWebView webView)
	{
		return false;
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void OnDestroy()
	{
	}

	private bool IsPaymentUrl(string url)
	{
		return false;
	}

	private bool IsPaymentScheme(string scheme)
	{
		return false;
	}

	private void HandlePaymentRedirect(string paymentUrl)
	{
	}

	private void StartPaymentResultCheck()
	{
	}

	private void StopPaymentResultCheck()
	{
	}

	[IteratorStateMachine(typeof(_003CClearPaymentRecordDelayed_003Ed__44))]
	private IEnumerator ClearPaymentRecordDelayed()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCheckPaymentResultDelayed_003Ed__45))]
	private IEnumerator CheckPaymentResultDelayed()
	{
		return null;
	}

	private void Update()
	{
	}
}
