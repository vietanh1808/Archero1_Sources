using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Habby.Guild.Data;
using Habby.Guild.Tool;
using Habby.GuildSDK.Cache;
using UnityEngine;

public class GuildManager : MonoBehaviour
{
	public class GuildConfigFile
	{
		public long IMAppID;

		public long IMAppIDTest;

		public long IMquasiAppID;

		public string GuildServerUrl;

		public string GuildQuasiServerUrl;

		public string GuildTestServerUrl;

		public string GuildImUrl;

		public string GuildQuasiImUrl;

		public string GuildTestImUrl;

		public int UseGameServerLogin;
	}

	public enum LoginState
	{
		none = 0,
		logining = 1,
		succ = 2,
		fail = 3,
		logouting = 4
	}

	[CompilerGenerated]
	private sealed class _003COnUpdate_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GuildManager _003C_003E4__this;

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
		public _003COnUpdate_003Ed__116(int _003C_003E1__state)
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
	private sealed class _003CWaitRefGuildInfo_003Ed__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float dt;

		public GuildManager _003C_003E4__this;

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
		public _003CWaitRefGuildInfo_003Ed__118(int _003C_003E1__state)
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

	private static GuildManager _Instance;

	private static bool isShowLoading;

	private static Dictionary<int, int> levelEXPMap;

	[CompilerGenerated]
	private ReciveNewMessageDelgate m_OnC2CMessageEvent;

	[CompilerGenerated]
	private ReciveNewMessageDelgate m_OnNoticeMessageEvent;

	[CompilerGenerated]
	private Action<GuildInfoData> m_OnGuildLevelUpEvent;

	[CompilerGenerated]
	private Action<GuildMessageEntity> m_OnEventAddMessage;

	[CompilerGenerated]
	private Action<List<UpdateActionItem>> m_OnEventUpdateMessage;

	private bool changeUser;

	private LoginGuildObject loginObject;

	private WaitForSeconds _wait;

	private IEnumerator updateRefGuildInfoItor;

	public List<ActivityInfo> validActivities;

	public static GuildManager Instance => null;

	public string GuildID => null;

	public string UserId => null;

	public bool IsInGuild => false;

	public GuildMemberInfo SelfInfo => null;

	public GuildInfoData SelfGuildInfo => null;

	public GuildSigninInfo SelfSiginInfo => null;

	public LoginState loginState { get; private set; }

	public LoginState loginChat { get; private set; }

	public bool IsLoginSucc => false;

	public bool IsCacheMembers => false;

	public CacheMembersObject cacheMembersObject => null;

	public CacheGuildInfoObject cacheGuildInfoObject => null;

	public CacheGuildSigninInfoObject cacheGuildSigninInfoObject => null;

	public CacheApplyListObject cacheApplyListObject { get; private set; }

	public CacheActivityListObject CacheActivityListObject { get; private set; }

	private CacheAllObject cacheAllObj => null;

	public CacheGuildQuestInfo cacheGuildQuestInfo { get; private set; }

	public event ReciveNewMessageDelgate OnC2CMessageEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ReciveNewMessageDelgate OnNoticeMessageEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<GuildInfoData> OnGuildLevelUpEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<GuildMessageEntity> OnEventAddMessage
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<List<UpdateActionItem>> OnEventUpdateMessage
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void InitSDK()
	{
	}

	public void setGuildUrl(int tag)
	{
	}

	public static int GetUserServerTag()
	{
		return 0;
	}

	public static int GetGuildLevelXp(int level)
	{
		return 0;
	}

	public static void ChangeGuildExp(int exp)
	{
	}

	public static void RewardScoreExp(int score, int exp)
	{
	}

	public static void ChangeDonateCount(int index, int add)
	{
	}

	public static void GuildDaySigin()
	{
	}

	public static void GuildWeekSigin()
	{
	}

	public void ChangeSelfScore(int score)
	{
	}

	public void setLoginState(LoginState state)
	{
	}

	private void Init()
	{
	}

	public void SetUser(ulong pUser)
	{
	}

	public void Login(Action<int> OnComplete)
	{
	}

	private void LogOut(Action logoutDone)
	{
	}

	private void ReLogin(Action<int> OnComplete)
	{
	}

	private bool StartLogin(Action<int> OnComplete)
	{
		return false;
	}

	private void OnReciveEvent(MesssageEventBase pData)
	{
	}

	private void OnReciveAllMessage(GuildMessageEntity pMsg)
	{
	}

	private void OnReciveUpdateMessage(GuildMessageEntity pMsg)
	{
	}

	private void OnReciveGuildMessage(GuildMessageEntity pMsg)
	{
	}

	private void OnReciveNoticeMessage(GuildMessageEntity pMsg)
	{
	}

	private void OnReciveC2CNewMessage(GuildMessageEntity pMsg)
	{
	}

	private void OnReciveGroupSystemMessage(GroupSystemMessageEntity pMsg)
	{
	}

	private void OnReciveGuildSystemMessage(GroupSystemMessageEntity pMsg)
	{
	}

	private void OnReceiveActionUpdate(GroupSystemMessageEntity pMsg)
	{
	}

	private void OnJoinedGuild(ActionData pData)
	{
	}

	private void OnLoginChatAuthorised()
	{
	}

	private void OnLoginChatFailed()
	{
	}

	private void OnKickedGuild(ActionData pData)
	{
	}

	private void OnGuildLevelUp(GuildInfoData guildInfoData)
	{
	}

	private void InitEvent()
	{
	}

	public void CacheMembers(CacheDoneDelgate action)
	{
	}

	public void CacheGuildInfo(CacheDoneDelgate action)
	{
	}

	public void CacheSiginInfo(CacheDoneDelgate action)
	{
	}

	public void CacheApplyList(CacheDoneDelgate action)
	{
	}

	public void CacheActivityObject(CacheDoneDelgate action)
	{
	}

	public CacheAllObject CacheAll(CacheDoneDelgate action)
	{
		return null;
	}

	public static void CacheQuestInfo(CacheDoneDelgate action)
	{
	}

	public void RestCacheAll()
	{
	}

	private void TryReportJoin()
	{
	}

	private void OnCachedGuildInfo()
	{
	}

	private void OnCachedGuildSiginInfo()
	{
	}

	private void OnCachedMembers()
	{
	}

	private void OnCacheApplyList()
	{
	}

	private void OnCacheActivity()
	{
	}

	[IteratorStateMachine(typeof(_003COnUpdate_003Ed__116))]
	private IEnumerator OnUpdate()
	{
		return null;
	}

	private void CloseAutoRefInfo()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitRefGuildInfo_003Ed__118))]
	private IEnumerator WaitRefGuildInfo(float dt)
	{
		return null;
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public static SdkManager.TableEventGuildData GetTableEventGuildData(int tabTag)
	{
		return null;
	}

	public static bool GetActivityRewards(int activityId, GetActivityBoxData data)
	{
		return false;
	}

	public ActivityInfo GetActivity(int activityId)
	{
		return null;
	}

	public bool SetActivityCache(ActivityInfo activity)
	{
		return false;
	}

	public ActivityGiftBox GetGift(int activityId, int giftId)
	{
		return null;
	}

	public bool GetGainableGiftInfo(out int activityId, out ActivityGiftBox box, out int index)
	{
		activityId = default;
		box = null;
		index = default;
		return false;
	}

	public void FirstGainableBoxIndex(int activityId, out ActivityGiftBox boxInfo, out int index)
	{
		boxInfo = null;
		index = default;
	}

	public void GetFirstLockedBoxIndex(int activityId, out ActivityGiftBox boxInfo, out int index)
	{
		boxInfo = null;
		index = default;
	}

	public int ValidateActivityList(out long minDailyEndTime)
	{
		minDailyEndTime = default;
		return 0;
	}
}
