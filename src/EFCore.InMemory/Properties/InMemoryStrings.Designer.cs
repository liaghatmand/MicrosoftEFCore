// <auto-generated />

using System.Resources;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;

#nullable enable

namespace Microsoft.EntityFrameworkCore.InMemory.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static class InMemoryStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.InMemory.Properties.InMemoryStrings", typeof(InMemoryStrings).Assembly);

        /// <summary>
        ///     Cannot apply 'DefaultIfEmpty' after a client-evaluated projection. Consider applying 'DefaultIfEmpty' before last 'Select' or use 'AsEnumerable' before 'DefaultIfEmpty' to apply it on client-side.
        /// </summary>
        public static string DefaultIfEmptyAppliedAfterProjection
            => GetString("DefaultIfEmptyAppliedAfterProjection");

        /// <summary>
        ///     Using 'Distinct' operation on a projection containing a subquery is not supported.
        /// </summary>
        public static string DistinctOnSubqueryNotSupported
            => GetString("DistinctOnSubqueryNotSupported");

        /// <summary>
        ///     The specified entity type '{derivedType}' is not derived from '{entityType}'.
        /// </summary>
        public static string InvalidDerivedTypeInEntityProjection(object? derivedType, object? entityType)
            => string.Format(
                GetString("InvalidDerivedTypeInEntityProjection", nameof(derivedType), nameof(entityType)),
                derivedType, entityType);

        /// <summary>
        ///     There is no query string because the in-memory provider does not use a string-based query language.
        /// </summary>
        public static string NoQueryStrings
            => GetString("NoQueryStrings");

        /// <summary>
        ///     Required properties '{requiredProperties}' are missing for the instance of entity type '{entityType}'. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the entity key value.
        /// </summary>
        public static string NullabilityErrorException(object? requiredProperties, object? entityType)
            => string.Format(
                GetString("NullabilityErrorException", nameof(requiredProperties), nameof(entityType)),
                requiredProperties, entityType);

        /// <summary>
        ///     Required properties '{requiredProperties}' are missing for the instance of entity type '{entityType}' with the key value '{keyValue}'.
        /// </summary>
        public static string NullabilityErrorExceptionSensitive(object? requiredProperties, object? entityType, object? keyValue)
            => string.Format(
                GetString("NullabilityErrorExceptionSensitive", nameof(requiredProperties), nameof(entityType), nameof(keyValue)),
                requiredProperties, entityType, keyValue);

        /// <summary>
        ///     Unable to translate set operation after client projection has been applied. Consider moving the set operation before the last 'Select' call.
        /// </summary>
        public static string SetOperationsNotAllowedAfterClientEvaluation
            => GetString("SetOperationsNotAllowedAfterClientEvaluation");

        /// <summary>
        ///     Unable to bind '{memberType}' '{member}' to entity projection of '{entityType}'.
        /// </summary>
        public static string UnableToBindMemberToEntityProjection(object? memberType, object? member, object? entityType)
            => string.Format(
                GetString("UnableToBindMemberToEntityProjection", nameof(memberType), nameof(member), nameof(entityType)),
                memberType, member, entityType);

        /// <summary>
        ///     Attempted to update or delete an entity that does not exist in the store.
        /// </summary>
        public static string UpdateConcurrencyException
            => GetString("UpdateConcurrencyException");

        /// <summary>
        ///     Conflicts were detected for instance of entity type '{entityType}' on the concurrency token properties {properties}. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the conflicting values.
        /// </summary>
        public static string UpdateConcurrencyTokenException(object? entityType, object? properties)
            => string.Format(
                GetString("UpdateConcurrencyTokenException", nameof(entityType), nameof(properties)),
                entityType, properties);

        /// <summary>
        ///     Conflicts were detected for instance of entity type '{entityType}' with the key value '{keyValue}' on the concurrency token property values {conflictingValues}, with corresponding database values {databaseValues}.
        /// </summary>
        public static string UpdateConcurrencyTokenExceptionSensitive(object? entityType, object? keyValue, object? conflictingValues, object? databaseValues)
            => string.Format(
                GetString("UpdateConcurrencyTokenExceptionSensitive", nameof(entityType), nameof(keyValue), nameof(conflictingValues), nameof(databaseValues)),
                entityType, keyValue, conflictingValues, databaseValues);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name)!;
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}

namespace Microsoft.EntityFrameworkCore.InMemory.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static class InMemoryResources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.InMemory.Properties.InMemoryStrings", typeof(InMemoryResources).Assembly);

        /// <summary>
        ///     Saved {count} entities to in-memory store.
        /// </summary>
        public static EventDefinition<int> LogSavedChanges(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.InMemoryLoggingDefinitions)logger.Definitions).LogSavedChanges;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.InMemoryLoggingDefinitions)logger.Definitions).LogSavedChanges,
                    logger,
                    static logger => new EventDefinition<int>(
                        logger.Options,
                        InMemoryEventId.ChangesSaved,
                        LogLevel.Information,
                        "InMemoryEventId.ChangesSaved",
                        level => LoggerMessage.Define<int>(
                            level,
                            InMemoryEventId.ChangesSaved,
                            _resourceManager.GetString("LogSavedChanges")!)));
            }

            return (EventDefinition<int>)definition;
        }

        /// <summary>
        ///     Transactions are not supported by the in-memory store. See http://go.microsoft.com/fwlink/?LinkId=800142
        /// </summary>
        public static EventDefinition LogTransactionsNotSupported(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.InMemoryLoggingDefinitions)logger.Definitions).LogTransactionsNotSupported;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.InMemoryLoggingDefinitions)logger.Definitions).LogTransactionsNotSupported,
                    logger,
                    static logger => new EventDefinition(
                        logger.Options,
                        InMemoryEventId.TransactionIgnoredWarning,
                        LogLevel.Warning,
                        "InMemoryEventId.TransactionIgnoredWarning",
                        level => LoggerMessage.Define(
                            level,
                            InMemoryEventId.TransactionIgnoredWarning,
                            _resourceManager.GetString("LogTransactionsNotSupported")!)));
            }

            return (EventDefinition)definition;
        }
    }
}
