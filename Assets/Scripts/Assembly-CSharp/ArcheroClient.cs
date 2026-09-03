using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Habby.Net.Responses;
using UnityEngine;
using UnityEngine.UI;

public class ArcheroClient : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ArcheroClient _003C_003E4__this;

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
		public _003CStart_003Ed__9(int _003C_003E1__state)
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

	public Text serverInfo;

	public Text systemText;

	public Text mailText;

	public Text rewardText;

	public Button sendMailBtn;

	public Button reqRewardBtn;

	public HabbyClient habbyClient;

	public string rewardMailId;

	public int rewardMailScope;

	[IteratorStateMachine(typeof(_003CStart_003Ed__9))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	public void OnClickSendMail()
	{
	}

	public void OnClickReqReward()
	{
	}

	private void OnMailListResponed(MailListResponse reponse)
	{
	}

	private void OnMailRewarded(MailRewardResponse response)
	{
	}
}
