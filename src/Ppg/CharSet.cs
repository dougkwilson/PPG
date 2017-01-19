using System;
using System.Text.RegularExpressions;

namespace Dkw.Ppg
{
	public class CharSet
	{
		private static readonly Regex uppercase = new Regex("[A-Z]+", RegexOptions.Compiled);
		private static readonly Regex lowercase = new Regex("[a-z]+", RegexOptions.Compiled);

		public readonly String Characters;
		public Int32 Length => Characters.Length;
		public CharacterCase CharacterCase { get; private set; }

		public CharSet() {
			Characters = Characters = @"ABCEDFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			CharacterCase = CharacterCase.MixedCase;
		}

		public CharSet(String characters) {
			if (characters == null)
				throw new ArgumentNullException(nameof(characters));

			Characters = characters;

			if (uppercase.IsMatch(characters) && lowercase.IsMatch(characters)) {
				CharacterCase = CharacterCase.MixedCase;
			} else if (uppercase.IsMatch(characters)) {
				CharacterCase = CharacterCase.UpperCase;
			} else {
				CharacterCase = CharacterCase.LowerCase;
			}
		}

		public Char ToLetter(Int32 i) {
			return Characters[i];
		}

		public Int32 ToIndex(Char c) {
			if (c == '\n')
				c = ' ';

			if (CharacterCase == CharacterCase.LowerCase) {
				c = Char.ToLower(c);
			} else if (CharacterCase == CharacterCase.UpperCase) {
				c = Char.ToUpper(c);
			}

			return Characters.IndexOf(c);
		}
	}
}
