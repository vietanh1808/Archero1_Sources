using UnityEngine;
using UnityEngine.UI;

public class MsgItemSmile : MsgItemBaseWithLRHeadItem
{
	public DxxText LName;

	public DxxText RName;

	public DxxText LGrade;

	public DxxText RGrade;

	public RectTransform PanelRTF;

	public Image icon;

	public GameObject Loader;

	private Vector2 LV2;

	private Vector2 RV2;

	private int chatId;

	protected override void OnInit(ChatMsgDataBase d)
	{
	}
}
