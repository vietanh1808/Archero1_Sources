using System;
using System.Collections.Generic;
using Habby.Model;
using Habby.Net.Responses;
using TableTool;

public class HabbyMailManager : IMailManager
{
	private static readonly string MailUrlTest;

	private static readonly string MailUrl;

	public static IMailManager Instance;

	public bool IfChangeLang;

	private HashSet<string> mailIds;

	private List<MailData> mailList;

	public static string UserServerUrl => null;

	public static bool IfUseTestData => false;

	public static bool IfShowDebugInfo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	static HabbyMailManager()
	{
	}

	private HabbyMailManager()
	{
	}

	public void Init()
	{
	}

	public bool CheckShowMainPop()
	{
		return false;
	}

	public void AddMail(MailData mailInfo, bool ifChangeLang = false)
	{
	}

	public void RequestMailList(bool ifForceUpdate = false)
	{
	}

	public List<MailData> GetMailList()
	{
		return null;
	}

	public void RemoveMail(MailData mailInfo)
	{
	}

	public void MarkReaded(MailData mailInfo)
	{
	}

	public void UpdateMailLanguage(MailData mailInfo)
	{
	}

	public void UpdateMails()
	{
	}

	private void UpdateMailStates()
	{
	}

	public void MarkMailReaded(string mailId, int mailScope, Action<MailReadedResponse> callback, Action<string> onError)
	{
	}

	public void CallReceiveReward(string mailId, int mailScope, Action<MailRewardResponse> callback, Action<string> onError)
	{
	}

	public void RewardReceived(MailData mailInfo)
	{
	}

	public static void AddMailRewardToLocal(MailReward reward, List<PlayerCharacter_Skin> SkinList = null)
	{
	}

	public MailData GetMailById(string mailId)
	{
		return null;
	}

	public void Clear()
	{
	}

	public int GetRedCount()
	{
		return 0;
	}

	private void OnResponseMail(MailListResponse response)
	{
	}

	private void OnDebugResponseMail()
	{
	}
}
