// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.ValueGeneration;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class DependentBaseEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentBase<byte?>",
                typeof(CompiledModelTestBase.DependentBase<byte?>),
                baseEntityType,
                discriminatorProperty: "EnumDiscriminator",
                discriminatorValue: CompiledModelTestBase.Enum1.One,
                derivedTypesCount: 1,
                propertyCount: 4,
                navigationCount: 1,
                foreignKeyCount: 2,
                unnamedIndexCount: 1,
                keyCount: 1);

            var principalId = runtimeEntityType.AddProperty(
                "PrincipalId",
                typeof(long),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            principalId.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: 0,
                relationshipIndex: 0,
                storeGenerationIndex: 0);
            principalId.TypeMapping = LongTypeMapping.Default.Clone(
                comparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => ((object)v).GetHashCode(),
                    (long v) => v),
                keyComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => ((object)v).GetHashCode(),
                    (long v) => v),
                providerValueComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => ((object)v).GetHashCode(),
                    (long v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"));
            principalId.SetCurrentValueComparer(new EntryCurrentValueComparer<long>(principalId));

            var principalAlternateId = runtimeEntityType.AddProperty(
                "PrincipalAlternateId",
                typeof(Guid),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            principalAlternateId.SetPropertyIndexes(
                index: 1,
                originalValueIndex: 1,
                shadowIndex: 1,
                relationshipIndex: 1,
                storeGenerationIndex: 1);
            principalAlternateId.TypeMapping = SqliteGuidTypeMapping.Default;
            principalAlternateId.SetCurrentValueComparer(new EntryCurrentValueComparer<Guid>(principalAlternateId));

            var enumDiscriminator = runtimeEntityType.AddProperty(
                "EnumDiscriminator",
                typeof(CompiledModelTestBase.Enum1),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                valueGeneratorFactory: new DiscriminatorValueGeneratorFactory().Create);
            enumDiscriminator.SetPropertyIndexes(
                index: 2,
                originalValueIndex: 2,
                shadowIndex: 2,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            enumDiscriminator.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<CompiledModelTestBase.Enum1>(
                    (CompiledModelTestBase.Enum1 v1, CompiledModelTestBase.Enum1 v2) => object.Equals((object)v1, (object)v2),
                    (CompiledModelTestBase.Enum1 v) => ((object)v).GetHashCode(),
                    (CompiledModelTestBase.Enum1 v) => v),
                keyComparer: new ValueComparer<CompiledModelTestBase.Enum1>(
                    (CompiledModelTestBase.Enum1 v1, CompiledModelTestBase.Enum1 v2) => object.Equals((object)v1, (object)v2),
                    (CompiledModelTestBase.Enum1 v) => ((object)v).GetHashCode(),
                    (CompiledModelTestBase.Enum1 v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"),
                converter: new ValueConverter<CompiledModelTestBase.Enum1, int>(
                    (CompiledModelTestBase.Enum1 value) => (int)value,
                    (int value) => (CompiledModelTestBase.Enum1)value),
                jsonValueReaderWriter: new JsonConvertedValueReaderWriter<CompiledModelTestBase.Enum1, int>(
                    JsonInt32ReaderWriter.Instance,
                    new ValueConverter<CompiledModelTestBase.Enum1, int>(
                        (CompiledModelTestBase.Enum1 value) => (int)value,
                        (int value) => (CompiledModelTestBase.Enum1)value)));
            enumDiscriminator.SetSentinelFromProviderValue(0);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(byte?),
                propertyInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetProperty("Id", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            id.SetGetter(
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity),
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity) => !UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity).HasValue,
                (CompiledModelTestBase.DependentBase<Nullable<byte>> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(instance),
                (CompiledModelTestBase.DependentBase<Nullable<byte>> instance) => !UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(instance).HasValue);
            id.SetSetter(
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity, Nullable<byte> value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity) = value);
            id.SetMaterializationSetter(
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity, Nullable<byte> value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity) = value);
            id.SetAccessors(
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id((CompiledModelTestBase.DependentBase<Nullable<byte>>)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id((CompiledModelTestBase.DependentBase<Nullable<byte>>)entry.Entity),
                (InternalEntityEntry entry) => entry.ReadOriginalValue<Nullable<byte>>(id, 3),
                (InternalEntityEntry entry) => entry.GetCurrentValue<Nullable<byte>>(id),
                (ValueBuffer valueBuffer) => valueBuffer[3]);
            id.SetPropertyIndexes(
                index: 3,
                originalValueIndex: 3,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            id.TypeMapping = ByteTypeMapping.Default.Clone(
                comparer: new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v),
                keyComparer: new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v),
                providerValueComparer: new ValueComparer<byte>(
                    (byte v1, byte v2) => v1 == v2,
                    (byte v) => (int)v,
                    (byte v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"));
            id.SetValueComparer(new NullableValueComparer<byte>(id.TypeMapping.Comparer));
            id.SetKeyValueComparer(new NullableValueComparer<byte>(id.TypeMapping.KeyComparer));
            id.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id", "TestNamespace") });

            var key = runtimeEntityType.AddKey(
                new[] { principalId, principalAlternateId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { principalId },
                unique: true);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                unique: true,
                required: true);

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalId"), declaringEntityType.FindProperty("PrincipalAlternateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id"), principalEntityType.FindProperty("AlternateId") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.ClientNoAction,
                unique: true,
                required: true);

            var principal = declaringEntityType.AddNavigation("Principal",
                runtimeForeignKey,
                onDependent: true,
                typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>),
                propertyInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetProperty("Principal", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetField("<Principal>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            principal.SetGetter(
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(entity),
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(entity) == null,
                (CompiledModelTestBase.DependentBase<Nullable<byte>> instance) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(instance),
                (CompiledModelTestBase.DependentBase<Nullable<byte>> instance) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(instance) == null);
            principal.SetSetter(
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity, CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> value) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(entity) = value);
            principal.SetMaterializationSetter(
                (CompiledModelTestBase.DependentBase<Nullable<byte>> entity, CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> value) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(entity) = value);
            principal.SetAccessors(
                (InternalEntityEntry entry) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal((CompiledModelTestBase.DependentBase<Nullable<byte>>)entry.Entity),
                (InternalEntityEntry entry) => DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal((CompiledModelTestBase.DependentBase<Nullable<byte>>)entry.Entity),
                null,
                (InternalEntityEntry entry) => entry.GetCurrentValue<CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>>>(principal),
                null);
            principal.SetPropertyIndexes(
                index: 0,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: 2,
                storeGenerationIndex: -1);
            var dependent = principalEntityType.AddNavigation("Dependent",
                runtimeForeignKey,
                onDependent: false,
                typeof(CompiledModelTestBase.DependentBase<byte?>),
                propertyInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetProperty("Dependent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetField("<Dependent>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                eagerLoaded: true,
                lazyLoadingEnabled: false);

            dependent.SetGetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(entity),
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(entity) == null,
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> instance) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(instance),
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> instance) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(instance) == null);
            dependent.SetSetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity, CompiledModelTestBase.DependentBase<Nullable<byte>> value) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(entity) = value);
            dependent.SetMaterializationSetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity, CompiledModelTestBase.DependentBase<Nullable<byte>> value) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(entity) = value);
            dependent.SetAccessors(
                (InternalEntityEntry entry) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>>)entry.Entity),
                (InternalEntityEntry entry) => PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>>)entry.Entity),
                null,
                (InternalEntityEntry entry) => entry.GetCurrentValue<CompiledModelTestBase.DependentBase<Nullable<byte>>>(dependent),
                null);
            dependent.SetPropertyIndexes(
                index: 2,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: 4,
                storeGenerationIndex: -1);
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var principalId = runtimeEntityType.FindProperty("PrincipalId")!;
            var principalAlternateId = runtimeEntityType.FindProperty("PrincipalAlternateId")!;
            var enumDiscriminator = runtimeEntityType.FindProperty("EnumDiscriminator")!;
            var id = runtimeEntityType.FindProperty("Id")!;
            var key = runtimeEntityType.FindKey(new[] { principalId, principalAlternateId });
            key.SetPrincipalKeyValueFactory(KeyValueFactoryFactory.Create<IReadOnlyList<object>>(key));
            key.SetIdentityMapFactory(IdentityMapFactoryFactory.CreateFactory<IReadOnlyList<object>>(key));
            var principal = runtimeEntityType.FindNavigation("Principal")!;
            runtimeEntityType.SetOriginalValuesFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelTestBase.DependentBase<Nullable<byte>>)source.Entity;
                    return (ISnapshot)new Snapshot<long, Guid, CompiledModelTestBase.Enum1, Nullable<byte>>(((ValueComparer<long>)((IProperty)principalId).GetValueComparer()).Snapshot(source.GetCurrentValue<long>(principalId)), ((ValueComparer<Guid>)((IProperty)principalAlternateId).GetValueComparer()).Snapshot(source.GetCurrentValue<Guid>(principalAlternateId)), ((ValueComparer<CompiledModelTestBase.Enum1>)((IProperty)enumDiscriminator).GetValueComparer()).Snapshot(source.GetCurrentValue<CompiledModelTestBase.Enum1>(enumDiscriminator)), source.GetCurrentValue<Nullable<byte>>(id) == null ? null : ((ValueComparer<Nullable<byte>>)((IProperty)id).GetValueComparer()).Snapshot(source.GetCurrentValue<Nullable<byte>>(id)));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                () => (ISnapshot)new Snapshot<long, Guid>(((ValueComparer<long>)((IProperty)principalId).GetValueComparer()).Snapshot(default(long)), ((ValueComparer<Guid>)((IProperty)principalAlternateId).GetValueComparer()).Snapshot(default(Guid))));
            runtimeEntityType.SetTemporaryValuesFactory(
                (InternalEntityEntry source) => (ISnapshot)new Snapshot<long, Guid>(default(long), default(Guid)));
            runtimeEntityType.SetShadowValuesFactory(
                (IDictionary<string, object> source) => (ISnapshot)new Snapshot<long, Guid, CompiledModelTestBase.Enum1>(source.ContainsKey("PrincipalId") ? (long)source["PrincipalId"] : 0L, source.ContainsKey("PrincipalAlternateId") ? (Guid)source["PrincipalAlternateId"] : new Guid("00000000-0000-0000-0000-000000000000"), source.ContainsKey("EnumDiscriminator") ? (CompiledModelTestBase.Enum1)source["EnumDiscriminator"] : CompiledModelTestBase.Enum1.Default));
            runtimeEntityType.SetEmptyShadowValuesFactory(
                () => (ISnapshot)new Snapshot<long, Guid, CompiledModelTestBase.Enum1>(default(long), default(Guid), default(CompiledModelTestBase.Enum1)));
            runtimeEntityType.SetRelationshipSnapshotFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelTestBase.DependentBase<Nullable<byte>>)source.Entity;
                    return (ISnapshot)new Snapshot<long, Guid, object>(((ValueComparer<long>)((IProperty)principalId).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<long>(principalId)), ((ValueComparer<Guid>)((IProperty)principalAlternateId).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<Guid>(principalAlternateId)), UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(entity));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 4,
                navigationCount: 1,
                complexPropertyCount: 0,
                originalValueCount: 4,
                shadowCount: 3,
                relationshipCount: 3,
                storeGeneratedCount: 2);
            runtimeEntityType.AddAnnotation("DiscriminatorMappingComplete", false);
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:MappingStrategy", "TPH");
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "DependentBase<byte?>");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Id>k__BackingField")]
        public static extern ref byte? UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(CompiledModelTestBase.DependentBase<byte?> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Principal>k__BackingField")]
        public static extern ref CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(CompiledModelTestBase.DependentBase<byte?> @this);
    }
}
