[![](https://img.shields.io/nuget/v/soenneker.dtos.idnamepairs.partial.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.idnamepairs.partial/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idnamepairs.partial/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idnamepairs.partial/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.idnamepairs.partial.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.idnamepairs.partial/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idnamepairs.partial/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idnamepairs.partial/actions/workflows/codeql.yml)

# Soenneker.Dtos.IdNamePairs.Partial

Represents a resource reference where the identifier, display name, or both may be known.

## Installation

```bash
dotnet add package Soenneker.Dtos.IdNamePairs.Partial
```

## Usage

```csharp
using Soenneker.Dtos.IdNamePairs.Partial;

var byId = new PartialIdNamePair {Id = "user-42"};
var byName = new PartialIdNamePair {Name = "Ada Lovelace"};
var complete = new PartialIdNamePair
{
    Id = "user-42",
    Name = "Ada Lovelace"
};
```

Both System.Text.Json and Newtonsoft.Json use `id` and `name` as wire names. Whether null properties appear in JSON depends on the serializer’s null-handling configuration.

The record permits both properties to be null. It does not require at least one value, resolve a name to an identifier, state which property takes precedence, or validate either value. Define those rules in the consuming request or service.

Record equality and hash codes include both properties. Because they are mutable, do not change a `PartialIdNamePair` while it is stored in a hash set or used as a dictionary key; create a copy with `with` when stable value semantics matter.
