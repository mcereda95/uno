﻿namespace Windows.Storage.Pickers {

	export class FileOpenPicker {
		public static async pickFilesAsync(multiple: boolean, showAllEntry: boolean): Promise<string> {

			if (!showOpenFilePicker) {
				return null;
			}

			const selectedFiles = await showOpenFilePicker({
				multiple: multiple,
				excludeAcceptAllOption: !showAllEntry
			});

			var results = "";
			for (var i = 0; i < selectedFiles.length; i++) {
				const guid = Uno.Utils.Guid.NewGuid();
				StorageFileNative.AddHandle(guid, selectedFiles[i]);
				results = results + guid + ";";
			}

			return results;
		}
	}
}
