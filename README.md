# Deltics.SemVer

An implementation of Semver 2.0 for C#

If you are looking for the Delphi implementation and/or duget package, this may be found [here](https://github.com/deltics/deltics.semver).

## Classes

* SemanticVersion

## SemanticVersion

### Properties

* int Major
* int Minor
* int Patch
* string[] PreReleaseIdentifiers
* string[] BuildIdentifiers

All properties are read-only.

`PreReleaseIdentifiers` and `BuildIdentifiers` will be empty arrays if no identifiers are specified.  i.e. these properties are never `null`.


### Constructors
```csharp
SemanticVersion(int major, int minor, int patch, IEnumerable<string> prereleaseIdentifiers = null, IEnumerable<string> buildIdentifiers = null)
```
Initialises a new `SemanticVersion` instance with the specified parameters.

If `prereleaseIdentifiers` is `null` or not specified then the version object will represent a release version.

`buildIdentifiers` are optional and may be specified for release or pre-release versions as required.

### Static Methods

```csharp
SemanticVersion Parse(s string)
```

Returns a new `SemanticVersion` object parsed from the specified string.

If the specific string is not a valid SemVer 2 version string, a `FormatException` is raised.

### Methods

```csharp
int GetHashCode()
```

Returns a unique hash code for the semantic version.

```csharp
* string ToString()
```

Returns a Semver 2.0 compliant representation of the semantic version.

### Operators

* &lt;
* &gt;
* &lt;=
* &gt;=
* ==
* !=
* Equals

