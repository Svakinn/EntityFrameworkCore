﻿using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Utilities;

namespace Microsoft.EntityFrameworkCore.Metadata
{
    public class DocumentDbAnnotations
    {
        public DocumentDbAnnotations([NotNull] IAnnotatable metadata)
        {
            Check.NotNull(metadata, nameof(metadata));

            Metadata = metadata;
        }

        public virtual IAnnotatable Metadata { get; }
        public virtual bool SetAnnotation(
            [NotNull] string annotationName,
            [CanBeNull] object value)
        {
            ((IMutableAnnotatable)Metadata)[annotationName] = value;

            return true;
        }
        public virtual bool CanSetAnnotation(
            [NotNull] string relationalAnnotationName,
            [CanBeNull] object value)
            => true;
    }
}
