using System;
using System.ComponentModel;
using System.IO;
using Dkw.Ppg;

namespace Dkw.Properties
{
	internal sealed partial class Settings
	{
		private const String _frequencyTableFilename = "FrequencyTable.ppg";
		private FrequencyTable _frequencyTable;
		private Boolean _exiting = false;

		public Settings() {
			SettingsSaving += SettingsSavingEventHandler;
		}

		private void SettingsSavingEventHandler(object sender, CancelEventArgs e) {
			if (!_exiting) {
				_frequencyTable = null;
				FrequencyTableFilename = String.Empty;
				EnsureFrequencyTableIsLoaded();
			}
		}

		internal void Save(Boolean exiting) {
			_exiting = exiting;
			Save();
			_exiting = false;
		}

		public FrequencyTable FrequencyTable {
			get {
				EnsureFrequencyTableIsLoaded();
				return _frequencyTable;
			}
		}

		private void EnsureFrequencyTableIsLoaded() {

			if (_frequencyTable != null)
				return;

			LoadFromFequencyTable();
			if (_frequencyTable == null) {
				LoadFromCorpus();
			}

			if (_frequencyTable == null) {
				LoadDefault();
			}

			if (_frequencyTable == null) {
				throw new ApplicationException("Could not load a Frequency Table");
			}
		}

		private void LoadDefault() {
			using (var reader = new StreamReader(RH.GRS(_frequencyTableFilename))) {
				var serializer = new FrequencyTableSerializer();
				_frequencyTable = serializer.Deserialize(reader);
			}
		}

		private void LoadFromCorpus() {
			if (!String.IsNullOrWhiteSpace(CorpusFilename)) {
				if (File.Exists(CorpusFilename)) {
					// Generate from corpus
					var generator = new FrequencyTableGenerator();
					var frequencyTable = generator.Generate(CorpusFilename, new CharSet(CharSet));

					// Save to disk
					var directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData, Environment.SpecialFolderOption.Create), "PPG");
					if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
					FrequencyTableFilename = Path.Combine(directory, _frequencyTableFilename);

					var serializer = new FrequencyTableSerializer();
					serializer.Serialize(FrequencyTableFilename, frequencyTable);

					_frequencyTable = frequencyTable;
				}
			}
		}

		private void LoadFromFequencyTable() {
			var serializer = new FrequencyTableSerializer();
			if (!String.IsNullOrWhiteSpace(FrequencyTableFilename)) {
				if (File.Exists(FrequencyTableFilename)) {
					_frequencyTable = serializer.Deserialize(FrequencyTableFilename);
				}
			}
		}
	}
}
