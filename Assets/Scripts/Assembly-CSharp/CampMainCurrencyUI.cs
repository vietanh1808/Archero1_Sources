using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CampMainCurrencyUI : MonoBehaviour
{
	[SerializeField]
	private GameObject peerageObj;

	[SerializeField]
	private GameObject ironArrowObj;

	[SerializeField]
	private GameObject goldArrowObj;

	[SerializeField]
	private GameObject personalTalentScoreObj;

	[SerializeField]
	private GameObject teamTalentScoreObj;

	[SerializeField]
	private GameObject teamBigTalentScoreObj;

	[SerializeField]
	private DxxText actionPower;

	[SerializeField]
	private DxxText ironArrow;

	[SerializeField]
	private DxxText goldArrow;

	[SerializeField]
	private DxxText personalTalentScore;

	[SerializeField]
	private DxxText teamTalentScore;

	[SerializeField]
	private DxxText peerageName;

	[SerializeField]
	private DxxText personalBigTalentScore;

	[SerializeField]
	private Image peerageIcon;

	[SerializeField]
	private ButtonCtrl peerageBtn;

	[SerializeField]
	private ButtonCtrl actionPowerBtn;

	public GameObject tileIns;

	public Transform actionTrans;

	[SerializeField]
	private GameObject regionObj;

	private CampManager CampManager => null;

	public void Refresh()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshPeerage()
	{
	}

	private void RefreshBtn()
	{
	}

	public void ShowNormal(bool isWorld)
	{
	}

	public void ShowTalent()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}
}
