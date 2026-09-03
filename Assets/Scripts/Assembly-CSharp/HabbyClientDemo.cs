using Habby.Model;
using Habby.Net.Responses;
using UnityEngine;
using UnityEngine.UI;

public class HabbyClientDemo : MonoBehaviour
{
	public Text status;

	public Text adid;

	public Text errorText;

	private void Start()
	{
	}

	public void CheckUpgrade()
	{
	}

	private void OnUpgradeResponed(AppUpgradeResponse response)
	{
	}

	public void SyncUserData(UserData data)
	{
	}

	private void OnUserSyncResponed(SyncUserResponse response)
	{
	}

	public void GetMailList()
	{
	}

	public void OnMailListResponed(MailListResponse reponse)
	{
	}

	public void ClaimRewardFromMail(string mailId, int mailScope, UserData data)
	{
	}

	public void OnMailRewarded(MailRewardResponse response)
	{
	}
}
