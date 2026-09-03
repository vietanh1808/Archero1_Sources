using System.Collections.Generic;
using System.IO;
using ILRuntime.Runtime.Enviorment;

namespace Habby.ContentBox
{
	public class ILRuntimeManager
	{
		private List<MemoryStream> _ms;

		private Dictionary<string, Dictionary<string, ILRMethod>> _cacheMethods;

		private Dictionary<string, bool> _tagList;

		public static ILRuntimeManager Instance => null;

		public AppDomain AppDomain { get; private set; }

		public ILRMethod GetCacheMethod(string ilrTypeName, string methodName)
		{
			return null;
		}

		public void LoadAssemblyByResource(string tag, string dll, string pdb)
		{
		}

		public void LoadAssembly(string tag, ContentDllConfig config)
		{
		}

		public void LoadAssembly(string tag, byte[] dll, byte[] pdb)
		{
		}

		public void Destroy()
		{
		}
	}
}
