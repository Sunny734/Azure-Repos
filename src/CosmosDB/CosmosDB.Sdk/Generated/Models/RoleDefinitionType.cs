// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Models
{

    /// <summary>
    /// Defines values for RoleDefinitionType.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RoleDefinitionType
    {
        [System.Runtime.Serialization.EnumMember(Value = "BuiltInRole")]
        BuiltInRole,
        [System.Runtime.Serialization.EnumMember(Value = "CustomRole")]
        CustomRole
    }
    internal static class RoleDefinitionTypeEnumExtension
    {
        internal static string ToSerializedValue(this RoleDefinitionType? value)
        {
            return value == null ? null : ((RoleDefinitionType)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this RoleDefinitionType value)
        {
            switch( value )
            {
                case RoleDefinitionType.BuiltInRole:
                    return "BuiltInRole";
                case RoleDefinitionType.CustomRole:
                    return "CustomRole";
            }
            return null;
        }
        internal static RoleDefinitionType? ParseRoleDefinitionType(this string value)
        {
            switch( value )
            {
                case "BuiltInRole":
                    return RoleDefinitionType.BuiltInRole;
                case "CustomRole":
                    return RoleDefinitionType.CustomRole;
            }
            return null;
        }
    }
}