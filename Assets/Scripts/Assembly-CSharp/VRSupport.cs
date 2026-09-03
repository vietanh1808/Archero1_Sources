using System;
using System.Collections.Generic;
using UnityEngine;

public class VRSupport
{
	private static Queue<Action> commands;

	public void ClearCommands()
	{
	}

	public void PeekCommand()
	{
	}

	public object isVRSupported(List<object> param)
	{
		return null;
	}

	public object IsQueueEmpty(List<object> param)
	{
		return null;
	}

	public object RotateObject(List<object> param)
	{
		return null;
	}

	public object ObjectLookAt(List<object> param)
	{
		return null;
	}

	protected void rotate(GameObject go, Quaternion originalRotation, Vector3 mousePosition, float speed)
	{
	}

	protected void objectLookAt(GameObject go, GameObject toLookAt, float speed)
	{
	}

	protected void recoverOffset(GameObject subcontainter, GameObject cameraContainer, float speed)
	{
	}

	protected bool RotateObject(Quaternion originalPosition, Vector3 mousePosition, GameObject cameraContainer, float rotationSpeed = 0.125f)
	{
		return false;
	}

	protected bool ObjectLookAtObject(GameObject go, GameObject cameraContainer, float rotationSpeed = 0.125f)
	{
		return false;
	}

	protected bool ObjectRecoverOffset(GameObject subcontainer, GameObject cameraContainer, float rotationSpeed = 0.125f)
	{
		return false;
	}
}
