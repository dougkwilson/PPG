using System;
using System.ComponentModel;
using System.IO;

namespace Fpi.Security
{
	public class GraphCreator
	{
		public event ProgressChangedEventHandler ProgressChanged;
		protected void OnProgressChanged(ProgressChangedEventArgs e)
		{
			if ( null != ProgressChanged )
			{
				ProgressChanged(this, e);
			}
		}

		/// <summary>
		/// Creates a <see cref="CharacterGraph"/> from a <see cref="Stream"/>.
		/// </summary>
		public Graph Create(Stream stream)
		{
			long length = 0;
			long bytesRead = 0;

			try
			{
				length = stream.Length;
			}
			catch
			{
			}

			int[, ,] triples = new int[26, 26, 26];	// CharacterGraph frequencies
			int[,] doubles = new int[26, 26];			// Bigraph frequencies
			int[] singles = new int[26];					// Letter frequencies
			long totalLetters = 0;		// Total letters

			char[] buf = new char[100];
			int k1, k2, k3;
			int c1, c2, c3;
			char[] s1 = new char[2];
			char[] s2 = new char[2];
			char[] s3 = new char[2];

			for ( c1 = 0 ; c1 < 26 ; c1++ )
			{
				// Explicitly Initialize arrays to zero
				singles[c1] = 0;
				for ( c2 = 0 ; c2 < 26 ; c2++ )
				{
					doubles[c1, c2] = 0;
					for ( c3 = 0 ; c3 < 26 ; c3++ )
					{
						triples[c1, c2, c3] = 0;
					}
				}
			}

			k2 = -1;				/* k1, k2 are coords of previous letters */
			k1 = -1;
			k3 = stream.ReadByte();

			while ( k3 != -1 )
			{
				bytesRead++;
				if ( k3 > 'Z' )
				{
					k3 = k3 - 'a';	/* map from a-z to 0-25 */
				}
				else
				{
					k3 = k3 - 'A';	/* map from A-Z to 0-25 */
				}

				// If k3 is a valid letter (a-z)...
				if ( k3 >= 0 && k3 <= 25 )
				{
					// And we have two letters previously...
					if ( k1 >= 0 && k2 > 0 )
					{
						// Increment the triple count
						triples[k1, k2, k3]++;

						// Increment the total characters count
						totalLetters++;
					}

					// Or maybe only one letter previously...
					if ( k2 >= 0 )
					{
						// Increment the double count
						doubles[k2, k3]++;
					}

					// Increment the singles count
					singles[k3]++;

					// Shift
					k1 = k2;
					k2 = k3;
				}

				if ((bytesRead) % 4096 == 0 && length > 0)
				{
					Int32 progressPercentage = Convert.ToInt32(bytesRead / length * 100.0);
					OnProgressChanged(new ProgressChangedEventArgs(progressPercentage, null));
				}

				// Next character please.
				k3 = stream.ReadByte();
			}

			return new Graph("Untitled", totalLetters, singles, doubles, triples);

		}

	}
}
