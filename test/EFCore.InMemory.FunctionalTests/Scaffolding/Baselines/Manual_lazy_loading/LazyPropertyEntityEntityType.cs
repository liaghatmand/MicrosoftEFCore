// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class LazyPropertyEntityEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelInMemoryTest+LazyPropertyEntity",
                typeof(CompiledModelInMemoryTest.LazyPropertyEntity),
                baseEntityType,
                propertyCount: 2,
                navigationCount: 1,
                servicePropertyCount: 1,
                foreignKeyCount: 1,
                unnamedIndexCount: 1,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyPropertyEntity).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.LazyPropertyEntity).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.SetGetter(
                (CompiledModelInMemoryTest.LazyPropertyEntity entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_Id(entity),
                (CompiledModelInMemoryTest.LazyPropertyEntity entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_Id(entity) == 0,
                (CompiledModelInMemoryTest.LazyPropertyEntity instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_Id(instance),
                (CompiledModelInMemoryTest.LazyPropertyEntity instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_Id(instance) == 0);
            id.SetSetter(
                (CompiledModelInMemoryTest.LazyPropertyEntity entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_Id(entity) = value);
            id.SetMaterializationSetter(
                (CompiledModelInMemoryTest.LazyPropertyEntity entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_Id(entity) = value);
            id.SetAccessors(
                (InternalEntityEntry entry) => entry.FlaggedAsStoreGenerated(0) ? entry.ReadStoreGeneratedValue<int>(0) : entry.FlaggedAsTemporary(0) && UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_Id((CompiledModelInMemoryTest.LazyPropertyEntity)entry.Entity) == 0 ? entry.ReadTemporaryValue<int>(0) : UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_Id((CompiledModelInMemoryTest.LazyPropertyEntity)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_Id((CompiledModelInMemoryTest.LazyPropertyEntity)entry.Entity),
                (InternalEntityEntry entry) => entry.ReadOriginalValue<int>(id, 0),
                (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<int>(id, 0),
                (ValueBuffer valueBuffer) => valueBuffer[0]);
            id.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: -1,
                relationshipIndex: 0,
                storeGenerationIndex: 0);
            id.TypeMapping = InMemoryTypeMapping.Default.Clone(
                comparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                keyComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                clrType: typeof(int),
                jsonValueReaderWriter: JsonInt32ReaderWriter.Instance);
            id.SetCurrentValueComparer(new EntryCurrentValueComparer<int>(id));
            id.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("LazyPropertyEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_Id", "TestNamespace") });

            var lazyConstructorEntityId = runtimeEntityType.AddProperty(
                "LazyConstructorEntityId",
                typeof(int),
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyPropertyEntity).GetProperty("LazyConstructorEntityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.LazyPropertyEntity).GetField("<LazyConstructorEntityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            lazyConstructorEntityId.SetGetter(
                (CompiledModelInMemoryTest.LazyPropertyEntity entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntityId(entity),
                (CompiledModelInMemoryTest.LazyPropertyEntity entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntityId(entity) == 0,
                (CompiledModelInMemoryTest.LazyPropertyEntity instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntityId(instance),
                (CompiledModelInMemoryTest.LazyPropertyEntity instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntityId(instance) == 0);
            lazyConstructorEntityId.SetSetter(
                (CompiledModelInMemoryTest.LazyPropertyEntity entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntityId(entity) = value);
            lazyConstructorEntityId.SetMaterializationSetter(
                (CompiledModelInMemoryTest.LazyPropertyEntity entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntityId(entity) = value);
            lazyConstructorEntityId.SetAccessors(
                (InternalEntityEntry entry) => entry.FlaggedAsStoreGenerated(1) ? entry.ReadStoreGeneratedValue<int>(1) : entry.FlaggedAsTemporary(1) && UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntityId((CompiledModelInMemoryTest.LazyPropertyEntity)entry.Entity) == 0 ? entry.ReadTemporaryValue<int>(1) : UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntityId((CompiledModelInMemoryTest.LazyPropertyEntity)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntityId((CompiledModelInMemoryTest.LazyPropertyEntity)entry.Entity),
                (InternalEntityEntry entry) => entry.ReadOriginalValue<int>(lazyConstructorEntityId, 1),
                (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<int>(lazyConstructorEntityId, 1),
                (ValueBuffer valueBuffer) => valueBuffer[1]);
            lazyConstructorEntityId.SetPropertyIndexes(
                index: 1,
                originalValueIndex: 1,
                shadowIndex: -1,
                relationshipIndex: 1,
                storeGenerationIndex: 1);
            lazyConstructorEntityId.TypeMapping = InMemoryTypeMapping.Default.Clone(
                comparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                keyComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                clrType: typeof(int),
                jsonValueReaderWriter: JsonInt32ReaderWriter.Instance);
            lazyConstructorEntityId.SetCurrentValueComparer(new EntryCurrentValueComparer<int>(lazyConstructorEntityId));
            lazyConstructorEntityId.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("LazyPropertyEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntityId", "TestNamespace") });

            var loader = runtimeEntityType.AddServiceProperty(
                "Loader",
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyPropertyEntity).GetProperty("Loader", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                serviceType: typeof(ILazyLoader));
            loader.SetPropertyIndexes(
                index: -1,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { lazyConstructorEntityId },
                unique: true);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("LazyConstructorEntityId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                unique: true,
                required: true);

            var lazyConstructorEntity = declaringEntityType.AddNavigation("LazyConstructorEntity",
                runtimeForeignKey,
                onDependent: true,
                typeof(CompiledModelInMemoryTest.LazyConstructorEntity),
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyPropertyEntity).GetProperty("LazyConstructorEntity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.LazyPropertyEntity).GetField("<LazyConstructorEntity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                propertyAccessMode: PropertyAccessMode.Field);

            lazyConstructorEntity.SetGetter(
                (CompiledModelInMemoryTest.LazyPropertyEntity entity) => LazyPropertyEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntity(entity),
                (CompiledModelInMemoryTest.LazyPropertyEntity entity) => LazyPropertyEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntity(entity) == null,
                (CompiledModelInMemoryTest.LazyPropertyEntity instance) => LazyPropertyEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntity(instance),
                (CompiledModelInMemoryTest.LazyPropertyEntity instance) => LazyPropertyEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntity(instance) == null);
            lazyConstructorEntity.SetSetter(
                (CompiledModelInMemoryTest.LazyPropertyEntity entity, CompiledModelInMemoryTest.LazyConstructorEntity value) => LazyPropertyEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntity(entity) = value);
            lazyConstructorEntity.SetMaterializationSetter(
                (CompiledModelInMemoryTest.LazyPropertyEntity entity, CompiledModelInMemoryTest.LazyConstructorEntity value) => LazyPropertyEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntity(entity) = value);
            lazyConstructorEntity.SetAccessors(
                (InternalEntityEntry entry) => LazyPropertyEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntity((CompiledModelInMemoryTest.LazyPropertyEntity)entry.Entity),
                (InternalEntityEntry entry) => LazyPropertyEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntity((CompiledModelInMemoryTest.LazyPropertyEntity)entry.Entity),
                null,
                (InternalEntityEntry entry) => entry.GetCurrentValue<CompiledModelInMemoryTest.LazyConstructorEntity>(lazyConstructorEntity),
                null);
            lazyConstructorEntity.SetPropertyIndexes(
                index: 0,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: 2,
                storeGenerationIndex: -1);
            var lazyPropertyEntity = principalEntityType.AddNavigation("LazyPropertyEntity",
                runtimeForeignKey,
                onDependent: false,
                typeof(CompiledModelInMemoryTest.LazyPropertyEntity),
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyConstructorEntity).GetProperty("LazyPropertyEntity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.LazyConstructorEntity).GetField("<LazyPropertyEntity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                propertyAccessMode: PropertyAccessMode.Field);

            lazyPropertyEntity.SetGetter(
                (CompiledModelInMemoryTest.LazyConstructorEntity entity) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyEntity(entity),
                (CompiledModelInMemoryTest.LazyConstructorEntity entity) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyEntity(entity) == null,
                (CompiledModelInMemoryTest.LazyConstructorEntity instance) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyEntity(instance),
                (CompiledModelInMemoryTest.LazyConstructorEntity instance) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyEntity(instance) == null);
            lazyPropertyEntity.SetSetter(
                (CompiledModelInMemoryTest.LazyConstructorEntity entity, CompiledModelInMemoryTest.LazyPropertyEntity value) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyEntity(entity) = value);
            lazyPropertyEntity.SetMaterializationSetter(
                (CompiledModelInMemoryTest.LazyConstructorEntity entity, CompiledModelInMemoryTest.LazyPropertyEntity value) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyEntity(entity) = value);
            lazyPropertyEntity.SetAccessors(
                (InternalEntityEntry entry) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyEntity((CompiledModelInMemoryTest.LazyConstructorEntity)entry.Entity),
                (InternalEntityEntry entry) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyEntity((CompiledModelInMemoryTest.LazyConstructorEntity)entry.Entity),
                null,
                (InternalEntityEntry entry) => entry.GetCurrentValue<CompiledModelInMemoryTest.LazyPropertyEntity>(lazyPropertyEntity),
                null);
            lazyPropertyEntity.SetPropertyIndexes(
                index: 1,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: 2,
                storeGenerationIndex: -1);
            lazyPropertyEntity.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyEntity", "TestNamespace") });
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            var lazyConstructorEntityId = runtimeEntityType.FindProperty("LazyConstructorEntityId")!;
            var key = runtimeEntityType.FindKey(new[] { id });
            key.SetPrincipalKeyValueFactory(KeyValueFactoryFactory.Create<int>(key));
            key.SetIdentityMapFactory(IdentityMapFactoryFactory.CreateFactory<int>(key));
            var lazyConstructorEntity = runtimeEntityType.FindNavigation("LazyConstructorEntity")!;
            runtimeEntityType.SetOriginalValuesFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelInMemoryTest.LazyPropertyEntity)source.Entity;
                    return (ISnapshot)new Snapshot<int, int>(((ValueComparer<int>)((IProperty)id).GetValueComparer()).Snapshot(source.GetCurrentValue<int>(id)), ((ValueComparer<int>)((IProperty)lazyConstructorEntityId).GetValueComparer()).Snapshot(source.GetCurrentValue<int>(lazyConstructorEntityId)));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                () => (ISnapshot)new Snapshot<int, int>(((ValueComparer<int>)((IProperty)id).GetValueComparer()).Snapshot(default(int)), ((ValueComparer<int>)((IProperty)lazyConstructorEntityId).GetValueComparer()).Snapshot(default(int))));
            runtimeEntityType.SetTemporaryValuesFactory(
                (InternalEntityEntry source) => (ISnapshot)new Snapshot<int, int>(default(int), default(int)));
            runtimeEntityType.SetShadowValuesFactory(
                (IDictionary<string, object> source) => Snapshot.Empty);
            runtimeEntityType.SetEmptyShadowValuesFactory(
                () => Snapshot.Empty);
            runtimeEntityType.SetRelationshipSnapshotFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelInMemoryTest.LazyPropertyEntity)source.Entity;
                    return (ISnapshot)new Snapshot<int, int, object>(((ValueComparer<int>)((IProperty)id).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<int>(id)), ((ValueComparer<int>)((IProperty)lazyConstructorEntityId).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<int>(lazyConstructorEntityId)), UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntity(entity));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 2,
                navigationCount: 1,
                complexPropertyCount: 0,
                originalValueCount: 2,
                shadowCount: 0,
                relationshipCount: 3,
                storeGeneratedCount: 2);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Id>k__BackingField")]
        public static extern ref int UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_Id(CompiledModelInMemoryTest.LazyPropertyEntity @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<LazyConstructorEntityId>k__BackingField")]
        public static extern ref int UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntityId(CompiledModelInMemoryTest.LazyPropertyEntity @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<LazyConstructorEntity>k__BackingField")]
        public static extern ref CompiledModelInMemoryTest.LazyConstructorEntity UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyEntity_LazyConstructorEntity(CompiledModelInMemoryTest.LazyPropertyEntity @this);
    }
}
