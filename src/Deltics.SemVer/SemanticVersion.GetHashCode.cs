using System;

namespace Deltics.SemVer
{
    public partial class SemanticVersion
    {
        public override int GetHashCode()
        {
            var hash = this.Major;

            hash = ((hash << 16) | (hash >> 16)) ^ this.Minor;
            hash = ((hash << 24) | (hash >> 8)) ^ this.Patch;

            foreach (var ident in this.PreReleaseIdentifiers)
            {
                var shift = 0;
                foreach (var b in ident)
                {
                    hash  = ((hash << shift) | (hash >> (32 - shift))) ^ b;
                    shift = (shift + 8) % 32;
                }
            }

            return hash;
        }
    }
}