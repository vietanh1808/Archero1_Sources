using UnityEngine;

public class ArtifactActivityTipsUICtrl : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl _btnClose;

	[SerializeField]
	private Transform _content;

	[SerializeField]
	private DxxText _copyOne;

	[SerializeField]
	private DxxText _textTitle;

	private LocalUnityObjctPool _pool;

	public void Show(string[] introduces, string title = "")
	{
	}
}
