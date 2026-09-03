using System;
using System.Collections.Generic;
using BestHTTP;
using Habby.Mail.Data;
using Habby.Net.Requests;
using Habby.Net.Responses;
using Habby.Tool.Http;
using UnityEngine;
using UnityEngine.Networking;

public class HabbyClient : MonoBehaviour
{
	private static HabbyClient sInstance;

	public string serverUpgradeUrl;

	public int matchWaitTime;

	public int matchPVPWaitTime;

	public static HabbyClient Instance => null;

	public string GiftcodeUrl => null;

	public string CooperationPVPUrl => null;

	public string CooperationUrl => null;

	public string PVPMatchUrl => null;

	public int PVPMatchPort => 0;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private static void OnGetAdvertismentId(string advertismentId, bool trackingEnabled, string errMesg)
	{
	}

	public static void OnGetTgaDeviceInfo(string tgaDistinctId, string tgaDeviceId)
	{
	}

	public static void OnGetSocialId(string socialId)
	{
	}

	public static void OnGetUserId(ulong userId)
	{
	}

	public static void OnGetURowID(ulong urowId)
	{
	}

	public void CheckUpgrade(AppUpgradeRequest request, Action<AppUpgradeResponse> callback, Action<string> onError = null)
	{
	}

	public void SyncUserData(UserRequest userRequest, Action<SyncUserResponse> callback, Action<string> onError = null)
	{
	}

	public void FindUser(UserRequest userRequest, Action<FindUserResponse> callback, Action<string> onError = null)
	{
	}

	public void MailList(MailListRequest mailListRequest, Action<MailListResponse> callback, Action<string> onError = null)
	{
	}

	public void ReceiveMailReward(MailRewardRequest mailListRequest, Action<MailRewardResponse> callback, Action<string> onError = null)
	{
	}

	public void MailMarkReaded(MailReadedRequest mailListRequest, Action<MailReadedResponse> callback, Action<string> onError = null)
	{
	}

	public void GetAnnouncements(int pState, HttpResponseEvent<List<AnnouncementObject>> onComplete)
	{
	}

	public void MarkAnnouncementAsRead(string announcementId, HttpResponseEvent<MarkAnnouncementResponse> onComplete)
	{
	}

	public void PacksList(PacksListRequest packsListRequest, Action<PacksListResponse, string> callback, Action<string, string> onError = null)
	{
	}

	public void CreateGiftcodeMail(GiftcodeMailCreateRequest giftcodeMailCreateRequest, Action<GiftcodeMailCreateResponse> callback, Action<string> onError = null)
	{
	}

	public HTTPRequest CooperationMatch(CooperationRequest pCooperationRequest, Action<CooperationResponse, string> callback, Action<string, string> onError = null)
	{
		return null;
	}

	public HTTPRequest CooperationMatchIsOpen(CooperationMatchIsOpenRequest pCooperationRequest, Action<CooperationMatchIsOpenResponse, string> callback, Action<string, string> onError = null)
	{
		return null;
	}

	public HTTPRequest CooperationBestHttpPost<T, K>(string pPath, T requestData, Action<K, string> callback, Action<string, string> onError = null, int pTimeOut = 10) where T : Request where K : Response
	{
		return null;
	}

	public UnityWebRequest CooperationPost<T, K>(string pPath, T requestData, Action<K, string> callback, Action<string, string> onError = null, int pTimeOut = 10) where T : Request where K : Response
	{
		return null;
	}

	public void CooperationPVPMatchIsOpen(CooperationPVPMatchIsOpenRequest pCooperationPVPRequest, Action<CooperationPVPMatchIsOpenResponse, string> callback, Action<string, string> onError = null)
	{
	}
}
