using UnityEngine;
using UnityEngine.UI;

public class CampBuffPreviewIcon : MonoBehaviour
{
	public DxxText Text_Title;

	public Image Image_Icon;

	public ButtonCtrl Button_Preview;

	private int buildId;

	private CampID _campID;

	private CampTileBattleStatus _status;

	private void Awake()
	{
	}

	public void init(int buildId, CampID campID, CampTileBattleStatus status)
	{
	}

	public void onButtonPreview()
	{
	}
}
