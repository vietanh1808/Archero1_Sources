using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Net;
using UnityEngine;
using UnityEngine.Networking;

public class HTTPSendClient : MonoBehaviour
{
	public class WebRequestCert : CertificateHandler
	{
		protected override bool ValidateCertificate(byte[] certificateData)
		{
			return false;
		}
	}

	private class CArcherBattleSSLCertVerify : CertificateHandler
	{
		private static string[] PUB_KEYS;

		private static string[] CERT_HASHS;

		protected override bool ValidateCertificate(byte[] certificateData)
		{
			return false;
		}
	}

	private class CArcherSSLCertVerify : CertificateHandler
	{
		private static string[] PUB_KEYS;

		private static string[] CERT_HASHS;

		protected override bool ValidateCertificate(byte[] certificateData)
		{
			return false;
		}
	}

	public class CheatData
	{
		public ulong user_id;

		public ulong server_time;

		public long ban_timestamp;
	}

	public class CheatOnceData
	{
		public ulong user_id;

		public int type;

		public long realvalue;

		public long referencevalue;

		public int prop_type;

		public string attr_name;
	}

	public class ServerMaintain
	{
		public ulong finish_time_stamp;

		public ulong server_time;
	}

	[CompilerGenerated]
	private sealed class _003CsendInternal_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HTTPSendClient _003C_003E4__this;

		public NetCacheOne senddata;

		public Action<NetResponse> callback;

		public int index;

		private UnityWebRequest _003C_uwr_003E5__2;

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
		public _003CsendInternal_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003Csend_delay_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int delaytime;

		public HTTPSendClient _003C_003E4__this;

		public NetCacheOne senddata;

		public int index;

		public Action<NetResponse> callback;

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
		public _003Csend_delay_003Ed__19(int _003C_003E1__state)
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

	private const bool OpenAddRemoveCache = true;

	public ushort sendcode;

	public SendType mSendType;

	private int sendcount;

	private Dictionary<int, UnityWebRequest> uwrlist;

	private Dictionary<int, float> starttimes;

	private float starttime;

	private bool bShowMask;

	private float mStartTime;

	private byte[] receive;

	private int sendlastcount;

	private int timeout;

	private int count;

	private string mIP;

	private List<byte> sha_list;

	private bool IsForce => false;

	private bool IsCache => false;

	private bool IsLoop => false;

	private bool IsUploadZip => false;

	public void StartSend<T1>(T1 packet, SendType sendtype, Action<NetResponse> callback) where T1 : CProtocolBase
	{
	}

	public void StartSend<T1>(T1 packet, SendType sendtype, int count, int time, Action<NetResponse> callback) where T1 : CProtocolBase
	{
	}

	public void StartSend(NetCacheOne senddata, Action<NetResponse> callback)
	{
	}

	private void start_send(NetCacheOne senddata, Action<NetResponse> callback)
	{
	}

	[IteratorStateMachine(typeof(_003Csend_delay_003Ed__19))]
	private IEnumerator send_delay(int delaytime, NetCacheOne senddata, int index, Action<NetResponse> callback)
	{
		return null;
	}

	private float set_starttime(int index)
	{
		return 0f;
	}

	private float get_starttime(int index)
	{
		return 0f;
	}

	private IProtocol CreateProtocol(ushort code, CustomBinaryReader reader)
	{
		return null;
	}

	private void DoResponse(ushort code, byte[] postbytes, IProtocol data)
	{
	}

	private string GetSHA256(long time, byte[] body)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CsendInternal_003Ed__36))]
	private IEnumerator sendInternal(NetCacheOne senddata, int index, Action<NetResponse> callback)
	{
		return null;
	}

	private bool check_done(int index)
	{
		return false;
	}

	private void do_callback(Action<NetResponse> callback, NetResponse n)
	{
	}

	private float get_timeout(int index)
	{
		return 0f;
	}

	private bool isTimeOut(int index)
	{
		return false;
	}

	private void CacheError(NetCacheOne data, bool reduce_count)
	{
	}

	private void RemoveCache(NetCacheOne data)
	{
	}

	private void show_cheat_window(string jsoninfo)
	{
	}

	private void show_server_maintain(string jsoninfo)
	{
	}

	private void show_request_cheat_once(NetCacheOne senddata, string jsoninfo)
	{
	}

	private void CheckGameOverCheat(NetCacheOne senddata)
	{
	}

	private void DeInit()
	{
	}

	private void DeInitBefore()
	{
	}

	private void KillRequest(UnityWebRequest request)
	{
	}
}
