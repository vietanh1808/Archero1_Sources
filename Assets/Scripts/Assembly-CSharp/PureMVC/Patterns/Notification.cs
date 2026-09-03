using System;
using System.Text;
using PureMVC.Interfaces;

namespace PureMVC.Patterns
{
	[Serializable]
	public class Notification : INotification
	{
		private StringBuilder strTemp;

		public string Name { get; private set; }

		public object Body { get; set; }

		public string Type { get; set; }

		public string FileName { get; private set; }

		public string FuncName { get; private set; }

		public int LineNumber { get; private set; }

		public void getDebugInfo()
		{
		}

		public Notification(string name)
		{
		}

		public Notification(string name, object body)
		{
		}

		public Notification(string name, object body, string type)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
