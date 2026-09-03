using HabbySdk.HabbyStore;
using UnityEngine;

public class OfficialStoreUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl _btnClose;

	private IHabbyStoreManager _storeManager;

	private bool _isWaitingForLogin;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private bool ValidateSDK()
	{
		return false;
	}

	private void SubscribeEvents()
	{
	}

	private void UnsubscribeEvents()
	{
	}

	private void OnStoreResult(bool success, string message)
	{
	}

	private void OnStoreOpened()
	{
	}

	private void OnStoreClosed()
	{
	}

	private void OnStoreError(HabbyStoreError error)
	{
	}

	private void OnLoginFlowStarted()
	{
	}

	private void OnLoginFlowCompleted(bool success)
	{
	}

	private void android_escape()
	{
	}

	private void Update()
	{
	}
}
