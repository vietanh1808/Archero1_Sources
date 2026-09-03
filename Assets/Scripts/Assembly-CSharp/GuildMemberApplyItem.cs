using Habby.Guild.Data;
using UnityEngine;

public class GuildMemberApplyItem : MonoBehaviour
{
	[SerializeField]
	private DxxText txtName;

	[SerializeField]
	private DxxText txtScore;

	[SerializeField]
	private DxxText txtTime;

	[SerializeField]
	private ButtonCtrl btnReject;

	[SerializeField]
	private ButtonCtrl btnAccept;

	[SerializeField]
	private HeadItem headItem;

	private UserInfoList.UserInfo data;

	private string userId;

	private string actionId;

	private GuildApplyUICtrl uiCtrl;

	private void Awake()
	{
	}

	private void Dismiss()
	{
	}

	public void SetData(UserInfoList.UserInfo userInfo)
	{
	}

	public void SetParentUI(GuildApplyUICtrl uiCtrl)
	{
	}
}
