using System;
using System.Collections;
using System.Collections.Generic;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

public class CoroutineAdapter : CrossBindingAdaptor
{
	internal class Adaptor : IEnumerator<object>, IEnumerator, IDisposable, CrossBindingAdaptorType
	{
		private ILTypeInstance instance;

		private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

		private IMethod mCurrentMethod;

		private bool mCurrentMethodGot;

		private IMethod mDisposeMethod;

		private bool mDisposeMethodGot;

		private IMethod mMoveNextMethod;

		private bool mMoveNextMethodGot;

		private IMethod mResetMethod;

		private bool mResetMethodGot;

		public ILTypeInstance ILInstance => null;

		public object Current => null;

		public Adaptor()
		{
		}

		public Adaptor(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	public override Type BaseCLRType => null;

	public override Type[] BaseCLRTypes => null;

	public override Type AdaptorType => null;

	public override object CreateCLRInstance(ILRuntime.Runtime.Enviorment.AppDomain appdomain, ILTypeInstance instance)
	{
		return null;
	}
}
