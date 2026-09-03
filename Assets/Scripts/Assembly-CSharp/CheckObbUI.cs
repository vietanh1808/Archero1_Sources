using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Habby.DownLoad;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CheckObbUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRetryDownLoad_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CheckObbUI _003C_003E4__this;

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
		public _003CRetryDownLoad_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003CWaitQuit_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CWaitQuit_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CWaitRestart_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CWaitRestart_003Ed__25(int _003C_003E1__state)
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
	private sealed class _003Cdownload_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CheckObbUI _003C_003E4__this;

		private string _003Ctmd5str_003E5__2;

		private string _003Cturl_003E5__3;

		private string _003CtempFile_003E5__4;

		private string _003CcompleteFile_003E5__5;

		private UnityWebRequest _003Cuwr_003E5__6;

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
		public _003Cdownload_003Ed__18(int _003C_003E1__state)
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

	private const string Repairing = "Repairing";

	private const string RepairCmplete = "RepairCmplete";

	private const string RepairFailed = "RepairFailed";

	private const string NeedReStart = "NeedReStart";

	private const string NeedPermission = "NeedPermission";

	public CheckObbLanguage languageAsset;

	public Image barimg;

	public DxxText proctext;

	public DxxText tipContext;

	public DxxText permissionTips;

	private string folder;

	private int reTryCount;

	private void Awake()
	{
	}

	private void SetGame()
	{
	}

	private void CheckOBB()
	{
	}

	private void GoToMainScene()
	{
	}

	private void SetProcess(float process)
	{
	}

	private void StartDownLoadOBB()
	{
	}

	[IteratorStateMachine(typeof(_003Cdownload_003Ed__18))]
	private IEnumerator download()
	{
		return null;
	}

	private void DownLoadComplete(string url, string tempFile, string completeFile, string md5str)
	{
	}

	private bool CheckMD5(string md5str, string tempFile)
	{
		return false;
	}

	private void CheckPermission()
	{
	}

	private void OnProcess(DownLoader sender)
	{
	}

	private void OnDownLoadComplete(DownLoader sender)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitQuit_003Ed__24))]
	private IEnumerator WaitQuit()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitRestart_003Ed__25))]
	private IEnumerator WaitRestart()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRetryDownLoad_003Ed__26))]
	private IEnumerator RetryDownLoad()
	{
		return null;
	}
}
