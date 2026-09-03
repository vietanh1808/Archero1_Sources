using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.Networking;

namespace Habby.AssetExpress.IO
{
	public class StreamingAssetHelper
	{
		[CompilerGenerated]
		private sealed class _003CInternalReadFromAPK_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string path;

			public UnityAction<string> callback;

			private UnityWebRequest _003Cwww_003E5__2;

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
			public _003CInternalReadFromAPK_003Ed__6(int _003C_003E1__state)
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
		private sealed class _003CInternalReadFromAPK_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string path;

			public UnityAction<byte[]> callback;

			private UnityWebRequest _003Cwww_003E5__2;

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
			public _003CInternalReadFromAPK_003Ed__7(int _003C_003E1__state)
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

		public static bool IsInApk(string path)
		{
			return false;
		}

		public static string ReadFromStreamingAsset(string path)
		{
			return null;
		}

		public static string ReadFromAPK(string path)
		{
			return null;
		}

		public static byte[] ReadDataFromAPK(string path)
		{
			return null;
		}

		public static void ReadFromAPKAsync(string path, UnityAction<string> callback)
		{
		}

		public static void ReadFromAPKAsync(string path, UnityAction<byte[]> callback)
		{
		}

		[IteratorStateMachine(typeof(_003CInternalReadFromAPK_003Ed__6))]
		private static IEnumerator InternalReadFromAPK(string path, UnityAction<string> callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CInternalReadFromAPK_003Ed__7))]
		private static IEnumerator InternalReadFromAPK(string path, UnityAction<byte[]> callback)
		{
			return null;
		}
	}
}
