using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dxx.Net
{
	[Serializable]
	public class NetCaches : LocalSaveBase
	{
		public ulong serveruserid;

		public List<NetCacheOne> mList;

		[JsonIgnore]
		private const float mCheckDelay = 0.1f;

		[JsonIgnore]
		private int mCount;

		[JsonIgnore]
		private NetCacheOne mCurrent;

		[JsonIgnore]
		private bool bSendLogin;

		[JsonIgnore]
		private float mSendLoginStartTime;

		[JsonIgnore]
		private bool bCurrentSendOver;

		[JsonIgnore]
		private bool bShowLoading;

		[JsonIgnore]
		private List<NetCacheOne> mSendList;

		[JsonIgnore]
		private int try_login_count;

		[JsonIgnore]
		private bool bEnable;

		protected override string filename => null;

		[JsonIgnore]
		public bool IsEmpty => false;

		public static string GetFileName(ulong serveruserid)
		{
			return null;
		}

		public static void DeleteFile(ulong serveruserid)
		{
		}

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Init()
		{
		}

		public void Add(NetCacheOne data, bool reduce_count)
		{
		}

		public void Remove(NetCacheOne data)
		{
		}

		public void SetEnable(bool value)
		{
		}

		public void Copy(NetCaches data)
		{
		}

		private void Clear()
		{
		}

		public bool HaveCache()
		{
			return false;
		}

		public void CheckBattleCache(Action<bool> onComplete)
		{
		}

		public bool CheckGameOverLevelCache()
		{
			return false;
		}

		private void OnUpdateNet()
		{
		}

		private void OnUpdate()
		{
		}

		private void send_next()
		{
		}

		private NetCacheOne find_next()
		{
			return null;
		}

		private void remove_send_one(NetCacheOne one)
		{
		}

		private void show_loading(bool value)
		{
		}

		private bool is_loadingshow()
		{
			return false;
		}
	}
}
