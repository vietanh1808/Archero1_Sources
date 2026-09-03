using System.Collections.Generic;
using UnityEngine;

namespace Poco
{
	public class UnityNode : AbstractNode
	{
		public static Dictionary<string, string> TypeNames;

		public static string DefaultTypeName;

		private GameObject gameObject;

		private Renderer renderer;

		private RectTransform rectTransform;

		private Rect rect;

		private Vector2 objectPos;

		private List<string> components;

		private Camera camera;

		public UnityNode(GameObject obj)
		{
		}

		public override AbstractNode getParent()
		{
			return null;
		}

		public override List<AbstractNode> getChildren()
		{
			return null;
		}

		public override object getAttr(string attrName)
		{
			return null;
		}

		public override Dictionary<string, object> enumerateAttrs()
		{
			return null;
		}

		private Dictionary<string, object> GetPayload()
		{
			return null;
		}

		private string GuessObjectTypeFromComponentNames(List<string> components)
		{
			return null;
		}

		private bool GameObjectVisible(Renderer renderer, List<string> components)
		{
			return false;
		}

		private int GameObjectLayer()
		{
			return 0;
		}

		private string GameObjectLayerName()
		{
			return null;
		}

		private bool GameObjectClickable(List<string> components)
		{
			return false;
		}

		private string GameObjectText()
		{
			return null;
		}

		private string GameObjectTag()
		{
			return null;
		}

		private List<string> GameObjectAllComponents()
		{
			return null;
		}

		private Dictionary<string, float> GameObjectzOrders()
		{
			return null;
		}

		private Rect GameObjectRect(Renderer renderer, RectTransform rectTransform)
		{
			return default;
		}

		private float[] GameObjectPosInScreen(Vector3 objectPos, Renderer renderer, RectTransform rectTransform, Rect rect)
		{
			return null;
		}

		private Canvas GetRootCanvas(GameObject gameObject)
		{
			return null;
		}

		private float[] GameObjectSizeInScreen(Rect rect, RectTransform rectTransform)
		{
			return null;
		}

		private float[] GameObjectAnchorInScreen(Renderer renderer, Rect rect, Vector3 objectPos)
		{
			return null;
		}

		private string GetImageSourceTexture()
		{
			return null;
		}

		protected static Vector2 WorldToGUIPoint(Camera camera, Vector3 world)
		{
			return default;
		}

		protected static Rect RendererToScreenSpace(Camera camera, Renderer renderer)
		{
			return default;
		}

		protected static Rect RectTransformToScreenSpace(RectTransform rectTransform)
		{
			return default;
		}

		public static bool SetText(GameObject go, string textVal)
		{
			return false;
		}
	}
}
