using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultipleLine : MonoBehaviour
{
	public float DownOffset;

	public bool bUseColor;

	public Color color;

	private Text _text;

	private int _curCharacterCount;

	private List<Image> _lines;

	private bool _isInitUnderline;

	private ContentSizeFitter fitter;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private List<UnderlineProperty> GetUnderlinePropertys()
	{
		return null;
	}

	private float GetWidth(int idx, IList<UICharInfo> info)
	{
		return 0f;
	}

	private Vector2 GetTextAnchorPivot(TextAnchor anchor)
	{
		return default;
	}

	private void CreateUnderLines(List<UnderlineProperty> list)
	{
	}
}
