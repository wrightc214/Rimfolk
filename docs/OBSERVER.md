# Rimfolk Observer — Specification

Goal: allow unattended workday/overnight simulation tests and explain when, how and why a colony failed.

## Data per run
- Reproducibility metadata: seed, scenario, storyteller, difficulty, mod list, versions, commit SHA, baseline save.
- Periodic CSV/JSONL KPIs: living pawns, mood, injuries, food reserves and projected days, crops, production, work, housing, power, repairs, TPS, errors.
- Structured AI decision traces: tick, context, predicted outcome, chosen action, rationale and observed result.
- Important events, screenshots where supported, checkpoint saves, and external Python-generated HTML report.

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
Saves and screenshots require safe game-thread integration. Whole-map capture may require special implementation. Replays can diverge; logs are primary evidence. Prevent Observer I/O from degrading TPS.

## First milestone
Write daily KPIs, decision events, one food-shortage alert, reliable checkpoints and a minimal HTML timeline. Then add advanced retention and screenshots.
