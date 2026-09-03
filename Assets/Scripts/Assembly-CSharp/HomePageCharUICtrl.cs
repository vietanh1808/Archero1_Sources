using System.Collections.Generic;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using homepage;

public class HomePageCharUICtrl : MonoBehaviour
{
	public enum UIState
	{
		eNormal = 0,
		eWear = 1,
		eWearing = 2,
		eEmptyWearing = 3
	}

	public int MeshOrder;

	public HeroEquipsVO heroEquipsVO;

	public GameObject window;

	[Header("装备位")]
	public List<HomePageEquipBGCtrl> mEquipBGList;

	public VerticalLayoutGroup Left;

	public VerticalLayoutGroup Right;

	public RectTransform board;

	public RectTransform mHeroContainer;

	public CharUIHeroCtrl mHeroCtrl;

	public ButtonCtrl Button_Light;

	[Header("穿戴时的装备显示位置")]
	public Transform wearctrlpos;

	private List<EquipOneCtrl> mEquipItemList;

	private Sequence seq;

	private UIState state;

	public void OnInit(object mData)
	{
	}

	private void showwindow(bool value)
	{
	}

	public void OnSetArgs(object o)
	{
	}

	public void OnOpen()
	{
	}

	private void UpdateHero(bool changehero)
	{
	}

	private void UpdateEquipsList(bool changehero)
	{
	}

	private void ChangeState(UIState state, bool force = false)
	{
	}

	private void DoWearAction()
	{
	}

	private void StopWearAction()
	{
	}

	private void MissAdd()
	{
	}

	public void OnClose()
	{
	}

	private void KillSequence()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public object OnGetEvent(string eventName)
	{
		return null;
	}

	public void OnLanguageChange()
	{
	}
}
