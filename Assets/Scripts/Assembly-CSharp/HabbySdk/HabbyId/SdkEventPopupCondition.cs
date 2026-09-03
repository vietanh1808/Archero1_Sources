namespace HabbySdk.HabbyId
{
	public enum SdkEventPopupCondition
	{
		privacy_agreement_uncheck = 0,
		receive_emails_uncheck = 1,
		registered_email_input = 2,
		diff_registered_email_input = 3,
		frequent_login = 4,
		unregistered_email_input = 5,
		code_limitation_reached = 6,
		code_wrong = 7,
		code_timeout = 8,
		code_server_busy = 9
	}
}
