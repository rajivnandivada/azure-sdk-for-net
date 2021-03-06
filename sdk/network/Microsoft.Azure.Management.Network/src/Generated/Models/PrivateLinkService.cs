// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Private link service resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PrivateLinkService : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateLinkService class.
        /// </summary>
        public PrivateLinkService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateLinkService class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="loadBalancerFrontendIPConfigurations">An array of
        /// references to the load balancer IP configurations.</param>
        /// <param name="ipConfigurations">An array of references to the
        /// private link service IP configuration.</param>
        /// <param name="networkInterfaces">Gets an array of references to the
        /// network interfaces created for this private link service.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// private link service. Possible values are: 'Updating', 'Succeeded',
        /// and 'Failed'.</param>
        /// <param name="privateEndpointConnections">An array of list about
        /// connections to the private endpoint.</param>
        /// <param name="visibility">The visibility list of the private link
        /// service.</param>
        /// <param name="autoApproval">The auto-approval list of the private
        /// link service.</param>
        /// <param name="fqdns">The list of Fqdn.</param>
        /// <param name="alias">The alias of the private link service.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public PrivateLinkService(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<FrontendIPConfiguration> loadBalancerFrontendIPConfigurations = default(IList<FrontendIPConfiguration>), IList<PrivateLinkServiceIpConfiguration> ipConfigurations = default(IList<PrivateLinkServiceIpConfiguration>), IList<NetworkInterface> networkInterfaces = default(IList<NetworkInterface>), string provisioningState = default(string), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>), PrivateLinkServicePropertiesVisibility visibility = default(PrivateLinkServicePropertiesVisibility), PrivateLinkServicePropertiesAutoApproval autoApproval = default(PrivateLinkServicePropertiesAutoApproval), IList<string> fqdns = default(IList<string>), string alias = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            LoadBalancerFrontendIPConfigurations = loadBalancerFrontendIPConfigurations;
            IpConfigurations = ipConfigurations;
            NetworkInterfaces = networkInterfaces;
            ProvisioningState = provisioningState;
            PrivateEndpointConnections = privateEndpointConnections;
            Visibility = visibility;
            AutoApproval = autoApproval;
            Fqdns = fqdns;
            Alias = alias;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an array of references to the load balancer IP
        /// configurations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancerFrontendIPConfigurations")]
        public IList<FrontendIPConfiguration> LoadBalancerFrontendIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets an array of references to the private link service IP
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<PrivateLinkServiceIpConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// Gets an array of references to the network interfaces created for
        /// this private link service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkInterfaces")]
        public IList<NetworkInterface> NetworkInterfaces { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the private link service. Possible
        /// values are: 'Updating', 'Succeeded', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets an array of list about connections to the private
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; set; }

        /// <summary>
        /// Gets or sets the visibility list of the private link service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.visibility")]
        public PrivateLinkServicePropertiesVisibility Visibility { get; set; }

        /// <summary>
        /// Gets or sets the auto-approval list of the private link service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoApproval")]
        public PrivateLinkServicePropertiesAutoApproval AutoApproval { get; set; }

        /// <summary>
        /// Gets or sets the list of Fqdn.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fqdns")]
        public IList<string> Fqdns { get; set; }

        /// <summary>
        /// Gets the alias of the private link service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alias")]
        public string Alias { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
