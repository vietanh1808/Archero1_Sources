using System;
using System.Collections.Generic;
using UnityEngine;

namespace Habby.ContentBox
{
	[Serializable]
	public class ILRMonoRefrence
	{
		[HideInInspector]
		public string Key;

		[HideInInspector]
		public UnityEngine.Object Value;

		[HideInInspector]
		public List<UnityEngine.Object> ArrayValue;

		[HideInInspector]
		public int IntValue;

		[HideInInspector]
		public float FloatValue;

		[HideInInspector]
		public bool BoolValue;

		[HideInInspector]
		public string StringValue;

		[HideInInspector]
		public ILRMonoRefrenceType RefrenceType;
	}
}
