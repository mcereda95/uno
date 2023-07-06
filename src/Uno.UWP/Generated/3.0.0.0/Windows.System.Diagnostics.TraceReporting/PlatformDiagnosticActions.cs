#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Diagnostics.TraceReporting
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class PlatformDiagnosticActions 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool IsScenarioEnabled( global::System.Guid scenarioId)
		{
			throw new global::System.NotImplementedException("The member bool PlatformDiagnosticActions.IsScenarioEnabled(Guid scenarioId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20PlatformDiagnosticActions.IsScenarioEnabled%28Guid%20scenarioId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TryEscalateScenario( global::System.Guid scenarioId,  global::Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticEscalationType escalationType,  string outputDirectory,  bool timestampOutputDirectory,  bool forceEscalationUpload,  global::System.Collections.Generic.IReadOnlyDictionary<string, string> triggers)
		{
			throw new global::System.NotImplementedException("The member bool PlatformDiagnosticActions.TryEscalateScenario(Guid scenarioId, PlatformDiagnosticEscalationType escalationType, string outputDirectory, bool timestampOutputDirectory, bool forceEscalationUpload, IReadOnlyDictionary<string, string> triggers) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=bool%20PlatformDiagnosticActions.TryEscalateScenario%28Guid%20scenarioId%2C%20PlatformDiagnosticEscalationType%20escalationType%2C%20string%20outputDirectory%2C%20bool%20timestampOutputDirectory%2C%20bool%20forceEscalationUpload%2C%20IReadOnlyDictionary%3Cstring%2C%20string%3E%20triggers%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActionState DownloadLatestSettingsForNamespace( string partner,  string feature,  bool isScenarioNamespace,  bool downloadOverCostedNetwork,  bool downloadOverBattery)
		{
			throw new global::System.NotImplementedException("The member PlatformDiagnosticActionState PlatformDiagnosticActions.DownloadLatestSettingsForNamespace(string partner, string feature, bool isScenarioNamespace, bool downloadOverCostedNetwork, bool downloadOverBattery) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PlatformDiagnosticActionState%20PlatformDiagnosticActions.DownloadLatestSettingsForNamespace%28string%20partner%2C%20string%20feature%2C%20bool%20isScenarioNamespace%2C%20bool%20downloadOverCostedNetwork%2C%20bool%20downloadOverBattery%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::System.Guid> GetActiveScenarioList()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<Guid> PlatformDiagnosticActions.GetActiveScenarioList() is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CGuid%3E%20PlatformDiagnosticActions.GetActiveScenarioList%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActionState ForceUpload( global::Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticEventBufferLatencies latency,  bool uploadOverCostedNetwork,  bool uploadOverBattery)
		{
			throw new global::System.NotImplementedException("The member PlatformDiagnosticActionState PlatformDiagnosticActions.ForceUpload(PlatformDiagnosticEventBufferLatencies latency, bool uploadOverCostedNetwork, bool uploadOverBattery) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PlatformDiagnosticActionState%20PlatformDiagnosticActions.ForceUpload%28PlatformDiagnosticEventBufferLatencies%20latency%2C%20bool%20uploadOverCostedNetwork%2C%20bool%20uploadOverBattery%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceSlotState IsTraceRunning( global::Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceSlotType slotType,  global::System.Guid scenarioId,  ulong traceProfileHash)
		{
			throw new global::System.NotImplementedException("The member PlatformDiagnosticTraceSlotState PlatformDiagnosticActions.IsTraceRunning(PlatformDiagnosticTraceSlotType slotType, Guid scenarioId, ulong traceProfileHash) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PlatformDiagnosticTraceSlotState%20PlatformDiagnosticActions.IsTraceRunning%28PlatformDiagnosticTraceSlotType%20slotType%2C%20Guid%20scenarioId%2C%20ulong%20traceProfileHash%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceRuntimeInfo GetActiveTraceRuntime( global::Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceSlotType slotType)
		{
			throw new global::System.NotImplementedException("The member PlatformDiagnosticTraceRuntimeInfo PlatformDiagnosticActions.GetActiveTraceRuntime(PlatformDiagnosticTraceSlotType slotType) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=PlatformDiagnosticTraceRuntimeInfo%20PlatformDiagnosticActions.GetActiveTraceRuntime%28PlatformDiagnosticTraceSlotType%20slotType%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceInfo> GetKnownTraceList( global::Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceSlotType slotType)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<PlatformDiagnosticTraceInfo> PlatformDiagnosticActions.GetKnownTraceList(PlatformDiagnosticTraceSlotType slotType) is not implemented. For more information, visit https://aka.platform.uno/notimplemented#m=IReadOnlyList%3CPlatformDiagnosticTraceInfo%3E%20PlatformDiagnosticActions.GetKnownTraceList%28PlatformDiagnosticTraceSlotType%20slotType%29");
		}
		#endif
	}
}
