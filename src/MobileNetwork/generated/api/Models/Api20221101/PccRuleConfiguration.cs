// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>Data flow policy rule configuration</summary>
    public partial class PccRuleConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfigurationInternal
    {

        /// <summary>Downlink bit rate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string GuaranteedBitRateDownlink { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleQosPolicyInternal)RuleQosPolicy).GuaranteedBitRateDownlink; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleQosPolicyInternal)RuleQosPolicy).GuaranteedBitRateDownlink = value ?? null; }

        /// <summary>Uplink bit rate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string GuaranteedBitRateUplink { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleQosPolicyInternal)RuleQosPolicy).GuaranteedBitRateUplink; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleQosPolicyInternal)RuleQosPolicy).GuaranteedBitRateUplink = value ?? null; }

        /// <summary>Internal Acessors for RuleQoPolicyGuaranteedBitRate</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IAmbr Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfigurationInternal.RuleQoPolicyGuaranteedBitRate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleQosPolicyInternal)RuleQosPolicy).GuaranteedBitRate; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleQosPolicyInternal)RuleQosPolicy).GuaranteedBitRate = value; }

        /// <summary>Internal Acessors for RuleQoPolicyMaximumBitRate</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IAmbr Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfigurationInternal.RuleQoPolicyMaximumBitRate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).MaximumBitRate; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).MaximumBitRate = value; }

        /// <summary>Internal Acessors for RuleQosPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleQosPolicy Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleConfigurationInternal.RuleQosPolicy { get => (this._ruleQosPolicy = this._ruleQosPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.PccRuleQosPolicy()); set { {_ruleQosPolicy = value;} } }

        /// <summary>Backing field for <see cref="RuleName" /> property.</summary>
        private string _ruleName;

        /// <summary>
        /// The name of the rule. This must be unique within the parent service. You must not use any of the following reserved strings
        /// - 'default', 'requested' or 'service'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public string RuleName { get => this._ruleName; set => this._ruleName = value; }

        /// <summary>Backing field for <see cref="RulePrecedence" /> property.</summary>
        private int _rulePrecedence;

        /// <summary>
        /// A precedence value that is used to decide between data flow policy rules when identifying the QoS values to use for a
        /// particular SIM. A lower value means a higher priority. This value should be unique among all data flow policy rules configured
        /// in the mobile network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public int RulePrecedence { get => this._rulePrecedence; set => this._rulePrecedence = value; }

        /// <summary>
        /// QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority,
        /// if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority.
        /// If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full
        /// description of the ARP parameters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public int? RuleQoPolicyAllocationAndRetentionPriorityLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).AllocationAndRetentionPriorityLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).AllocationAndRetentionPriorityLevel = value ?? default(int); }

        /// <summary>
        /// QoS Flow 5G QoS Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. This
        /// must not be a standardized 5QI value corresponding to a GBR (guaranteed bit rate) QoS Flow. The illegal GBR 5QI values
        /// are: 1, 2, 3, 4, 65, 66, 67, 71, 72, 73, 74, 75, 76, 82, 83, 84, and 85. See 3GPP TS23.501 section 5.7.2.1 for a full
        /// description of the 5QI parameter, and table 5.7.4-1 for the definition of which are the GBR 5QI values.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public int? RuleQoPolicyFiveQi { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).FiveQi; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).FiveQi = value ?? default(int); }

        /// <summary>Downlink bit rate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string RuleQoPolicyMaximumBitRateDownlink { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).MaximumBitRateDownlink; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).MaximumBitRateDownlink = value ?? null; }

        /// <summary>Uplink bit rate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string RuleQoPolicyMaximumBitRateUplink { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).MaximumBitRateUplink; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).MaximumBitRateUplink = value ?? null; }

        /// <summary>
        /// QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow
        /// with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability? RuleQoPolicyPreemptionCapability { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).PreemptionCapability; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).PreemptionCapability = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability)""); }

        /// <summary>
        /// QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by
        /// a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability? RuleQoPolicyPreemptionVulnerability { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).PreemptionVulnerability; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IQosPolicyInternal)RuleQosPolicy).PreemptionVulnerability = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability)""); }

        /// <summary>Backing field for <see cref="RuleQosPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleQosPolicy _ruleQosPolicy;

        /// <summary>
        /// The QoS policy to use for packets matching this rule. If this field is null then the parent service will define the QoS
        /// settings.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleQosPolicy RuleQosPolicy { get => (this._ruleQosPolicy = this._ruleQosPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.PccRuleQosPolicy()); set => this._ruleQosPolicy = value; }

        /// <summary>Backing field for <see cref="ServiceDataFlowTemplate" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServiceDataFlowTemplate[] _serviceDataFlowTemplate;

        /// <summary>The set of data flow templates to use for this data flow policy rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServiceDataFlowTemplate[] ServiceDataFlowTemplate { get => this._serviceDataFlowTemplate; set => this._serviceDataFlowTemplate = value; }

        /// <summary>Backing field for <see cref="TrafficControl" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.TrafficControlPermission? _trafficControl;

        /// <summary>Determines whether flows that match this data flow policy rule are permitted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.TrafficControlPermission? TrafficControl { get => this._trafficControl; set => this._trafficControl = value; }

        /// <summary>Creates an new <see cref="PccRuleConfiguration" /> instance.</summary>
        public PccRuleConfiguration()
        {

        }
    }
    /// Data flow policy rule configuration
    public partial interface IPccRuleConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable
    {
        /// <summary>Downlink bit rate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Downlink bit rate.",
        SerializedName = @"downlink",
        PossibleTypes = new [] { typeof(string) })]
        string GuaranteedBitRateDownlink { get; set; }
        /// <summary>Uplink bit rate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Uplink bit rate.",
        SerializedName = @"uplink",
        PossibleTypes = new [] { typeof(string) })]
        string GuaranteedBitRateUplink { get; set; }
        /// <summary>
        /// The name of the rule. This must be unique within the parent service. You must not use any of the following reserved strings
        /// - 'default', 'requested' or 'service'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the rule. This must be unique within the parent service. You must not use any of the following reserved strings - 'default', 'requested' or 'service'.",
        SerializedName = @"ruleName",
        PossibleTypes = new [] { typeof(string) })]
        string RuleName { get; set; }
        /// <summary>
        /// A precedence value that is used to decide between data flow policy rules when identifying the QoS values to use for a
        /// particular SIM. A lower value means a higher priority. This value should be unique among all data flow policy rules configured
        /// in the mobile network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A precedence value that is used to decide between data flow policy rules when identifying the QoS values to use for a particular SIM. A lower value means a higher priority. This value should be unique among all data flow policy rules configured in the mobile network.",
        SerializedName = @"rulePrecedence",
        PossibleTypes = new [] { typeof(int) })]
        int RulePrecedence { get; set; }
        /// <summary>
        /// QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority,
        /// if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority.
        /// If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full
        /// description of the ARP parameters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority, if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority. If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.",
        SerializedName = @"allocationAndRetentionPriorityLevel",
        PossibleTypes = new [] { typeof(int) })]
        int? RuleQoPolicyAllocationAndRetentionPriorityLevel { get; set; }
        /// <summary>
        /// QoS Flow 5G QoS Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. This
        /// must not be a standardized 5QI value corresponding to a GBR (guaranteed bit rate) QoS Flow. The illegal GBR 5QI values
        /// are: 1, 2, 3, 4, 65, 66, 67, 71, 72, 73, 74, 75, 76, 82, 83, 84, and 85. See 3GPP TS23.501 section 5.7.2.1 for a full
        /// description of the 5QI parameter, and table 5.7.4-1 for the definition of which are the GBR 5QI values.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"QoS Flow 5G QoS Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. This must not be a standardized 5QI value corresponding to a GBR (guaranteed bit rate) QoS Flow. The illegal GBR 5QI values are: 1, 2, 3, 4, 65, 66, 67, 71, 72, 73, 74, 75, 76, 82, 83, 84, and 85. See 3GPP TS23.501 section 5.7.2.1 for a full description of the 5QI parameter, and table 5.7.4-1 for the definition of which are the GBR 5QI values.",
        SerializedName = @"5qi",
        PossibleTypes = new [] { typeof(int) })]
        int? RuleQoPolicyFiveQi { get; set; }
        /// <summary>Downlink bit rate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Downlink bit rate.",
        SerializedName = @"downlink",
        PossibleTypes = new [] { typeof(string) })]
        string RuleQoPolicyMaximumBitRateDownlink { get; set; }
        /// <summary>Uplink bit rate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Uplink bit rate.",
        SerializedName = @"uplink",
        PossibleTypes = new [] { typeof(string) })]
        string RuleQoPolicyMaximumBitRateUplink { get; set; }
        /// <summary>
        /// QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow
        /// with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.",
        SerializedName = @"preemptionCapability",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability? RuleQoPolicyPreemptionCapability { get; set; }
        /// <summary>
        /// QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by
        /// a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.",
        SerializedName = @"preemptionVulnerability",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability? RuleQoPolicyPreemptionVulnerability { get; set; }
        /// <summary>The set of data flow templates to use for this data flow policy rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The set of data flow templates to use for this data flow policy rule.",
        SerializedName = @"serviceDataFlowTemplates",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServiceDataFlowTemplate) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServiceDataFlowTemplate[] ServiceDataFlowTemplate { get; set; }
        /// <summary>Determines whether flows that match this data flow policy rule are permitted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Determines whether flows that match this data flow policy rule are permitted.",
        SerializedName = @"trafficControl",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.TrafficControlPermission) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.TrafficControlPermission? TrafficControl { get; set; }

    }
    /// Data flow policy rule configuration
    internal partial interface IPccRuleConfigurationInternal

    {
        /// <summary>Downlink bit rate.</summary>
        string GuaranteedBitRateDownlink { get; set; }
        /// <summary>Uplink bit rate.</summary>
        string GuaranteedBitRateUplink { get; set; }
        /// <summary>
        /// The name of the rule. This must be unique within the parent service. You must not use any of the following reserved strings
        /// - 'default', 'requested' or 'service'.
        /// </summary>
        string RuleName { get; set; }
        /// <summary>
        /// A precedence value that is used to decide between data flow policy rules when identifying the QoS values to use for a
        /// particular SIM. A lower value means a higher priority. This value should be unique among all data flow policy rules configured
        /// in the mobile network.
        /// </summary>
        int RulePrecedence { get; set; }
        /// <summary>
        /// QoS Flow allocation and retention priority (ARP) level. Flows with higher priority preempt flows with lower priority,
        /// if the settings of `preemptionCapability` and `preemptionVulnerability` allow it. 1 is the highest level of priority.
        /// If this field is not specified then `5qi` is used to derive the ARP value. See 3GPP TS23.501 section 5.7.2.2 for a full
        /// description of the ARP parameters.
        /// </summary>
        int? RuleQoPolicyAllocationAndRetentionPriorityLevel { get; set; }
        /// <summary>
        /// QoS Flow 5G QoS Indicator value. The 5QI identifies a specific QoS forwarding treatment to be provided to a flow. This
        /// must not be a standardized 5QI value corresponding to a GBR (guaranteed bit rate) QoS Flow. The illegal GBR 5QI values
        /// are: 1, 2, 3, 4, 65, 66, 67, 71, 72, 73, 74, 75, 76, 82, 83, 84, and 85. See 3GPP TS23.501 section 5.7.2.1 for a full
        /// description of the 5QI parameter, and table 5.7.4-1 for the definition of which are the GBR 5QI values.
        /// </summary>
        int? RuleQoPolicyFiveQi { get; set; }
        /// <summary>
        /// The guaranteed bit rate (GBR) for all service data flows that use this data flow policy rule. This is an optional setting.
        /// If you do not provide a value, there will be no GBR set for the data flow policy rule that uses this QoS definition.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IAmbr RuleQoPolicyGuaranteedBitRate { get; set; }
        /// <summary>
        /// The maximum bit rate (MBR) for all service data flows that use this data flow policy rule or service.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IAmbr RuleQoPolicyMaximumBitRate { get; set; }
        /// <summary>Downlink bit rate.</summary>
        string RuleQoPolicyMaximumBitRateDownlink { get; set; }
        /// <summary>Uplink bit rate.</summary>
        string RuleQoPolicyMaximumBitRateUplink { get; set; }
        /// <summary>
        /// QoS Flow preemption capability. The preemption capability of a QoS Flow controls whether it can preempt another QoS Flow
        /// with a lower priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionCapability? RuleQoPolicyPreemptionCapability { get; set; }
        /// <summary>
        /// QoS Flow preemption vulnerability. The preemption vulnerability of a QoS Flow controls whether it can be preempted by
        /// a QoS Flow with a higher priority level. See 3GPP TS23.501 section 5.7.2.2 for a full description of the ARP parameters.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.PreemptionVulnerability? RuleQoPolicyPreemptionVulnerability { get; set; }
        /// <summary>
        /// The QoS policy to use for packets matching this rule. If this field is null then the parent service will define the QoS
        /// settings.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IPccRuleQosPolicy RuleQosPolicy { get; set; }
        /// <summary>The set of data flow templates to use for this data flow policy rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IServiceDataFlowTemplate[] ServiceDataFlowTemplate { get; set; }
        /// <summary>Determines whether flows that match this data flow policy rule are permitted.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Support.TrafficControlPermission? TrafficControl { get; set; }

    }
}