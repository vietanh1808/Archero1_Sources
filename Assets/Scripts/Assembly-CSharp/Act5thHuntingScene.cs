using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class Act5thHuntingScene : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private DxxText sceneName;

	[SerializeField]
	private Image sceneImg;

	[SerializeField]
	private ButtonCtrl leftArrowBtn;

	[SerializeField]
	private ButtonCtrl rightArrowBtn;

	[SerializeField]
	private ButtonCtrl previewBtn;

	[SerializeField]
	private GameObject sceneLockStatus;

	[SerializeField]
	private GameObject sceneUnlockStatus;

	[SerializeField]
	private FitContentText sceneLockDesc;

	[SerializeField]
	private Act5thHuntingTalentItem talentItemItem;

	[SerializeField]
	private Transform less4TalentItemParent;

	[SerializeField]
	private Transform more4TalentItemParent;

	[SerializeField]
	private ScrollRect more4TalentScrollRect;

	[SerializeField]
	private GameObject more4TalentObj;

	[SerializeField]
	private GameObject less4TalentObj;

	[SerializeField]
	private GameObject lockImg;

	private LocalUnityObjctPool pool;

	private Act5thHuntingManager HuntingManager => null;

	private Act5thHuntingSceneData HuntingSceneData => null;

	private Act5thHuntingTalentData HuntingTalentData => null;

	private int CurSelectSceneID => 0;

	private void InitPool()
	{
	}

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

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickLeftBtn()
	{
	}

	private void ClickRightBtn()
	{
	}

	private void ClickPreviewBtn()
	{
	}
}
