#pragma warning disable 0,
// ReSharper disable

using KairosoftGameManager;
using KairosoftGameManager.Utility;

namespace KairosoftGameManager {

	public class CustomController : INotifyPropertyChanged {

		#region implement

		public event PropertyChangedEventHandler? PropertyChanged;

		public void NotifyPropertyChanged (
			params String[] propertyNameList
		) {
			foreach (var propertyName in propertyNameList) {
				this.PropertyChanged?.Invoke(this, new (propertyName));
			}
			return;
		}

		#endregion

	}

}
