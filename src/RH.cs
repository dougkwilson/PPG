using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Dkw
{
	/// <summary>ResourceHelper</summary>
	[DebuggerStepThrough]
	public static class RH
	{
		private static readonly IDictionary<String,String> Cache = new Dictionary<String,String>();

		public static String GS(String resource) {
			Type type = typeof(RH);
			return GS(resource, type);
		}

		/// <summary>
		/// Looks in the assembly and namespace that contains <typeparamref name="T"/> for a resource named <paramref name="resource"/> and returns it as a <seealso cref="String"/>.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="resource"></param>
		/// <returns></returns>
		[DebuggerStepThrough]
		public static String GS<T>(String resource) {
			Type type = typeof(T);
			return GS(resource, type);
		}

		// ReSharper disable once InconsistentNaming
		private static String GS(String resource, Type type) {
			String cachekey = type.FullName + "::" + resource;
			if (!Cache.ContainsKey(cachekey)) {
				try {
					Assembly assembly = Assembly.GetAssembly(type);
					if (assembly == null) {
						throw new ApplicationException("Could not load the assembly.");
					}

					String key = type.Namespace + "." + resource;

					// ReSharper disable once AssignNullToNotNullAttribute
					using (StreamReader reader = new StreamReader(assembly.GetManifestResourceStream(key))) {
						Cache[cachekey] = reader.ReadToEnd();
					}
				}
				catch (Exception ex) {
					throw new ApplicationException("ResourceHelper.GetString('" + resource + "') failed to load the resource code from " + type.AssemblyQualifiedName, ex);
				}
			}

			return Cache[cachekey];
		}

		[DebuggerStepThrough]
		public static Stream GRS(String resource) {
			Type type = typeof(RH);
			return GRS(resource, type);
		}

		[DebuggerStepThrough]
		public static Stream GRS<T>(String resource) {
			Type type = typeof(T);
			return GRS(resource, type);
		}

		[DebuggerStepThrough]
		public static Stream GRS(String resource, Type type) {
			Assembly assembly = Assembly.GetAssembly(type);

			if (assembly == null) {
				throw new ApplicationException("Could not load the assembly.");
			}

			String key = type.Namespace + "." + resource;

			return assembly.GetManifestResourceStream(key);
		}
	}
}