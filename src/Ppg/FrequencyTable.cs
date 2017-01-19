using System;

namespace Dkw.Ppg
{
	/// <summary>The Data used to generate the pronounceable passwords.</summary>
	public sealed class FrequencyTable
	{
		private String _name;
		private DateTime _created;
		private CharSet _charset;
		private Int64 _sigma;
		private Int32[] _singles;
		private Int32[,] _doubles;
		private Int32[,,] _triples;

		public FrequencyTable(String name, DateTime created, CharSet charSet, Int64 sigma, Int32[] singles, Int32[,] doubles, Int32[,,] triples) {
			if (String.IsNullOrWhiteSpace(name))
				throw new ArgumentNullException(nameof(name));
			if (created == DateTime.MinValue)
				throw new ArgumentOutOfRangeException(nameof(created));
			if (charSet == null)
				throw new ArgumentNullException(nameof(charSet));
			if (sigma <= 0)
				throw new ArgumentOutOfRangeException(nameof(sigma));

			_name = name;
			_created = created;
			_charset = charSet;
			_sigma = sigma;

			_singles = new Int32[_charset.Length];
			_doubles = new Int32[_charset.Length, _charset.Length];
			_triples = new Int32[_charset.Length, _charset.Length, _charset.Length];

			// Make a Copy
			for (var i = 0 ; i < _charset.Length ; i++) {
				_singles[i] = singles[i];
				for (var j = 0 ; j < _charset.Length ; j++) {
					_doubles[i, j] = doubles[i, j];
					for (var k = 0 ; k < _charset.Length ; k++) {
						_triples[i, j, k] = triples[i, j, k];
					}
				}
			}
		}

		/// <summary>Gets the name of the Graph</summary>
		public String Name => _name;

		/// <summary>Gets the DateTime the graph was created.</summary>
		public DateTime Created => _created;

		public CharSet CharSet => _charset;

		/// <summary>Gets the total number of Triples that are non-zero.</summary>
		public long Sigma => _sigma;

		/// <summary>Gets the number of occurrence for each letter [A-Z]</summary>
		public Int32[] Singles => _singles;

		/// <summary>Gets the number of occurrences for each two letter combination [A-Z,A-Z]</summary>
		public Int32[,] Doubles => _doubles;

		/// <summary>Gets the number of occurrences for each three letter combination [A-Z,A-Z,A-Z]</summary>
		public Int32[,,] Triples => _triples;
	}
}
