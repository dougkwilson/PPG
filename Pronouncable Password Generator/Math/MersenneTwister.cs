using System;

#if TEST
using NUnit.Framework;
#endif

namespace Fpi.Math
{
	/// <summary>
	/// An implementation of MT19937: Integer version (1999/10/28)
	/// </summary>
	/// <remarks>
	/// MersenneTwister generates one pseudorandom unsigned integer (32bit) which is uniformly distributed among
	/// 0 to 2^32-1  for each call. Initialize(seed) sets initial values to the working area of 624 words. Before
	/// genrand(), Initialize(seed) must be called once. (seed is any 32-bit integer.)
	///
	/// Coded by Takuji Nishimura, considering the suggestions by Topher Cooper and Marc Rieffel in July-Aug. 1997.              
	/// This library is free software; you can redistribute it and/or modify it under the terms of the GNU Library
	/// General Public License as published by the Free Software Foundation; either version 2 of the License, or
	/// (at your option) any later version.
	/// 
	/// This library is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the
	/// implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
	/// 
	/// See the GNU Library General Public License for more details.  You should have received a copy of the GNU
	/// Library General Public License along with this library; if not, write to 
	/// Free Foundation, Inc.
	/// 59 Temple Place, Suite 330
	/// Boston, MA   02111-1307  USA
	/// 
	/// Copyright (C) 1997, 1999 Makoto Matsumoto and Takuji Nishimura. Any feedback is very welcome. For any 
	/// question, comments, see http://www.math.keio.ac.jp/matumoto/emt.html or email matumoto@math.keio.ac.jp
	/// 
	/// REFERENCE
	/// M. Matsumoto and T. Nishimura,
	/// "Mersenne Twister: A 623-Dimensionally Equidistributed Uniform Pseudo-Random Number Generator",                                
	/// ACM Transactions on Modeling and Computer Simulation,
	/// Vol. 8, No. 1, January 1998, pp 3--30.
	/// </remarks>
	public class MersenneTwister
	{
		/* Period parameters */
		private const int N = 624;
		private const int M = 397;
		private const long MATRIX_A = 0x9908b0df;		/* constant vector a */
		private const long UPPER_MASK = 0x80000000;	/* most significant w-r bits */
		private const long LOWER_MASK = 0x7fffffff;	/* least significant r bits */

		/* Tempering parameters */
		private const long TEMPERING_MASK_B = 0x9d2c5680;
		private const long TEMPERING_MASK_C = 0xefc60000;

		private long TEMPERING_SHIFT_U(long y)
		{
			return y >> 11;
		}
		private long TEMPERING_SHIFT_S(long y)
		{
			return y << 7;
		}
		private long TEMPERING_SHIFT_T(long y)
		{
			return y << 15;
		}
		private long TEMPERING_SHIFT_L(long y)
		{
			return y >> 18;
		}

		private long[] mt = new long[N]; /* the array for the state vector  */
		private int mti = N + 1; /* mti == N + 1 means mt[N] is not initialized */

		public MersenneTwister()
		{
			Initialize(DateTime.Now.Ticks);
		}

		public MersenneTwister(Int64 seed)
		{
			Initialize(seed);
		}

		/// <summary>
		/// Initializing the generator with a seed value
		/// </summary>
		/// <param name="seed"></param>
		public void Initialize(Int64 seed)
		{
			for ( int i = 0 ; i < N ; i++ )
			{
				mt[i] = seed & 0xffff0000;
				seed = 69069 * seed + 1;
				mt[i] |= ( seed & 0xffff0000 ) >> 16;
				seed = 69069 * seed + 1;
			}
			mti = N;
		}

		/// <summary>
		/// Returns a positive random number
		/// </summary>
		/// <returns>A number greater than or equal to zero</returns>
		public long Next()
		{
			long y;
			long[] mag01 = { 0x0, MATRIX_A };

			if ( mti >= N )
			{ /* generate N words at one time */
				int kk;

				if ( mti == N + 1 )   /* if Initialize() has not been called, */
					//Initialize(4357); /* a default initial seed is used   */
					Initialize(DateTime.Now.Ticks);

				for ( kk = 0 ; kk < N - M ; kk++ )
				{
					y = ( mt[kk] & UPPER_MASK ) | ( mt[kk + 1] & LOWER_MASK );
					mt[kk] = mt[kk + M] ^ ( y >> 1 ) ^ mag01[y & 0x1];
				}
				for ( ; kk < N - 1 ; kk++ )
				{
					y = ( mt[kk] & UPPER_MASK ) | ( mt[kk + 1] & LOWER_MASK );
					mt[kk] = mt[kk + ( M - N )] ^ ( y >> 1 ) ^ mag01[y & 0x1];
				}
				y = ( mt[N - 1] & UPPER_MASK ) | ( mt[0] & LOWER_MASK );
				mt[N - 1] = mt[M - 1] ^ ( y >> 1 ) ^ mag01[y & 0x1];

				mti = 0;
			}

			y = mt[mti++];
			y ^= TEMPERING_SHIFT_U(y);
			y ^= TEMPERING_SHIFT_S(y) & TEMPERING_MASK_B;
			y ^= TEMPERING_SHIFT_T(y) & TEMPERING_MASK_C;
			y ^= TEMPERING_SHIFT_L(y);

			return y;
		}

		/// <summary>
		/// Returns a random number between 0.0 and 1.0.
		/// </summary>
		/// <returns>A double-precision floating point number greater than or equal to 0.0, and less than 1.0.</returns>
		public double NextDouble()
		{
			return (double)Next() * 2.3283064370807974e-10;
		}

		/// <summary>
		/// Returns a random number between 0.0 and 1.0.
		/// </summary>
		/// <returns>A double-precision floating point number greater than or equal to 0.0, and less than 1.0.</returns>
		public double NextReal()
		{
			return ( ( (double)Next() + 1.0 ) * 2.3283064359965952e-10 );
		}

#if TEST

		[TestFixture]
		public class UnitTests
		{
			[SetUp]
			public void SetUp()
			{
			}

			[TearDown]
			public void TearDown()
			{
			}

			[Test]
			public void SameSeed()
			{
				MersenneTwister twist1 = new MersenneTwister(1);
				MersenneTwister twist2 = new MersenneTwister(1);

				Assert.AreEqual(twist1.Next(), twist2.Next());
			}

			[Test]
			public void DifferentSeed()
			{

				Int64 seed = DateTime.Now.Ticks;

				MersenneTwister twist1 = new MersenneTwister(seed);
				MersenneTwister twist2 = new MersenneTwister(seed + 5);

				Assert.IsTrue(twist1.Next() != twist2.Next());
			}

		}

#endif

	}
}
