using System;
using System.Collections.Generic;
using Habby.Model;
using Habby.Net.Responses;

public interface IMailManager
{
	void Init();

	void RequestMailList(bool ifForceUpdate = false);

	void CallReceiveReward(string mailId, int mailScope, Action<MailRewardResponse> callback, Action<string> onError);

	void AddMail(MailData mailInfo, bool ifChangeLang = false);

	void RemoveMail(MailData mailInfo);

	void MarkReaded(MailData mailInfo);

	void RewardReceived(MailData mailInfo);

	int GetRedCount();

	MailData GetMailById(string mailId);

	List<MailData> GetMailList();

	bool CheckShowMainPop();

	void Clear();

	void UpdateMails();

	void MarkMailReaded(string mailId, int mailScope, Action<MailReadedResponse> callback, Action<string> onError);
}
