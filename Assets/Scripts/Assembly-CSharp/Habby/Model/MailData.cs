using System;

namespace Habby.Model
{
	[Serializable]
	public sealed class MailData
	{
		public enum eMailType
		{
			eNormalMail = 1,
			eRewardMail = 2,
			eForcePopMail = 3,
			eInvalidMail = 4
		}

		public string mailId;

		public int mailScope;

		public int mailType;

		public string mailTitle;

		public string mailContent;

		public string createAt;

		public string expireAt;

		public int announcementType;

		public bool readed;

		public bool claimed;

		public int ifRemain;

		public MailReward[] rewards;

		public bool IfHaveReward => false;

		public long BeginTime => 0L;

		public long EndTime => 0L;

		public bool IfReaded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IfRewardReceived
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IfShowRed()
		{
			return false;
		}

		public bool IfRemainAfterRead()
		{
			return false;
		}

		public bool IfCanShow()
		{
			return false;
		}

		public bool isReadedNew()
		{
			return false;
		}

		public bool isValidTime()
		{
			return false;
		}
	}
}
