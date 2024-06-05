// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class DependentDerivedEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentDerived<int>",
                typeof(CompiledModelTestBase.DependentDerived<int>),
                baseEntityType,
                propertyCount: 2,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(CompiledModelTestBase.AbstractBase).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<int>).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.SetGetter(
                (CompiledModelTestBase.DependentDerived<int> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity),
                (CompiledModelTestBase.DependentDerived<int> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity) == 0,
                (CompiledModelTestBase.DependentDerived<int> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(instance),
                (CompiledModelTestBase.DependentDerived<int> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(instance) == 0);
            id.SetSetter(
                (CompiledModelTestBase.DependentDerived<int> entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity) = value);
            id.SetMaterializationSetter(
                (CompiledModelTestBase.DependentDerived<int> entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity) = value);
            id.SetAccessors(
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id((CompiledModelTestBase.DependentDerived<int>)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id((CompiledModelTestBase.DependentDerived<int>)entry.Entity),
                (InternalEntityEntry entry) => entry.ReadOriginalValue<int>(id, 0),
                (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<int>(id, 0),
                (ValueBuffer valueBuffer) => valueBuffer[0]);
            id.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: -1,
                relationshipIndex: 0,
                storeGenerationIndex: -1);
            id.TypeMapping = IntTypeMapping.Default.Clone(
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
                    (int v) => v));
            id.SetCurrentValueComparer(new EntryCurrentValueComparer<int>(id));
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);
            id.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("DependentDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id", "TestNamespace") });

            var data = runtimeEntityType.AddProperty(
                "Data",
                typeof(string),
                propertyInfo: typeof(CompiledModelTestBase.DependentDerived<int>).GetProperty("Data", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentDerived<int>).GetField("<Data>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            data.SetGetter(
                (CompiledModelTestBase.DependentDerived<int> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(entity),
                (CompiledModelTestBase.DependentDerived<int> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(entity) == null,
                (CompiledModelTestBase.DependentDerived<int> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(instance),
                (CompiledModelTestBase.DependentDerived<int> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(instance) == null);
            data.SetSetter(
                (CompiledModelTestBase.DependentDerived<int> entity, string value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(entity) = value);
            data.SetMaterializationSetter(
                (CompiledModelTestBase.DependentDerived<int> entity, string value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(entity) = value);
            data.SetAccessors(
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data((CompiledModelTestBase.DependentDerived<int>)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data((CompiledModelTestBase.DependentDerived<int>)entry.Entity),
                (InternalEntityEntry entry) => entry.ReadOriginalValue<string>(data, 1),
                (InternalEntityEntry entry) => entry.GetCurrentValue<string>(data),
                (ValueBuffer valueBuffer) => valueBuffer[1]);
            data.SetPropertyIndexes(
                index: 1,
                originalValueIndex: 1,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            data.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
                comparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => ((object)v).GetHashCode(),
                    (string v) => v),
                keyComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => ((object)v).GetHashCode(),
                    (string v) => v),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => ((object)v).GetHashCode(),
                    (string v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "nvarchar(max)",
                    unicode: true,
                    dbType: System.Data.DbType.String),
                storeTypePostfix: StoreTypePostfix.None);
            data.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);
            data.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("DependentDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data", "TestNamespace") });

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            var data = runtimeEntityType.FindProperty("Data")!;
            var key = runtimeEntityType.FindKey(new[] { id });
            key.SetPrincipalKeyValueFactory(KeyValueFactoryFactory.Create<int>(key));
            key.SetIdentityMapFactory(IdentityMapFactoryFactory.CreateFactory<int>(key));
            runtimeEntityType.SetOriginalValuesFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelTestBase.DependentDerived<int>)source.Entity;
                    return (ISnapshot)new Snapshot<int, string>(((ValueComparer<int>)((IProperty)id).GetValueComparer()).Snapshot(source.GetCurrentValue<int>(id)), source.GetCurrentValue<string>(data) == null ? null : ((ValueComparer<string>)((IProperty)data).GetValueComparer()).Snapshot(source.GetCurrentValue<string>(data)));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                () => Snapshot.Empty);
            runtimeEntityType.SetTemporaryValuesFactory(
                (InternalEntityEntry source) => Snapshot.Empty);
            runtimeEntityType.SetShadowValuesFactory(
                (IDictionary<string, object> source) => Snapshot.Empty);
            runtimeEntityType.SetEmptyShadowValuesFactory(
                () => Snapshot.Empty);
            runtimeEntityType.SetRelationshipSnapshotFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelTestBase.DependentDerived<int>)source.Entity;
                    return (ISnapshot)new Snapshot<int>(((ValueComparer<int>)((IProperty)id).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<int>(id)));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 2,
                navigationCount: 0,
                complexPropertyCount: 0,
                originalValueCount: 2,
                shadowCount: 0,
                relationshipCount: 1,
                storeGeneratedCount: 0);
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "DependentDerived<int>");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Id>k__BackingField")]
        public static extern ref int UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(CompiledModelTestBase.DependentDerived<int> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Data>k__BackingField")]
        public static extern ref string UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(CompiledModelTestBase.DependentDerived<int> @this);
    }
}
