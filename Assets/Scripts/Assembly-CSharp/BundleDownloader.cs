using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class BundleDownloader : MonoBehaviour
{
	public enum DownloadState
	{
		eWait = 0,
		eDownloading = 1,
		eFinish = 2
	}

	[CompilerGenerated]
	private sealed class _003CDownLoad_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ResourceManager.ResourceDownloadHelper.DownloadInfo info;

		public Action<bool, float, ResourceManager.ResourceDownloadHelper.DownloadInfo> onDownloading;

		public BundleDownloader _003C_003E4__this;

		private FileStream _003C_003E7__wrap1;

		private Stream _003CnetStream_003E5__3;

		private int _003CpackLength_003E5__4;

		private long _003CcountLength_003E5__5;

		private byte[] _003Cnbytes_003E5__6;

		private int _003CnReadSize_003E5__7;

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
		public _003CDownLoad_003Ed__17(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDownLoadUnity_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ResourceManager.ResourceDownloadHelper.DownloadInfo info;

		public Action<bool, float, ResourceManager.ResourceDownloadHelper.DownloadInfo> onDownloading;

		public BundleDownloader _003C_003E4__this;

		private string _003CdesFileName_003E5__2;

		private UnityWebRequest _003Crequest_003E5__3;

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
		public _003CDownLoadUnity_003Ed__15(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDownLoadUnityHandler_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ResourceManager.ResourceDownloadHelper.DownloadInfo info;

		public Action<bool, float, ResourceManager.ResourceDownloadHelper.DownloadInfo> onDownloading;

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
		public _003CDownLoadUnityHandler_003Ed__16(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static Dictionary<string, BundleDownloader> downloadDic;

	private static GameObject DownloadRoot;

	public Action<object, ResourceManager.ResourceDownloadHelper.DownloadInfo> OnBundleDownloadStart;

	public Action<object, ResourceManager.ResourceDownloadHelper.DownloadInfo, float> OnBundleDownloading;

	public Action<object, ResourceManager.ResourceDownloadHelper.DownloadInfo> OnBundleDownloadSuccess;

	public Action<object, ResourceManager.ResourceDownloadHelper.DownloadInfo, string> OnBundleDownloadFail;

	public DownloadState State;

	public ResourceManager.ResourceDownloadHelper.DownloadInfo Info;

	private FileStream fs;

	private void Init(ResourceManager.ResourceDownloadHelper.DownloadInfo downloadInfo, Action<object, ResourceManager.ResourceDownloadHelper.DownloadInfo> onStart, Action<object, ResourceManager.ResourceDownloadHelper.DownloadInfo, float> onDownloading, Action<object, ResourceManager.ResourceDownloadHelper.DownloadInfo> onSuccess, Action<object, ResourceManager.ResourceDownloadHelper.DownloadInfo, string> onFail)
	{
	}

	public static void CreateDownload(ResourceManager.ResourceDownloadHelper.DownloadInfo info, Action<object, ResourceManager.ResourceDownloadHelper.DownloadInfo> onStart, Action<object, ResourceManager.ResourceDownloadHelper.DownloadInfo, float> onDownloading, Action<object, ResourceManager.ResourceDownloadHelper.DownloadInfo> onSuccess, Action<object, ResourceManager.ResourceDownloadHelper.DownloadInfo, string> onFail)
	{
	}

	public static void CancelAllDownload()
	{
	}

	private void Update()
	{
	}

	private void OnDownloading(bool ifComplete, float percent, ResourceManager.ResourceDownloadHelper.DownloadInfo info)
	{
	}

	[IteratorStateMachine(typeof(_003CDownLoadUnity_003Ed__15))]
	public IEnumerator DownLoadUnity(ResourceManager.ResourceDownloadHelper.DownloadInfo info, Action<bool, float, ResourceManager.ResourceDownloadHelper.DownloadInfo> onDownloading)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDownLoadUnityHandler_003Ed__16))]
	public IEnumerator DownLoadUnityHandler(ResourceManager.ResourceDownloadHelper.DownloadInfo info, Action<bool, float, ResourceManager.ResourceDownloadHelper.DownloadInfo> onDownloading)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDownLoad_003Ed__17))]
	public IEnumerator DownLoad(ResourceManager.ResourceDownloadHelper.DownloadInfo info, Action<bool, float, ResourceManager.ResourceDownloadHelper.DownloadInfo> onDownloading)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
