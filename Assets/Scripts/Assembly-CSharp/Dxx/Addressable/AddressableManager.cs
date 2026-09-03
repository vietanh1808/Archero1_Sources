using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Dxx.Addressable
{
	public class AddressableManager : Singleton<AddressableManager>
	{
		[CompilerGenerated]
		private sealed class _003CDoDownload_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AddressableManager _003C_003E4__this;

			public List<object> keys;

			private AsyncOperationHandle _003CdownloadHandle_003E5__2;

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
			public _003CDoDownload_003Ed__46(int _003C_003E1__state)
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
		private sealed class _003CDoUpdateAddressable_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AddressableManager _003C_003E4__this;

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
			public _003CDoUpdateAddressable_003Ed__44(int _003C_003E1__state)
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

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CLoadAssetAsync2_003Ed__49<T> : IAsyncStateMachine where T : UnityEngine.Object
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public string name;

			public Action<T> complete;

			public AddressableManager _003C_003E4__this;

			private AsyncOperationHandle<T> _003Chandle_003E5__2;

			private TaskAwaiter<T> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CLoadAssetsAsync_003Ed__56<T> : IAsyncStateMachine where T : class
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public string[] keys;

			public Action<string, T> completeSingle;

			public AddressableManager _003C_003E4__this;

			public Action<IDictionary<string, T>> completeAll;

			private Dictionary<string, T> _003Cress_003E5__2;

			private string[] _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private string _003Ckey_003E5__5;

			private AsyncOperationHandle<T> _003Chandle_003E5__6;

			private TaskAwaiter<T> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003C_LoadAllCampUI_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public AddressableManager _003C_003E4__this;

			public Action callback;

			private FunctionalModule _003Cmodule_003E5__2;

			private List<string> _003CuiPaths_003E5__3;

			private List<string>.Enumerator _003Cenumerator_003E5__4;

			private string _003Cpath_003E5__5;

			private AsyncOperationHandle<UnityEngine.Object> _003Chandle_003E5__6;

			private TaskAwaiter<UnityEngine.Object> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private Dictionary<string, List<AsyncOperationHandle>> m_dicHandleReferences;

		private List<string> m_listAtlasNames;

		private List<string> m_listUIMediatorNames;

		private Dictionary<FunctionalModule, DxxUIAtlasDependency> configs;

		private Dictionary<FunctionalModule, ResState> m_dicModuleDownloadProgress;

		private const string Tag = "AddressableManager";

		private Coroutine m_coroutine;

		private float m_fNextRetryTime;

		private int m_nRetryCnt;

		private const float RETRY_INTERVAL = 20f;

		private const float CHECK_INTERVAl = 1f;

		private float m_fLastCheckTime;

		private bool m_bCanDownload;

		private List<object> m_listKeys;

		private long m_lTotalDownloadSize;

		private AsyncOperationHandle? _initHandle;

		private AsyncOperationHandle<List<string>>? _checkHandle;

		private AsyncOperationHandle<List<IResourceLocator>>? _updateHandle;

		private AsyncOperationHandle<long>? _sizeHandle;

		private AsyncOperationHandle? _downloadHandle;

		public bool CanDownload => false;

		public bool DownloadCompleted => false;

		public bool IsDownloading => false;

		public float PercentComplete { get; private set; }

		public static void Log(string log)
		{
		}

		public static void LogError(string log)
		{
		}

		public static void LogWarning(string log)
		{
		}

		public void OnUpdate()
		{
		}

		public void LoadCampUIAsync(string name, Action<GameObject> complete = null)
		{
		}

		public void LoadAllCampUI(Action callback)
		{
		}

		[AsyncStateMachine(typeof(_003C_LoadAllCampUI_003Ed__18))]
		private void _LoadAllCampUI(Action callback)
		{
		}

		public float GetDownloadProcess(FunctionalModule module)
		{
			return 0f;
		}

		public bool CheckModuleResDownloadCompleted(FunctionalModule module)
		{
			return false;
		}

		private bool CheckRes(FunctionalModule module, string path)
		{
			return false;
		}

		public void LoadUIDependency(FunctionalModule module, Action callback)
		{
		}

		private void LoadUIDependencies(FunctionalModule[] modules, Action callback)
		{
		}

		private void ReleaseAllHandles()
		{
		}

		public void CheckUpdateAddressable()
		{
		}

		[IteratorStateMachine(typeof(_003CDoUpdateAddressable_003Ed__44))]
		private IEnumerator DoUpdateAddressable()
		{
			return null;
		}

		public void RetryDownload()
		{
		}

		[IteratorStateMachine(typeof(_003CDoDownload_003Ed__46))]
		private IEnumerator DoDownload(List<object> keys)
		{
			return null;
		}

		public void ShowConfirmWindow(Action<Func<float>> processCb)
		{
		}

		public void ShowConfirmWindow(List<object> keys, long totalDownloadSize, Action<bool> comfirmCallback = null)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadAssetAsync2_003Ed__49<>))]
		public void LoadAssetAsync2<T>(string name, Action<T> complete) where T : UnityEngine.Object
		{
		}

		public void LoadAssetAsync<T>(string name, Action<T> complete = null) where T : UnityEngine.Object
		{
		}

		public void LoadUIAsync(FunctionalModule enumModule, string name, string mediatorName, Action<GameObject> complete = null)
		{
		}

		public void LoadUIAsync(FunctionalModule module, string name, Action<GameObject> complete = null)
		{
		}

		public void LoadUIAsync(string name, string mediatorName, WindowID windowID, Action<GameObject, WindowID> complete = null)
		{
		}

		public void LoadUIAsync(string name, WindowID windowID, Action<GameObject, WindowID> complete = null)
		{
		}

		private void LoadAtlas(string[] names, Action callback)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadAssetsAsync_003Ed__56<>))]
		public void LoadAssetsAsync<T>(string[] keys, Action<string, T> completeSingle, Action<IDictionary<string, T>> completeAll) where T : class
		{
		}

		public void ReleaseAllAssetHandles()
		{
		}

		private void AddHandle(string name, AsyncOperationHandle handle)
		{
		}
	}
}
