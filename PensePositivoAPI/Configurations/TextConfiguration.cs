using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PensePositivoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensePositivoAPI.Configurations
{
    public class TextConfiguration : IEntityTypeConfiguration<Text>
    {
        public void Configure(EntityTypeBuilder<Text> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.AuthorId).IsRequired(false);
            builder.Property(t => t.Title).HasColumnType("VARCHAR").HasMaxLength(110);
            builder.Property(t => t.Description).HasColumnType("VARCHAR").HasMaxLength(550).IsRequired();
        }
    }
}
