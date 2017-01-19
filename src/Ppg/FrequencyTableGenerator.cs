using System;
using System.IO;
using System.Text;

namespace Dkw.Ppg
{
	public class FrequencyTableGenerator
	{
		public FrequencyTable Generate(String sourcePath, CharSet charSet) {
			if (sourcePath == null)
				throw new ArgumentNullException(nameof(sourcePath));

			if (charSet == null)
				throw new ArgumentNullException(nameof(charSet));

			using (var file = File.Open(sourcePath, FileMode.Open, FileAccess.Read, FileShare.Read))
			using (var reader = new StreamReader(file, Encoding.UTF8, true)) {
				var name = Path.GetFileNameWithoutExtension(sourcePath);
				var generator = new FrequencyTableGenerator();
				return generator.Generate(name, reader, charSet);
			}
		}


		/// <summary>
		/// Creates a <see cref="FrequencyTable"/> from a <see cref="StreamReader"/>.
		/// </summary>
		public FrequencyTable Generate(String name, StreamReader stream, CharSet charSet) {
			if (name == null)
				throw new ArgumentNullException(nameof(name));

			if (stream == null)
				throw new ArgumentNullException(nameof(stream));

			if (charSet == null)
				throw new ArgumentNullException(nameof(charSet));

			var singles = new Int32[charSet.Length];
			var doubles = new Int32[charSet.Length, charSet.Length];
			var triples = new Int32[charSet.Length, charSet.Length, charSet.Length];
			var letterCount = 0;
			var c1 = -1;
			var c2 = -1;
			var prev = ' ';
			var i = stream.Read();
			do {
				var c3 = charSet.ToIndex((Char)i);
				if (c3 >= 0) {
					var cur = charSet.ToLetter(c3);
					if (prev != cur) {

						singles[c3]++;

						if (c2 >= 0) {
							doubles[c2, c3]++;

							if (c1 >= 0) {
								triples[c1, c2, c3]++;
								letterCount++;
							}
						}

						// Shift
						c1 = c2;
						c2 = c3;
					}
					prev = charSet.ToLetter(c3);
				}
				i = stream.Read();
			} while (i >= 0);

			return new FrequencyTable(name, DateTime.Now, charSet, letterCount, singles, doubles, triples);
		}
	}
}
