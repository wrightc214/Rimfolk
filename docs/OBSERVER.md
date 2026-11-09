# Rimfolk Observer — Specification

Goal: allow unattended workday/overnight simulation tests and explain when, how and why a colony failed.

## Independent mod and integration boundary
Observer must load and collect baseline telemetry without Rimfolk. Rimfolk must be playable without Observer; when both are loaded, an optional, versioned diagnostics contract may carry Rimfolk-specific AI decisions. Do not make RimLog, Progress Renderer, or any other diagnostic mod a mandatory runtime dependency. Prefer using existing tools selectively for profiling or screenshots if proven compatible, rather than duplicating their full functionality.

## Data per run
- Reproducibility metadata: seed, scenario, storyteller, difficulty, mod list, versions, commit SHA, baseline save.
- Periodic CSV/JSONL KPIs: living pawns, mood, injuries, food reserves and projected days, crops, production, work, housing, power, repairs, TPS, errors.
- Structured AI decision traces: tick, context, predicted outcome, chosen action, rationale and observed result.
- Important events, screenshots where supported, checkpoint saves, and external Python-generated HTML report.

## Frozen test environment (required for baseline and long-run testing)
- Use **local pinned copies**, outside Steam-managed Workshop directories, for all relevant mod binaries and dependencies. Development installs may update deliberately; baseline and long-run installs must remain immutable during a run.
- Pin and record RimWorld game version/build, DLCs, Harmony, Rimfolk, Observer, optional tools, and relevant configurations.
- Store a machine-readable environment manifest with each run: package ID, source URL/Workshop ID, mod version or Git commit, content hash, dependency/load order, game build, scenario and starting save identity. Prefer hashes over display-version labels.
- Confirm the actual loaded mod path/content corresponds to the manifest; avoid duplicate Workshop/local package ID ambiguity. A copied directory alone does not prove it is being loaded.
- Never update a frozen environment in place. Create a new snapshot, run regression checks, then explicitly promote it to the new baseline.
- Keep third-party mod binaries outside Git; track metadata, scripts, and manifests in the repository. Respect licenses.
- Start with a small snapshot/validation script; **do not build an elaborate environment manager** until the need is demonstrated.

## Existing-tool audit before implementation
Investigate RimLog (structured telemetry), Colonial Statistics, Work Monitor, Dubs Performance Analyzer (profiling), Progress Renderer (screenshots), and relevant test frameworks. Verify current source, license, RimWorld **1.7** compatibility and behavior. Identify what can be reused, what is merely an optional diagnostic tool, and what Observer must implement itself. No external tool is assumed to meet all requirements.

## Proposed save retention (age relative to current game time)
| Age | Spacing |
| --- | --- |
| Last 15 days | Every 2 days |
| 15–60 days | Every 5 days |
| 1–5 years | One per quadrum |
| 5–20 years | Annual |
| 20–50 years | Every 2 years |
| Older than 50 years | Every 5 years |

RimWorld years are 60 days and quadrums 15 days. Preserve initial checkpoint, manually pinned checkpoints and selected critical-event saves. Apply a configurable disk budget and event cooldowns. Avoid deleting in-progress saves.

## Failure handling
Detect food collapse, starvation, incapacitation, persistent unfilled essential work, and severe errors. On threshold crossing capture state and decision context, queue a safe save, optionally pause/stop, and mark failure. Keep ability to continue for recovery testing.

## Engineering cautions
Saves and screenshots require safe game-thread integration. Whole-map capture may require special implementation. Replays can diverge; logs are primary evidence. Prevent Observer I/O from degrading TPS. Version and load-path verification should fail closed or clearly mark runs as non-reproducible.

## First milestone
Audit existing tools and 1.7 APIs; establish minimal C# build and reproducible environment metadata; write daily KPIs, decision events, one food-shortage alert, reliable checkpoints and a minimal HTML timeline. Add advanced retention and screenshots incrementally.
