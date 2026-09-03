using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class ReportUICtrl : MediatorCtrlBase
{
	[Serializable]
	public class PlayerInfo
	{
		public string serveruserid;

		public string serveruseridsub;

		public string uuid;

		public string platform;

		public string sdklogintype;

		public string sdkloginid;

		public string devicemodel;

		public int memorysize;

		public string appversion;

		public string operationsystem;

		public string graphicsDeviceName;

		public string nettype;

		public string tga_deviceid;

		public string tga_distinctid;

		public string ip;

		public ReportData savedata;
	}

	[Serializable]
	public class ReportData
	{
		public LocalSave.UserInfo userInfo;

		public LocalSave.CardData mCardData;

		public LocalSave.TimeBoxData mTimeBoxData;

		public LocalSave.Stage mStage;

		public LocalSave.LocalSaveExtra mExtra;

		public LocalSave.HarvestData mHarvest;

		public LocalSave.HarvestData mHarvestShort;

		public LocalSave.GuideData mGuideData;
	}

	[CompilerGenerated]
	private sealed class _003Cstart_load_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ReportUICtrl _003C_003E4__this;

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
		public _003Cstart_load_003Ed__33(int _003C_003E1__state)
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

	public const string WEBVIEW_CLOSE = "close";

	public const string WEBVIEW_GET_PLAYER_INFO = "get_player_info";

	public const string WEBVIEW_GOTO_FACEBOOK = "goto_facebook";

	public const string WEBVIEW_UPDATE_STATUS = "update_status";

	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public ButtonCtrl Button_Retry;

	public DxxText Text_Retry;

	public RectTransform viewparent;

	public UniWebView mView;

	public GameObject loadingparent;

	public DxxText Text_Loading;

	public RectTransform webViewFrame;

	private SequencePool mPool;

	private Sequence seq_delay;

	private int loadingindex;

	private bool bAlreadyShow;

	private bool bOpen;

	private bool mViewShow;

	private int mViewStatus;

	private string url;

	private string url_test;

	protected override void OnInit()
	{
	}

	private void init_view()
	{
	}

	protected override void OnOpen()
	{
	}

	private void do_time_out()
	{
	}

	private void ShowView(bool value)
	{
	}

	private void SetLoading(int index)
	{
	}

	private void startload()
	{
	}

	private string get_player_info()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003Cstart_load_003Ed__33))]
	private IEnumerator start_load()
	{
		return null;
	}

	private void send_player_info()
	{
	}

	private void send_android_back()
	{
	}

	private void OnPageErrorReceived(UniWebView webView, int errorCode, string errorMessage)
	{
	}

	private void OnKeyCodeReceived(UniWebView webView, int keyCode)
	{
	}

	private void OnPageFinished(UniWebView webView, int statusCode, string url)
	{
	}

	private void OnPageStarted(UniWebView webView, string url)
	{
	}

	private void OnMessageReceived(UniWebView webView, UniWebViewMessage message)
	{
	}

	private bool OnShouldClose(UniWebView webView)
	{
		return false;
	}

	private void OnWebContentProcessTerminated(UniWebView webView)
	{
	}

	private void android_escape()
	{
	}

	private void goto_FaceBook(string url, string facebookId)
	{
	}

	protected override void OnClose()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
