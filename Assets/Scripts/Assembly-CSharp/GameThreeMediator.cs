using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine.UI;

public class GameThreeMediator : WindowMediator, IMediator, INotifier
{
	private static GameThreeUICtrl ctrl;

	private static Text textcontent;

	private static Text textok;

	private static Text textok_shadow;

	private int count;

	public override List<string> OnListNotificationInterests => null;

	public GameThreeMediator()
		: base(null)
	{
	}

	protected override void OnRegisterOnce()
	{
	}

	protected override void OnRegisterEvery()
	{
	}

	protected override void OnRemoveAfter()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnLanguageChange()
	{
	}
}
