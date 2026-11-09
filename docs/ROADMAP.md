# Roadmap

Status: planning; no gameplay features implemented.

## Foundation
- [ ] C# mod skeleton, build and packaging
- [ ] Audit existing RimWorld telemetry, profiling, screenshot and test tools (licenses, APIs, 1.7 compatibility)
- [ ] Independently loadable Rimfolk Observer mod, with optional Rimfolk diagnostics integration
- [ ] Freeze and validate reproducible local mod/game test environment; record per-run manifest
- [ ] Rimfolk Observer telemetry, checkpoints, failure diagnostics and reporting
- [ ] Reproducible prebuilt settlement baseline

## Phase 1 — Sustain
AI maintains an established 8–12 pawn colony without intervention: food, essential jobs, bills, healthcare, repairs, ordinary defense. First overnight unattended run; eventual acceptance is one in-game year with sustainable resources and no player management. Repeat across seeds.

## Phase 2 — Expand
AI detects shortages, plans and builds housing, food production and other facilities, manages resource bottlenecks, and responds to population growth.

## Phase 3 — Establish
AI starts with limited infrastructure and supplies and independently builds a sustainable settlement.

## Subsequent gameplay
- [ ] Single-pawn control and PC autonomy
- [ ] Personal knowledge and fog of war
- [ ] Property, law, jobs, government and economy
- [ ] Social memory, rumor, deception and relationships
- [ ] Childhood, learning, family and succession
- [ ] Smart Speed, performance and optional integrations

Use GitHub issues and PRs for implementation; record design changes in DECISIONS.md.

## Modular architecture and characteristics (planned)
- [ ] Build lightweight Rimfolk Core contracts and independent module packaging; enforce no gameplay-module-to-gameplay-module dependencies.
- [ ] Define and prototype Core's typed characteristic registry, per-pawn persistence, and observer-specific visibility contracts without consuming vanilla trait slots.
- [ ] Validate conservative hidden-data UI behavior when no knowledge provider is installed.
- [ ] Build Autonomy independently against Core, with optional Observer decision tracing.
- [ ] Build Governance independently against Core, including configurable elections and single-seat ranked-choice voting.
- [ ] Later: Social evidence, beliefs, rumors, reputation and progressive discovery; Traits-defined dispositions and conditional effects; Property, Economy and Life as justified.
- [ ] Test module combinations and graceful degradation; keep Plot Armor development outside this roadmap, with optional integration only if justified.

The development sequence is Observer → Core → Autonomy → Governance. Subsequent modules and interfaces remain provisional. A complete Rimfolk mod preset is not a separate mandatory Experience mod.
