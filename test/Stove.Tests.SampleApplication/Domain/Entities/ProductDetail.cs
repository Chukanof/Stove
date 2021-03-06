﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using JetBrains.Annotations;

using Stove.Domain.Entities;

namespace Stove.Tests.SampleApplication.Domain.Entities
{
    [Table("ProductDetail")]
    public class ProductDetail : Entity
    {
        private ProductDetail()
        {
        }

        [Required]
        [NotNull]
        public virtual string Description { get; protected set; }

        [Required]
        [NotNull]
        public virtual Product Product { get; protected set; }
        public int ProductId { get; [UsedImplicitly] private set; }
    }
}
