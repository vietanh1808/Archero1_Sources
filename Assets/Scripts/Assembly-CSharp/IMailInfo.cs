using Habby.Model;

public interface IMailInfo
{
	uint MailID { get; }

	int MailScope { get; }

	int MailType { get; }

	string Title { get; }

	string Content { get; }

	string BeginTime { get; }

	string EndTime { get; }

	bool IfReaded { get; }

	bool IfReceived { get; }

	bool IfHaveReward { get; }

	bool IfShowRed { get; }

	MailReward[] Rewards { get; }

	string GetRewardsString();
}
