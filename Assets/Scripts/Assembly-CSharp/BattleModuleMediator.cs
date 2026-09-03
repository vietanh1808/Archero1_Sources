using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class BattleModuleMediator : WindowMediator, IMediator, INotifier
{
	public const string Event_GetGoldPosition = "Event_GetGoldPosition";

	public const string Event_GetLevel = "Event_GetLevel";

	public const string Event_GetHPParent = "Event_GetHPParent";

	public const string Event_GetJoyParent = "Event_GetJoyParent";

	public const string Event_GetTipsParent = "Event_GetTipsParent";

	public const string Event_GetArtifactParent = "Event_GetArtifactParent";

	public const string Event_GetStatueInfoParent = "Event_GetStatueInfoParent";

	private static Dictionary<string, Transform> mParents;

	public new const string NAME = "BattleModuleMediator";

	private static Dictionary<GameMode, MediatorCtrlBase> mModeCtrlList;

	private static MediatorCtrlBase mCurrentModeCtrl;

	private Transform hpparent;

	private Transform joyparent;

	private Transform tipsparent;

	private Transform statueinfoparent;

	public override List<string> OnListNotificationInterests => null;

	public static Transform GetParent(string eventname)
	{
		return null;
	}

	public BattleModuleMediator()
		: base(null)
	{
	}

	protected override void OnRegisterOnce()
	{
	}

	protected override void OnRegisterEvery()
	{
	}

	private void onAntiCheat(GameMode mode)
	{
	}

	private void init_hpparent()
	{
	}

	private void init_joyparent()
	{
	}

	private void init_tipsparent()
	{
	}

	private void init_statueinfoparent()
	{
	}

	protected override void OnRemoveAfter()
	{
	}

	public override object GetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnLanguageChange()
	{
	}
}
