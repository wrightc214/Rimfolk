# Decisions (living record)

1. **Settlement first:** established permanent settlement is the primary experience; Odyssey gravships optional later.
2. **Autonomy first:** sustain → expand → establish before layering single-pawn life simulation.
3. **Observer first:** unattended telemetry, decision traces and failure diagnostics are essential infrastructure.
4. **Progressive checkpoints:** dense recent saves, sparse old saves, event-triggered protected saves; exact intervals provisional.
5. **Version/DLC:** RimWorld 1.7 only; Biotech, Ideology, Royalty required.
6. **Combat Extended:** no official implementation, testing or support; community patches welcome.
7. **Project management:** GitHub is authoritative for code, docs, issues and PRs; chat threads are planning and implementation workspaces.
8. **Critical review (permanent):** do not assume the owner's infallibility. Challenge assumptions and propose improvements with reasons. Distinguish accepted decisions from untested ideas.
9. **Name:** Rimfolk is a working project name; publication name undecided.
10. **Independent Observer:** Observer is an independently loadable development mod, usable against vanilla RimWorld without Rimfolk. Rimfolk should remain playable without Observer and may optionally emit richer diagnostics when Observer is installed. Plot Armor remains a separate standalone mod/project. Keep Observer and Rimfolk in this repository; avoid hard runtime dependencies on third-party diagnostic mods.
11. **Reuse before rebuilding:** audit existing tools (RimLog, Colonial Statistics, Work Monitor, Dubs Performance Analyzer, Progress Renderer, automated testing frameworks) for 1.7 compatibility, licenses, reliability, and suitability. These are candidates for reference or optional debugging, **not** automatically required dependencies. Avoid publishing/supporting Observer publicly before it is stable.
12. **Frozen test environments:** baseline and unattended tests use pinned local copies of all relevant mods, game/DLC versions, configuration and scenario. Record a machine-readable manifest including package IDs, source/version, hashes and build identifiers with every run. Never silently update a frozen environment in place. Do not vendor third-party mods into Git without a compelling, license-compliant reason.

## Open questions
RimWorld 1.7 screenshot APIs, existing autonomous mod reuse and licenses, KPI thresholds, retention disk budgets, deterministic replay feasibility, packaging of frozen local mod copies, game-version pinning, and validation of duplicate Workshop/local package IDs.
