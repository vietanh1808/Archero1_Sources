using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace HabbySdk.HabbyId
{
	internal class AuthenticationState : StateBase
	{
		[CompilerGenerated]
		private sealed class _003CCheckSendCode_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AuthenticationState _003C_003E4__this;

			public string playerEmail;

			public bool receiveMessage;

			public ProcessType type;

			private string _003CpostUrl_003E5__2;

			private byte[] _003CjsonBytes_003E5__3;

			private int _003CsendCount_003E5__4;

			private UnityWebRequest _003Crequest_003E5__5;

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
			public _003CCheckSendCode_003Ed__16(int _003C_003E1__state)
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
		private sealed class _003CGetCodeByClient_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AuthenticationState _003C_003E4__this;

			public string email;

			public bool GetByRefresh;

			public Action callBack;

			public bool receiveMessage;

			public ProcessType tt;

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
			public _003CGetCodeByClient_003Ed__11(int _003C_003E1__state)
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
		private sealed class _003CHandleVerifyCode_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AuthenticationState _003C_003E4__this;

			public string email;

			public ProcessType processType;

			public string verifyCode;

			public bool receiveMessage;

			public Action<bool> callback;

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
			public _003CHandleVerifyCode_003Ed__6(int _003C_003E1__state)
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
		private sealed class _003CSendEmail_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AuthenticationState _003C_003E4__this;

			public string email;

			public Action<bool> complete;

			public bool receiveMessage;

			public ProcessType type;

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
			public _003CSendEmail_003Ed__5(int _003C_003E1__state)
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

		private Action successLoginCallback;

		private Coroutine loopCheck;

		public const int MAXSENDCOUNT = 2000;

		public const float SENDINTERVAL = 0.5f;

		public AuthenticationState(FiniteStateMachine fsm)
			: base(null)
		{
		}

		~AuthenticationState()
		{
		}

		private void EmailInputEvent(V2C_EmailInputEvent obj)
		{
		}

		private void VerifyCodeInput(V2C_InputVerifyCodeEvent obj)
		{
		}

		private void LoopCheckCancel(V2C_LoopCheckCancel obj)
		{
		}

		[IteratorStateMachine(typeof(_003CSendEmail_003Ed__5))]
		private IEnumerator SendEmail(string email, bool receiveMessage, Action<bool> complete, ProcessType type)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CHandleVerifyCode_003Ed__6))]
		private IEnumerator HandleVerifyCode(string email, string verifyCode, bool receiveMessage, Action<bool> callback, ProcessType processType)
		{
			return null;
		}

		private void NotReceiveVerifyCode(V2C_NotReceiveVerifyCodeEvent obj)
		{
		}

		private void LoopCheckSuccessLogin(V2C_LoopCheckSuccessLogin obj)
		{
		}

		private void NotReceive_RefreshEvent(V2C_NotReceive_RefreshEvent obj)
		{
		}

		[IteratorStateMachine(typeof(_003CGetCodeByClient_003Ed__11))]
		private IEnumerator GetCodeByClient(string email, bool receiveMessage, bool GetByRefresh, Action callBack, ProcessType tt)
		{
			return null;
		}

		private void ShowCodeOnUI(GetCodeOnClient.Root data, string email, bool receiveMessage, bool GetByRefresh, ProcessType t)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckSendCode_003Ed__16))]
		private IEnumerator CheckSendCode(string playerEmail, bool receiveMessage, ProcessType type)
		{
			return null;
		}

		private void OnLoginInputOtherEmail()
		{
		}

		public override void Exit()
		{
		}
	}
}
