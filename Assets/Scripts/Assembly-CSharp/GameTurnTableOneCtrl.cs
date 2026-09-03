using UnityEngine;
using UnityEngine.UI;

public class GameTurnTableOneCtrl : MonoBehaviour
{
	public Transform child;

	public Image Image_Icon;

	public DxxText Text_Value;

	public TurnTableData mData { get; private set; }

	private void Awake()
	{
	}

	public void Init(TurnTableData data)
	{
	}
}
