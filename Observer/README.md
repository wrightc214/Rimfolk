# Rimfolk Observer — startup smoke test

Standalone diagnostics mod for RimWorld 1.7. No Rimfolk Core dependency. **This is an untested skeleton, not a completed smoke test.**

## Prerequisites
- RimWorld 1.7 installation with `Assembly-CSharp.dll` and `UnityEngine.CoreModule.dll` in its `*_Data/Managed` directory.
- .NET SDK with .NET Framework 4.7.2 reference assemblies available (often easiest on Windows with the .NET Framework 4.7.2 Developer Pack). Build requirements may need adjustment after testing against the actual RimWorld 1.7 installation.

## Build
From the repository root, use a terminal (PowerShell example):

```powershell
dotnet build Observer/Source/Rimfolk.Observer/Rimfolk.Observer.csproj -c Release -p:RimWorldManagedDir="C:/Program Files (x86)/Steam/steamapps/common/RimWorld/RimWorldWin64_Data/Managed"
```

The intended DLL output is `Observer/Assemblies/Rimfolk.Observer.dll`. If your installation uses another managed-directory name, supply its actual path. If compilation fails, capture the full error; do not mark the test passed.

## Local installation
Copy the **Observer** folder (including `About/About.xml` and the compiled `Assemblies/Rimfolk.Observer.dll`) into RimWorld's local `Mods` directory. Enable **Rimfolk Observer** without Rimfolk Core or other Rimfolk gameplay modules, restart RimWorld, and inspect the in-game log for:

```text
[Rimfolk Observer] Startup smoke test: mod initialized.
```

## Acceptance evidence
- [ ] `dotnet build` succeeds against installed RimWorld 1.7 assemblies.
- [ ] The mod appears in RimWorld's mod list.
- [ ] It loads with Rimfolk Core absent and no new errors.
- [ ] The exact startup log line appears after restart.
- [ ] Record game version, OS, SDK version and build/log results in the PR.

No telemetry, checkpoints, third-party dependencies or frozen-environment validation are implemented in this change.
