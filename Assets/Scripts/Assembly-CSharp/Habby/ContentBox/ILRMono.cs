using System.Collections.Generic;
using ILRuntime.CLR.TypeSystem;
using UnityEngine;

namespace Habby.ContentBox
{
	public class ILRMono : MonoBehaviour
	{
		public string SpaceName;

		public string ClassName;

		[HideInInspector]
		public List<ILRMonoRefrence> RefrenceObjs;

		private Dictionary<string, object> _refrenceObjs_ILR;

		private object _ILRObj;

		private IType _ILRType;

		public Dictionary<string, object> Refrence_ILR => null;

		public object ILRObj => null;

		private IType ILRType => null;

		protected virtual string _ilrName => null;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void OnTriggerEnter(Collider other)
		{
		}

		protected virtual void OnTriggerStay(Collider other)
		{
		}

		protected virtual void OnTriggerExit(Collider other)
		{
		}

		protected virtual void OnTriggerEnter2D(Collider2D collision)
		{
		}

		protected virtual void OnTriggerStay2D(Collider2D collision)
		{
		}

		protected virtual void OnTriggerExit2D(Collider2D collision)
		{
		}

		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		protected virtual void OnCollisionStay(Collision collision)
		{
		}

		protected virtual void OnCollisionExit(Collision collision)
		{
		}

		protected virtual void OnCollisionEnter2D(Collision2D collision)
		{
		}

		protected virtual void OnCollisionStay2D(Collision2D collision)
		{
		}

		protected virtual void OnCollisionExit2D(Collision2D collision)
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void OnApplicationPause(bool pause)
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public object GetRefrenceObj_ILR(string name)
		{
			return null;
		}

		private void FillRefrenceDic_ILR()
		{
		}

		protected void CreateILRObj()
		{
		}

		protected void CreateILRType()
		{
		}

		public void RunMethod(string methodName)
		{
		}

		public object RunILRMethod(string methodName, params object[] args)
		{
			return null;
		}

		protected string LogString(string message)
		{
			return null;
		}
	}
}
