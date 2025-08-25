using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task = TaskManager.Domain.Entities.Task;

namespace TaskManager.Infrastructure.Configurations;

public class TaskConfiguration : IEntityTypeConfiguration<Task>
{
    public void Configure(EntityTypeBuilder<Task> builder)
    {
        builder.Property(t => t.Title)
            .HasMaxLength(100);
        
        builder.Property(t => t.Description)
            .HasMaxLength(300);
    }
}