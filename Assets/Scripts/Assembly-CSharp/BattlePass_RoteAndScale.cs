using UnityEngine;
using UnityEngine.UI;

public class BattlePass_RoteAndScale : MonoBehaviour
{
	public bool isRote;

	public float roteSpeed;

	private Vector3 roteVec;

	public bool isScale;

	public float minScale;

	public float maxScale;

	public float scaleTime;

	public bool isRandomScaleTime;

	public float randomScaleMinTime;

	private Vector3 scaleSpeed;

	private bool isScaleUp;

	public bool isAlphaImage;

	public float tweenAlphaTime;

	public float tweenAlphaTarget;

	public Image tweenImage;

	private float tweenAlphaSpeed;

	private bool isAlphaUp;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
