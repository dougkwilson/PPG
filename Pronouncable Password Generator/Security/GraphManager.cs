using System;
using System.IO;
using System.Text;

namespace Fpi.Security
{
	/// <summary>
	/// Summary description for CharacterGraphCreator.
	/// </summary>
	public static class GraphManager
	{
		public static readonly String Letters = @"abcdefghijklmnopqrstuvwxyz";
		public static readonly String Numbers = @"0123456789";
		public static readonly String Symbols = @"~!@#$%^&*()-+={}[]/\|:;<>,.?";

		private static Fpi.Math.MersenneTwister _random = new Fpi.Math.MersenneTwister();

		public static String Substitute(String password, Boolean substituteNumbers, Boolean substituteSymbols)
		{
			if ( substituteNumbers )
			{
			}

			if ( substituteSymbols )
			{
			}

			return password;
		}

		/// <summary>
		/// Generates a Pronounceable Password eight characters in length
		/// </summary>
		/// <returns>An eight character password.</returns>
		public static string Generate()
		{
			return Generate(1, 8)[0];
		}

		public static String Generate(Int32 length)
		{
			return Generate(1, length)[0];
		}

		/// <summary>
		/// Generates the specified number of pronounceable passwords of the specified length
		/// </summary>
		/// <param name="number">Number of passwords to generate</param>
		/// <param name="length">The length of each password</param>
		/// <param name="seed"></param>
		/// <returns>An array of strings</returns>
		public static string[] Generate(Int32 number, Int32 length)
		{
			Graph graph = Graph.GetDefault();

			// Current Index into the Triples
			int c1, c2, c3;
			// Counter for password length
			int nchar;
			// Counter for total passwords
			int pwnum;
			// Accumulator
			long sum = 0;
			// Target
			long ranno;

			StringBuilder password;
			String[] list = new String[number];

			for ( pwnum = 0 ; pwnum < number ; pwnum++ )
			{
				password = new StringBuilder(length);
				// Pick a random starting point.
				ranno = (long)( _random.NextDouble() * graph.Sigma ); // weight by sum of frequencies
				sum = 0;
				for ( c1 = 0 ; c1 < 26 ; c1++ )
				{
					for ( c2 = 0 ; c2 < 26 ; c2++ )
					{
						for ( c3 = 0 ; c3 < 26 ; c3++ )
						{
							sum += graph.Triples[c1, c2, c3];
							if ( sum > ranno )
							{
								password.Append(Letters.Substring(c1, 1));
								password.Append(Letters.Substring(c2, 1));
								password.Append(Letters.Substring(c3, 1));
								c1 = 26; // Found start. Break all 3 loops.
								c2 = 26;
								c3 = 26;
							} // if sum
						} // for c3
					} // for c2
				} // for c1

				// Now do a random walk.
				nchar = 3;
				while ( nchar < length )
				{
					c1 = Letters.IndexOf(password.ToString().Substring(nchar - 2, 1));
					c2 = Letters.IndexOf(password.ToString().Substring(nchar - 1, 1));
					sum = 0;
					for ( c3 = 0 ; c3 < 26 ; c3++ )
						sum += graph.Triples[c1, c2, c3];
					if ( sum == 0 )
					{
						break;	// exit while loop
					}
					ranno = (long)( _random.NextDouble() * sum );
					sum = 0;
					for ( c3 = 0 ; c3 < 26 ; c3++ )
					{
						sum += graph.Triples[c1, c2, c3];
						if ( sum > ranno )
						{
							password.Append(Letters.Substring(c3, 1));
							c3 = 26; // break for loop
						} // if sum
					} // for c3
					nchar++;
				} // while nchar
				list[pwnum] = password.ToString();
			} // for pwnum

			return list;
		} // generate()

	}
}
