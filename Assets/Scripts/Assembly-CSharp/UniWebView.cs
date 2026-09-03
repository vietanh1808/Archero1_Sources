using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UniWebView : MonoBehaviour
{
	public delegate void PageStartedDelegate(UniWebView webView, string url);

	public delegate void PageFinishedDelegate(UniWebView webView, int statusCode, string url);

	public delegate void PageErrorReceivedDelegate(UniWebView webView, int errorCode, string errorMessage);

	public delegate void MessageReceivedDelegate(UniWebView webView, UniWebViewMessage message);

	public delegate bool ShouldCloseDelegate(UniWebView webView);

	public delegate void KeyCodeReceivedDelegate(UniWebView webView, int keyCode);

	public delegate void OrientationChangedDelegate(UniWebView webView, ScreenOrientation orientation);

	public delegate void OnWebContentProcessTerminatedDelegate(UniWebView webView);

	[Obsolete("OreintationChangedDelegate is a typo and deprecated. Use `OrientationChangedDelegate` instead.", true)]
	public delegate void OreintationChangedDelegate(UniWebView webView, ScreenOrientation orientation);

	[CompilerGenerated]
	private PageStartedDelegate m_OnPageStarted;

	[CompilerGenerated]
	private PageFinishedDelegate m_OnPageFinished;

	[CompilerGenerated]
	private PageErrorReceivedDelegate m_OnPageErrorReceived;

	[CompilerGenerated]
	private MessageReceivedDelegate m_OnMessageReceived;

	[CompilerGenerated]
	private ShouldCloseDelegate m_OnShouldClose;

	[CompilerGenerated]
	private KeyCodeReceivedDelegate m_OnKeyCodeReceived;

	[CompilerGenerated]
	private OrientationChangedDelegate m_OnOrientationChanged;

	[CompilerGenerated]
	private OnWebContentProcessTerminatedDelegate m_OnWebContentProcessTerminated;

	private string id;

	private UniWebViewNativeListener listener;

	private bool isPortrait;

	[SerializeField]
	private string urlOnStart;

	[SerializeField]
	private bool showOnStart;

	[SerializeField]
	private bool fullScreen;

	[SerializeField]
	private bool useToolbar;

	[SerializeField]
	private UniWebViewToolbarPosition toolbarPosition;

	private Dictionary<string, Action> actions;

	private Dictionary<string, Action<UniWebViewNativeResultPayload>> payloadActions;

	[SerializeField]
	private Rect frame;

	[SerializeField]
	private RectTransform referenceRectTransform;

	private bool started;

	private Color backgroundColor;

	[CompilerGenerated]
	private OrientationChangedDelegate m_OnOreintationChanged;

	public Rect Frame
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public RectTransform ReferenceRectTransform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Url => null;

	public bool CanGoBack => false;

	public bool CanGoForward => false;

	public Color BackgroundColor
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public float Alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public event PageStartedDelegate OnPageStarted
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

	public event PageFinishedDelegate OnPageFinished
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

	public event PageErrorReceivedDelegate OnPageErrorReceived
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

	public event MessageReceivedDelegate OnMessageReceived
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

	public event ShouldCloseDelegate OnShouldClose
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

	public event KeyCodeReceivedDelegate OnKeyCodeReceived
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

	public event OrientationChangedDelegate OnOrientationChanged
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

	public event OnWebContentProcessTerminatedDelegate OnWebContentProcessTerminated
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

	[Obsolete("OnOreintationChanged is a typo and deprecated. Use `OnOrientationChanged` instead.", true)]
	public event OrientationChangedDelegate OnOreintationChanged
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

	public void UpdateFrame()
	{
	}

	private Rect NextFrameRect()
	{
		return default;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Load(string url, bool skipEncoding = false, string readAccessURL = null)
	{
	}

	public void LoadHTMLString(string htmlString, string baseUrl, bool skipEncoding = false)
	{
	}

	public void Reload()
	{
	}

	public void Stop()
	{
	}

	public void GoBack()
	{
	}

	public void GoForward()
	{
	}

	public void SetOpenLinksInExternalBrowser(bool flag)
	{
	}

	public bool Show(bool fade = false, UniWebViewTransitionEdge edge = UniWebViewTransitionEdge.None, float duration = 0.4f, Action completionHandler = null)
	{
		return false;
	}

	public bool Hide(bool fade = false, UniWebViewTransitionEdge edge = UniWebViewTransitionEdge.None, float duration = 0.4f, Action completionHandler = null)
	{
		return false;
	}

	public bool AnimateTo(Rect frame, float duration, float delay = 0f, Action completionHandler = null)
	{
		return false;
	}

	public void AddJavaScript(string jsString, Action<UniWebViewNativeResultPayload> completionHandler = null)
	{
	}

	public void EvaluateJavaScript(string jsString, Action<UniWebViewNativeResultPayload> completionHandler = null)
	{
	}

	public void AddUrlScheme(string scheme)
	{
	}

	public void RemoveUrlScheme(string scheme)
	{
	}

	public void AddSslExceptionDomain(string domain)
	{
	}

	public void RemoveSslExceptionDomain(string domain)
	{
	}

	public void SetHeaderField(string key, string value)
	{
	}

	public void SetUserAgent(string agent)
	{
	}

	public string GetUserAgent()
	{
		return null;
	}

	public void SetContentInsetAdjustmentBehavior(UniWebViewContentInsetAdjustmentBehavior behavior)
	{
	}

	public static void SetAllowAutoPlay(bool flag)
	{
	}

	public static void SetAllowInlinePlay(bool flag)
	{
	}

	public static void SetJavaScriptEnabled(bool enabled)
	{
	}

	public static void SetAllowJavaScriptOpenWindow(bool flag)
	{
	}

	public void CleanCache()
	{
	}

	public static void ClearCookies()
	{
	}

	public static void SetCookie(string url, string cookie, bool skipEncoding = false)
	{
	}

	public static string GetCookie(string url, string key, bool skipEncoding = false)
	{
		return null;
	}

	public static void ClearHttpAuthUsernamePassword(string host, string realm)
	{
	}

	public void SetShowSpinnerWhileLoading(bool flag)
	{
	}

	public void SetSpinnerText(string text)
	{
	}

	public void SetHorizontalScrollBarEnabled(bool enabled)
	{
	}

	public void SetVerticalScrollBarEnabled(bool enabled)
	{
	}

	public void SetBouncesEnabled(bool enabled)
	{
	}

	public void SetZoomEnabled(bool enabled)
	{
	}

	public void AddPermissionTrustDomain(string domain)
	{
	}

	public void RemovePermissionTrustDomain(string domain)
	{
	}

	public void SetBackButtonEnabled(bool enabled)
	{
	}

	public void SetUseWideViewPort(bool flag)
	{
	}

	public void SetLoadWithOverviewMode(bool flag)
	{
	}

	public void SetImmersiveModeEnabled(bool enabled)
	{
	}

	public void SetShowToolbar(bool show, bool animated = false, bool onTop = true, bool adjustInset = false)
	{
	}

	public void SetToolbarDoneButtonText(string text)
	{
	}

	public void SetShowToolbarNavigationButtons(bool show)
	{
	}

	public void SetUserInteractionEnabled(bool enabled)
	{
	}

	public static void SetWebContentsDebuggingEnabled(bool enabled)
	{
	}

	public void SetWindowUserResizeEnabled(bool enabled)
	{
	}

	public void GetHTMLContent(Action<string> handler)
	{
	}

	public void SetAllowFileAccessFromFileURLs(bool flag)
	{
	}

	public void SetAllowHTTPAuthPopUpWindow(bool flag)
	{
	}

	public void SetCalloutEnabled(bool enabled)
	{
	}

	public void SetSupportMultipleWindows(bool enabled)
	{
	}

	public void SetDefaultFontSize(int size)
	{
	}

	public void SetDragInteractionEnabled(bool enabled)
	{
	}

	public void Print()
	{
	}

	public void ScrollTo(int x, int y, bool animated)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	internal void InternalOnShowTransitionFinished(string identifier)
	{
	}

	internal void InternalOnHideTransitionFinished(string identifier)
	{
	}

	internal void InternalOnAnimateToFinished(string identifier)
	{
	}

	internal void InternalOnAddJavaScriptFinished(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnEvalJavaScriptFinished(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnPageFinished(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnPageStarted(string url)
	{
	}

	internal void InternalOnPageErrorReceived(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnMessageReceived(string result)
	{
	}

	internal void InternalOnWebViewKeyDown(int keyCode)
	{
	}

	internal void InternalOnShouldClose()
	{
	}

	internal void InternalWebContentProcessDidTerminate()
	{
	}
}
