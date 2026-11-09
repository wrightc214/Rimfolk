# Rimfolk Design — Working Draft

## Vision
One directly controlled pawn, living among autonomous NPCs in a persistent settlement. The pawn can work autonomously when not directed; authority over the colony must be earned through in-world roles, not granted by player status.

## Settlement
Start in a prebuilt, functioning settlement of roughly 12 residents. AI handles food, production, maintenance, healthcare, defense, and later expansion and settlement establishment. Rare raids by default; social and personal challenges matter more than combat.

## Society
Government and economy are separate configurable systems: elected officials, councils, despots, communal or private property, and work obligations. NPCs and player follow the same rights and rules. Ownership, occupancy, possession, and legal authority differ. Private storage must be respected by hauling and bills; theft is possible with consequences.

## Social and knowledge
Objective events differ from pawn knowledge and belief. Witnesses can misperceive or lie; rumors spread; relationships are asymmetric across trust, affection, fear, respect and attraction. Structured social actions include persuasion, courtship, deception, investigation, reconciliation. Fog of war and UI respect the current pawn's knowledge.

## Life course
All pawns gain skills and evolve through experience, mentorship and schooling. Normal childhood aging rather than accelerated Biotech aging by default. On death, choose a living descendant, who has their own knowledge, rights and relationships; no time skip. Children can be player characters with age-appropriate agency.

## Time
Smart Speed accelerates when meaningful interaction is unavailable, interrupting only for relevant events knowable to the PC. Long-running simulations need bounded data and efficient event-driven updates.

## Compatibility
RimWorld 1.7 only. Biotech, Ideology, Royalty required. Odyssey and Anomaly optional future integrations. Vanilla combat baseline; no official CE development or support.

All features are proposals until implemented and tested.

## Modular architecture (accepted direction)
Rimfolk is an ecosystem of independently useful gameplay modules. Rimfolk Core is the sole permitted Rimfolk-module dependency for gameplay modules; modules must not directly depend on each other. They may interact through optional, versioned Core capabilities and degrade gracefully when a capability is absent. Core should remain small and must not absorb gameplay or third-party-specific compatibility patches. Observer is an independent diagnostic mod, usable without Core or Rimfolk; Plot Armor is a separate project, outside Rimfolk's development scope, with possible future optional integration. The complete Rimfolk experience is a supported mod collection/preset, not currently a separate mandatory Experience mod.

Planned development order: Observer → Core → Autonomy → Governance. Property, Economy, Social, Life and Traits are prospective modules; boundaries and sequencing beyond Governance remain provisional. Governance should support configurable leadership and election methods including ranked-choice instant-runoff voting for single-seat offices, with future multi-seat methods considered separately. Institutional change should reflect pawn agency and political conditions rather than a strictly linear technology progression.

## Characteristics, knowledge and identity (accepted architectural direction)
Core owns a generic, extensible **characteristic framework**, not a fixed catalog of personality traits: stable identifiers, typed definitions, registration, per-pawn objective value storage, persistence, validation, and visibility/knowledge contracts. Definitions must support differing types and change over time; do not assume a universal 0–100 scale, permanence, inheritability, or use of vanilla trait slots. Gameplay modules define particular characteristics and implement their behavioral effects. Conventional vanilla traits and increased vanilla trait-slot limits are separate concerns; Rimfolk will not expand vanilla trait capacity as a foundational requirement.

**Objective characteristics, observed actions/evidence, and individual beliefs are distinct.** A pawn may be predisposed to dishonesty; other pawns may independently observe contradictions, infer dishonesty, spread rumors, or form false beliefs. A characteristic is not automatically known merely because it is stored. Knowledge is observer-specific, not a global `IsKnown` flag. Discovery can progress from unknown to suspected to supported or disputed; public reputation and deliberate disclosure are distinct from objective truth. The player-facing UI must respect the current player character's knowledge and may not expose hidden objective values by default.

Core defines access/knowledge provider contracts and a conservative fallback if no knowledge module is installed; a future Social module owns evidence, inference, rumor, reputation, and observer-specific belief implementation. Social must remain useful without Traits, and Traits without Social. Cross-module effects communicate through Core without direct gameplay-module assembly dependencies. Use sparse, event-driven belief records rather than dense all-pawn/all-characteristic matrices.

Example (illustrative): Marcus has a deception-related characteristic, but the player character does not see it. Witnessed contradictions and corroborated evidence may lead the player character to distrust Marcus. Another pawn may still trust him; a truthful pawn may acquire a false reputation for dishonesty. Neither observation nor reputation guarantees the underlying characteristic.

This is a design decision, not an implemented API. Exact interfaces, UI behavior, performance budgets, and module ownership of specific characteristics require prototyping and testing.
