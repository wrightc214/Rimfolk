# Rimfolk Observer v0.0.1

**Status: first build and in-game smoke test pending.** Standalone RimWorld 1.7 diagnostic mod; no Rimfolk Core or Harmony dependency.

## Download and install (Windows / Steam)

1. Open the GitHub Actions workflow named **Build Observer v0.0.1** in the Rimfolk repository and open its latest successful run for the feature branch or PR.
2. Under **Artifacts**, download **Rimfolk-Observer-v0.0.1**. GitHub may require you to sign in.
3. Extract the downloaded artifact ZIP. Inside is `Rimfolk-Observer-v0.0.1.zip`. Extract that ZIP as well.
4. In Steam, right-click **RimWorld → Manage → Browse local files**. Open (or create) the `Mods` folder in the RimWorld installation directory.
5. Copy the **RimfolkObserver** folder from the inner ZIP into `Mods`. The resulting paths should be `Mods/RimfolkObserver/About/About.xml` and `Mods/RimfolkObserver/Assemblies/Rimfolk.Observer.dll`.
6. Start RimWorld 1.7, open **Mods**, enable **Rimfolk Observer**, and restart when prompted. It should not require Rimfolk Core or any other Rimfolk module.
7. Open the in-game log (development mode if needed) and look for `[Rimfolk Observer] Startup smoke test: mod initialized.`. Report whether it appears and any errors.

If the mod is not listed, check that you did not accidentally nest the mod folder twice. If you use a custom Steam library, use Steam's **Browse local files** rather than guessing the path.

## Build (maintainers / CI)

GitHub Actions builds on Ubuntu with .NET 10 SDK using **Krafs.Rimworld.Ref** 1.7 reference assemblies from NuGet, licensed for reference distribution with Ludeon's permission. The reference package is a **build-time dependency only** and is not shipped. The package version is currently allowed to float within 1.7 prereleases for the smoke test; pin an exact version before frozen simulation testing.

The workflow compiles `Observer/Source/Rimfolk.Observer/Rimfolk.Observer.csproj`, stages only `About/About.xml` and `Assemblies/Rimfolk.Observer.dll`, then creates an installable mod ZIP. CI compile success is not proof that RimWorld loads the mod; a Windows Steam smoke test is required.

## Acceptance checklist

- [ ] GitHub Actions restores and compiles against RimWorld 1.7 references.
- [ ] CI ZIP contains a single `RimfolkObserver` folder with About.xml and the DLL.
- [ ] RimWorld 1.7 lists and enables the mod without Rimfolk Core.
- [ ] Startup log message appears with no new errors.

No telemetry, checkpoints, profiling, frozen environment, or third-party runtime dependencies are included.

Smoke-test version: **0.0.1**. GitHub Actions is the intended build source; no local developer setup is required for players.
