using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class MonopolyChessGrid : MonoBehaviour
{
	private int[] gridDesign;

	private MonopolyGameData.ChessGridData mData;

	public SkeletonGraphic smoke;

	public SkeletonGraphic finalblock;

	public GameObject maskObj;

	public Image gridBg;

	public Image wenImg;

	public Image lightImg;

	public Transform child;

	public Transform content;

	private Image rewardIcon;

	private DxxText rewardCount;

	public GameObject finalEffect;

	public GameObject coinEffect;

	public GameObject redpackEffect;

	public void Init(MonopolyGameData.ChessGridData data)
	{
	}

	public void Open()
	{
	}

	private void OnRegistEvent()
	{
	}

	private void OnArrive(MonopolyGameData.ChessGridData data)
	{
	}

	private void OnEventDo(MonopolyGameData.ChessGridEvent eventName, object para)
	{
	}

	public void Refresh()
	{
	}

	public void RefreshGrid()
	{
	}

	public void OnPass(MonopolyGameData.ChessGridData grid)
	{
	}

	private void OnUnRegistEvent()
	{
	}

	public void Close()
	{
	}

	public void onButtonClick()
	{
	}
}
