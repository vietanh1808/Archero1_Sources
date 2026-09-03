using UnityEngine;

public class ErrorLog : MonoBehaviour
{
	public AnimationCurve curve;

	private string message;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void MyLogCallback(string condition, string stackTrace, LogType type)
	{
	}
}
