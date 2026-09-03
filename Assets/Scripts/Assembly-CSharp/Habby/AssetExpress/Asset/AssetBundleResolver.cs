using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Habby.AssetExpress.Model;
using UnityEngine;
using UnityEngine.Events;

namespace Habby.AssetExpress.Asset
{
	public abstract class AssetBundleResolver
	{
		[CompilerGenerated]
		private sealed class _003C_LoadAssetAsync_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AssetBundleResolver _003C_003E4__this;

			public string assetName;

			public UnityAction<UnityEngine.Object> callback;

			private AssetBundleCreateRequest _003Cabcr_003E5__2;

			private AssetBundleRequest _003Cabr_003E5__3;

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
			public _003C_LoadAssetAsync_003Ed__17(int _003C_003E1__state)
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
		private sealed class _003C_LoadAssetAsync_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AssetBundleResolver _003C_003E4__this;

			public string assetName;

			public UnityAction<UnityEngine.Object> callback;

			public Type type;

			private AssetBundleCreateRequest _003Cabcr_003E5__2;

			private AssetBundleRequest _003Cabr_003E5__3;

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
			public _003C_LoadAssetAsync_003Ed__18(int _003C_003E1__state)
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

		protected string BundleRootPath;

		public List<BundleFileInfo> BundleList { get; protected set; }

		public AssetBundleResolver(string bundlePath)
		{
		}

		protected abstract List<BundleFileInfo> LoadBundleList();

		public BundleFileInfo GetBundleInfo(string bundleName)
		{
			return null;
		}

		public virtual bool IsBundleAvailable(string bundleName)
		{
			return false;
		}

		public virtual bool IsBundleAvailable(string bundleName, Hash128 hash)
		{
			return false;
		}

		public virtual AssetBundle LoadBundle(string bundleName)
		{
			return null;
		}

		public virtual AssetBundleCreateRequest LoadBundleAsync(string bundleName)
		{
			return null;
		}

		public AssetInfo GetAssetInfo(string asset)
		{
			return null;
		}

		public void LoadAllAssetsFromBundle(string bundle)
		{
		}

		public string[] GetAllDependencies(string bundleName)
		{
			return null;
		}

		public void LoadAssetAsync(string assetName, UnityAction<UnityEngine.Object> callback)
		{
		}

		public void LoadAssetAsync(string assetName, Type type, UnityAction<UnityEngine.Object> callback)
		{
		}

		[IteratorStateMachine(typeof(_003C_LoadAssetAsync_003Ed__17))]
		private IEnumerator _LoadAssetAsync(string assetName, UnityAction<UnityEngine.Object> callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_LoadAssetAsync_003Ed__18))]
		private IEnumerator _LoadAssetAsync(string assetName, Type type, UnityAction<UnityEngine.Object> callback)
		{
			return null;
		}
	}
}
