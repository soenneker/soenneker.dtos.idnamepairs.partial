[![](https://img.shields.io/nuget/v/soenneker.dtos.idnamepairs.partial.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.idnamepairs.partial/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idnamepairs.partial/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idnamepairs.partial/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.idnamepairs.partial.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.idnamepairs.partial/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idnamepairs.partial/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idnamepairs.partial/actions/workflows/codeql.yml)

# Soenneker.Dtos.IdNamePairs.Partial

Represents a partial resource reference in which an identifier, a display name, or both may be supplied.

## Install

```bash
dotnet add package Soenneker.Dtos.IdNamePairs.Partial
```

## What you get

- `PartialIdNamePair` — Represents a partial resource reference in which an identifier, a display name, or both may be supplied.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `PartialIdNamePair.Id` | Stable resource identifier, when known. | Stable resource identifier, when known. |
| `PartialIdNamePair.Name` | Human-readable resource name, when known. | Human-readable resource name, when known. |
