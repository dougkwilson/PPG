using System;
using System.IO;
using System.Text;

namespace Dkw.Ppg
{
	public class FrequencyTableSerializer
	{

		public void Serialize(String destFile, FrequencyTable frequencyTable) {
			using (var writer = new StreamWriter(File.Open(destFile, FileMode.Create, FileAccess.Write, FileShare.None), Encoding.UTF8)) {
				var s = new FrequencyTableSerializer();
				Serialize(writer, frequencyTable);
				writer.Close();
			}
		}

		public void Serialize(TextWriter textWriter, FrequencyTable frequencyTable) {
			textWriter.Write($"$NAME={frequencyTable.Name}{Environment.NewLine}");
			textWriter.Write($"$CREATED={frequencyTable.Created}{Environment.NewLine}");
			textWriter.Write($"$CHARSET={frequencyTable.CharSet.Characters}{Environment.NewLine}");
			textWriter.Write($"$SIGMA={frequencyTable.Sigma}{Environment.NewLine}");

			var charSet = frequencyTable.CharSet;
			var l = frequencyTable.CharSet.Length;

			for (var c1 = 0 ; c1 < l ; c1++) {
				Char ic = charSet.ToLetter(c1);
				if (frequencyTable.Singles[c1] > 0)
					textWriter.Write($"{ic}={frequencyTable.Singles[c1]}{Environment.NewLine}");
				for (var c2 = 0 ; c2 < l ; c2++) {
					Char jc = charSet.ToLetter(c2);
					if (frequencyTable.Doubles[c1, c2] > 0)
						textWriter.Write($"{ic}{jc}={frequencyTable.Doubles[c1, c2]}{Environment.NewLine}");
					for (var c3 = 0 ; c3 < l ; c3++) {
						Char kc = charSet.ToLetter(c3);
						if (frequencyTable.Triples[c1, c2, c3] > 0)
							textWriter.Write($"{ic}{jc}{kc}={frequencyTable.Triples[c1, c2, c3]}{Environment.NewLine}");
					}
				}
			}
		}

		public FrequencyTable Deserialize(String filename) {
			using (var reader = new StreamReader(File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read), Encoding.UTF8)) {
				return Deserialize(reader);
			}
		}

		public FrequencyTable Deserialize(TextReader reader) {

			var lineNumber = 0;
			var name = "Undefined";
			var created = DateTime.MinValue;
			var charSet = new CharSet();
			var sigma = 0L;

			for (var x = 0 ; x < 4 ; x++) {
				var line = reader.ReadLine();
				lineNumber++;
				var i = line.IndexOf('=') + 1;
				if (line.StartsWith("$NAME", StringComparison.InvariantCultureIgnoreCase)) {
					name = line.Substring(i);
				} else if (line.StartsWith("$CREATED", StringComparison.InvariantCultureIgnoreCase)) {
					created = DateTime.Parse(line.Substring(i));
				} else if (line.StartsWith("$CCHARSET", StringComparison.InvariantCultureIgnoreCase)) {
					charSet = new CharSet(line.Substring(i));
				} else if (line.StartsWith("$SIGMA", StringComparison.InvariantCultureIgnoreCase)) {
					sigma = Int64.Parse(line.Substring(i));
				}
			}

			var l = charSet.Length;
			var singles = new Int32[l];
			var doubles = new Int32[l, l];
			var triples = new Int32[l, l, l];

			do {
				var line = reader.ReadLine();
				lineNumber++;
				var i = line.IndexOf('=') + 1;
				if (i > 0) {
					var v = Int32.Parse(line.Substring(i));
					var c1 = charSet.ToIndex(line[0]);
					if (line[1] != '=') {
						var c2 = charSet.ToIndex(line[1]);
						if (line[2] != '=') {
							var c3 = charSet.ToIndex(line[2]);
							triples[c1, c2, c3] = v;
						} else {
							doubles[c1, 12] = v;
						}
					} else {
						singles[c1] = v;
					}
				}
			} while (reader.Peek() >= 0);

			return new FrequencyTable(name, created, charSet, sigma, singles, doubles, triples);
		}
	}
}
