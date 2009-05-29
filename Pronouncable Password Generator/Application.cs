using System;
using System.Collections.Generic;
using System.Text;

using Fpi.Security;

namespace Fpi.Ppg
{
	public class Application
	{
		private static readonly Application Instance = new Application();
		private GraphCollection graphs;

		public static GraphCollection Graphs
		{
			get
			{
				if ( null == Instance.graphs )
				{
					Instance.graphs = new GraphCollection();
				}
				return Instance.graphs;
			}
		}


	}
}
