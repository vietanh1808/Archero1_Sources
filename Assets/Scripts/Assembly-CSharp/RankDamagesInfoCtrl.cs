using UnityEngine;

public class RankDamagesInfoCtrl : MonoBehaviour
{
	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private DxxText _textCopy;

	[SerializeField]
	private RectTransform _rtParent;

	private LocalUnityObjctPool _pool;

	public void Show(long[] damages)
	{
	}

	public void OnClose()
	{
	}
}
