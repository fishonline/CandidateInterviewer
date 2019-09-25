﻿using DK.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DK.DataAccess.Configuration
{
    public class CandidateMap : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.ToTable("Candidate");

            builder.HasKey(ci => ci.Id);
            builder.Property(ci => ci.Id)
                       .ForSqlServerUseSequenceHiLo("question_hilo")
                       .IsRequired();

            builder.Property(a => a.FirstName)
                .HasMaxLength(60);

            builder.Property(a => a.LastName)
                .HasMaxLength(60);

            builder.Property(a => a.Email)
                .HasMaxLength(60);

            builder.Property(a => a.Description)
                .HasMaxLength(180);

            builder.HasOne(ci => ci.Interview)
                .WithMany()
                .HasForeignKey(ci => ci.InterviewId);
        }
    }
}
