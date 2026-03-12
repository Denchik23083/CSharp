using J.A.R.V.I.S.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace J.A.R.V.I.S.Db.EntitiesConfig
{
    public class CommandsConfiguration : IEntityTypeConfiguration<Commands>
    {
        public void Configure(EntityTypeBuilder<Commands> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Command).IsRequired();

            builder.ToTable("Commands").HasData(
                new Commands { Id = 1, Command = "Jarvis" },
                new Commands { Id = 2, Command = "Who are you?" },
                new Commands { Id = 3, Command = "What can you do?" },
                new Commands { Id = 4, Command = "What is my name?" },
                new Commands { Id = 5, Command = "Say date" },
                new Commands { Id = 6, Command = "Say time" },
                new Commands { Id = 7, Command = "Say day" },
                new Commands { Id = 8, Command = "Show commands" },
                new Commands { Id = 9, Command = "Hide commands" },
                new Commands { Id = 10, Command = "Mute" },
                new Commands { Id = 11, Command = "Unmute" },
                new Commands { Id = 12, Command = "Sleep" },
                new Commands { Id = 13, Command = "Wake up" },
                new Commands { Id = 14, Command = "Clear" },
                new Commands { Id = 15, Command = "Navi" },
                new Commands { Id = 16, Command = "Naruto" },
                new Commands { Id = 17, Command = "Google" },
                new Commands { Id = 18, Command = "Youtube" },
                new Commands { Id = 19, Command = "Instagram" },
                new Commands { Id = 20, Command = "Jira" },
                new Commands { Id = 21, Command = "GitHub" },
                new Commands { Id = 22, Command = "Telegram" },
                new Commands { Id = 23, Command = "Visual Studio" },
                new Commands { Id = 24, Command = "SQL" },
                new Commands { Id = 25, Command = "Close" });
        }
    }
}
