using DG.Tweening;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class Act5thHuntingGameArrowCreator : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private RectTransform bowTrans;

	[SerializeField]
	private RectTransform arrowTrans;

	[SerializeField]
	private GameObject sendArrowStatus;

	[SerializeField]
	private GameObject readySendStatus;

	private bool isAllowSendArrow;

	private SequencePool sequencePool;

	private Tween delayCall;

	private Act5thHuntingEntityManager HuntingEntityManager => null;

	private Act5thHuntingManager HuntingManager => null;

	private Act5thHuntingArrowCreatorData ArrowCreatorData => null;

	private bool HaveEnoughArrow => false;

	private bool AllowSendArrow => false;

	private float DelayCallTime => 0f;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void GameStar()
	{
	}

	public void GameEnd()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshStatus()
	{
	}

	public void SendArrow(Vector2 pointerPos)
	{
	}

	private void CreateArrow(float angle, Vector2 pos, Act5thHuntingArrowType arrowType)
	{
	}
}
