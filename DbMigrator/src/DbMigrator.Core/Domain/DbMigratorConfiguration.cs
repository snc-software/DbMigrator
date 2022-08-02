namespace DbMigrator.Core.Domain;

public record DbMigratorConfiguration(string ConnectionString, string FilePath);