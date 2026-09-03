using UnityEngine;
using UnityEngine.UI;

public class TextAutoFitter : Text
{
	private readonly UIVertex[] _tmpVerts;

	public int VisibleLines { get; private set; }

	private void _UseFitSettings()
	{
	}

	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}
}
