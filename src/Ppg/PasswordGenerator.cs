using System;
using System.Diagnostics;
using System.Text;

namespace Dkw.Ppg
{
	/// <summary>
	/// Summary description for CharacterGraphCreator.
	/// </summary>
	public class PasswordGenerator
	{
		private static readonly MersenneTwister _random = new MersenneTwister();

		public static readonly String Numbers = @"0123456789";
		public static readonly String Symbols = @"~!@#$%^&*()-+={}[]/\|:;<>,.? ";
		private readonly FrequencyTable _frequencyTable;

		private CharSet CharSet => _frequencyTable.CharSet;

		public PasswordGenerator(FrequencyTable frequencyTable) {
			if (frequencyTable == null)
				throw new ArgumentNullException(nameof(frequencyTable));

			_frequencyTable = frequencyTable;
		}

		/// <summary>
		/// Generates a Pronounceable Password eight characters in length
		/// </summary>
		/// <returns>A ten character password.</returns>
		public String Generate() {
			return Generate(1, 10)[0];
		}

		public String Generate(Int32 length) {
			return Generate(1, length)[0];
		}

		/// <summary>
		/// Generates the specified number of pronounceable passwords of the specified length
		/// </summary>
		/// <param name="number">Number of passwords to generate</param>
		/// <param name="length">The length of each password</param>
		/// <returns>An array of strings</returns>
		public String[] Generate(Int32 number, Int32 length) {
			Int32 c1, c2, c3;
			Int32 nchar;
			Int32 pwnum;
			Int64 sum = 0;
			Int64 ranno;

			StringBuilder password;
			var passwords = new String[number];

			for (pwnum = 0 ; pwnum < number ; pwnum++) {
				password = new StringBuilder(length);
				// Pick a random starting point.
				ranno = Convert.ToInt64(_random.NextDouble() * Convert.ToDouble(_frequencyTable.Sigma)); // weight by sum of frequencies
				sum = 0;
				for (c1 = 0 ; c1 < CharSet.Length ; c1++) {
					for (c2 = 0 ; c2 < CharSet.Length ; c2++) {
						for (c3 = 0 ; c3 < CharSet.Length ; c3++) {
							sum += _frequencyTable.Triples[c1, c2, c3];
							if (sum > ranno) {
								password.Append(CharSet.Characters.Substring(c1, 1));
								password.Append(CharSet.Characters.Substring(c2, 1));
								password.Append(CharSet.Characters.Substring(c3, 1));
								c1 = CharSet.Length; // Found start. Break all 3 loops.
								c2 = CharSet.Length;
								c3 = CharSet.Length;
							} // if sum
						} // for c3
					} // for c2
				} // for c1

				// Now do a random walk.
				nchar = 3;
				while (nchar < length) {
					c1 = CharSet.ToIndex(password[nchar - 2]);
					c2 = CharSet.ToIndex(password[nchar - 1]);
					sum = 0;
					for (c3 = 0 ; c3 < CharSet.Length ; c3++)
						sum += _frequencyTable.Triples[c1, c2, c3];
					if (sum == 0) {
						break;  // exit while loop
					}

					ranno = Convert.ToInt64(_random.NextDouble() * Convert.ToDouble(sum));
					sum = 0;
					for (c3 = 0 ; c3 < CharSet.Length ; c3++) {
						sum += _frequencyTable.Triples[c1, c2, c3];
						if (sum > ranno) {
							password.Append(CharSet.ToLetter(c3));
							c3 = CharSet.Length; // break for loop
						}
					}
					if (password.Length < nchar) {
						Debug.WriteLine("Didn't get a character from the frequency table.");
					}
					nchar++;
				}
				passwords[pwnum] = password.ToString();
			}

			return passwords;
		}

	}
}
