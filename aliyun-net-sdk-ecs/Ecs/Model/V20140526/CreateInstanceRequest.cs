/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class CreateInstanceRequest : RpcAcsRequest<CreateInstanceResponse>
    {
        public CreateInstanceRequest()
            : base("Ecs", "2014-05-26", "CreateInstance", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string hpcClusterId;

		private int? httpPutResponseHopLimit;

		private string securityEnhancementStrategy;

		private string keyPairName;

		private float? spotPriceLimit;

		private bool? deletionProtection;

		private string resourceGroupId;

		private string privatePoolOptionsMatchCriteria;

		private string hostName;

		private string password;

		private SystemDisk systemDisk_;

		private int? deploymentSetGroupNo;

		private int? storageSetPartitionNumber;

		private List<string> tags = new List<string>(){ };

		private string privatePoolOptionsId;

		private int? autoRenewPeriod;

		private string nodeControllerId;

		private int? period;

		private bool? dryRun;

		private long? ownerId;

		private string vSwitchId;

		private string privateIpAddress;

		private string spotStrategy;

		private string periodUnit;

		private string instanceName;

		private bool? autoRenew;

		private string internetChargeType;

		private string zoneId;

		private int? internetMaxBandwidthIn;

		private bool? useAdditionalService;

		private string affinity;

		private string imageId;

		private string clientToken;

		private string vlanId;

		private string spotInterruptionBehavior;

		private string ioOptimized;

		private string securityGroupId;

		private int? internetMaxBandwidthOut;

		private bool? hibernationOptionsConfigured;

		private string description;

		private string systemDiskCategory;

		private string systemDiskPerformanceLevel;

		private string userData;

		private bool? passwordInherit;

		private string httpEndpoint;

		private string instanceType;

		private List<string> arns = new List<string>(){ };

		private string instanceChargeType;

		private string deploymentSetId;

		private string innerIpAddress;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string tenancy;

		private string systemDiskDiskName;

		private string ramRoleName;

		private string dedicatedHostId;

		private string clusterId;

		private string creditSpecification;

		private int? spotDuration;

		private List<string> dataDisks = new List<string>(){ };

		private string storageSetId;

		private int? systemDiskSize;

		private string imageFamily;

		private string httpTokens;

		private string systemDiskDescription;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string HpcClusterId
		{
			get
			{
				return hpcClusterId;
			}
			set	
			{
				hpcClusterId = value;
				DictionaryUtil.Add(QueryParameters, "HpcClusterId", value);
			}
		}

		public int? HttpPutResponseHopLimit
		{
			get
			{
				return httpPutResponseHopLimit;
			}
			set	
			{
				httpPutResponseHopLimit = value;
				DictionaryUtil.Add(QueryParameters, "HttpPutResponseHopLimit", value.ToString());
			}
		}

		public string SecurityEnhancementStrategy
		{
			get
			{
				return securityEnhancementStrategy;
			}
			set	
			{
				securityEnhancementStrategy = value;
				DictionaryUtil.Add(QueryParameters, "SecurityEnhancementStrategy", value);
			}
		}

		public string KeyPairName
		{
			get
			{
				return keyPairName;
			}
			set	
			{
				keyPairName = value;
				DictionaryUtil.Add(QueryParameters, "KeyPairName", value);
			}
		}

		public float? SpotPriceLimit
		{
			get
			{
				return spotPriceLimit;
			}
			set	
			{
				spotPriceLimit = value;
				DictionaryUtil.Add(QueryParameters, "SpotPriceLimit", value.ToString());
			}
		}

		public bool? DeletionProtection
		{
			get
			{
				return deletionProtection;
			}
			set	
			{
				deletionProtection = value;
				DictionaryUtil.Add(QueryParameters, "DeletionProtection", value.ToString());
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string PrivatePoolOptionsMatchCriteria
		{
			get
			{
				return privatePoolOptionsMatchCriteria;
			}
			set	
			{
				privatePoolOptionsMatchCriteria = value;
				DictionaryUtil.Add(QueryParameters, "PrivatePoolOptions.MatchCriteria", value);
			}
		}

		public string HostName
		{
			get
			{
				return hostName;
			}
			set	
			{
				hostName = value;
				DictionaryUtil.Add(QueryParameters, "HostName", value);
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public SystemDisk SystemDisk_
		{
			get
			{
				return systemDisk_;
			}

			set
			{
				systemDisk_ = value;
				if(SystemDisk_ != null)
				{

					DictionaryUtil.Add(QueryParameters,"SystemDisk.StorageClusterId", SystemDisk_.StorageClusterId);
				}
			}
		}

		public int? DeploymentSetGroupNo
		{
			get
			{
				return deploymentSetGroupNo;
			}
			set	
			{
				deploymentSetGroupNo = value;
				DictionaryUtil.Add(QueryParameters, "DeploymentSetGroupNo", value.ToString());
			}
		}

		public int? StorageSetPartitionNumber
		{
			get
			{
				return storageSetPartitionNumber;
			}
			set	
			{
				storageSetPartitionNumber = value;
				DictionaryUtil.Add(QueryParameters, "StorageSetPartitionNumber", value.ToString());
			}
		}

		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
			}
		}

		public string PrivatePoolOptionsId
		{
			get
			{
				return privatePoolOptionsId;
			}
			set	
			{
				privatePoolOptionsId = value;
				DictionaryUtil.Add(QueryParameters, "PrivatePoolOptions.Id", value);
			}
		}

		public int? AutoRenewPeriod
		{
			get
			{
				return autoRenewPeriod;
			}
			set	
			{
				autoRenewPeriod = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenewPeriod", value.ToString());
			}
		}

		public string NodeControllerId
		{
			get
			{
				return nodeControllerId;
			}
			set	
			{
				nodeControllerId = value;
				DictionaryUtil.Add(QueryParameters, "NodeControllerId", value);
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string VSwitchId
		{
			get
			{
				return vSwitchId;
			}
			set	
			{
				vSwitchId = value;
				DictionaryUtil.Add(QueryParameters, "VSwitchId", value);
			}
		}

		public string PrivateIpAddress
		{
			get
			{
				return privateIpAddress;
			}
			set	
			{
				privateIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "PrivateIpAddress", value);
			}
		}

		public string SpotStrategy
		{
			get
			{
				return spotStrategy;
			}
			set	
			{
				spotStrategy = value;
				DictionaryUtil.Add(QueryParameters, "SpotStrategy", value);
			}
		}

		public string PeriodUnit
		{
			get
			{
				return periodUnit;
			}
			set	
			{
				periodUnit = value;
				DictionaryUtil.Add(QueryParameters, "PeriodUnit", value);
			}
		}

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
			}
		}

		public bool? AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value.ToString());
			}
		}

		public string InternetChargeType
		{
			get
			{
				return internetChargeType;
			}
			set	
			{
				internetChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InternetChargeType", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public int? InternetMaxBandwidthIn
		{
			get
			{
				return internetMaxBandwidthIn;
			}
			set	
			{
				internetMaxBandwidthIn = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthIn", value.ToString());
			}
		}

		public bool? UseAdditionalService
		{
			get
			{
				return useAdditionalService;
			}
			set	
			{
				useAdditionalService = value;
				DictionaryUtil.Add(QueryParameters, "UseAdditionalService", value.ToString());
			}
		}

		public string Affinity
		{
			get
			{
				return affinity;
			}
			set	
			{
				affinity = value;
				DictionaryUtil.Add(QueryParameters, "Affinity", value);
			}
		}

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string VlanId
		{
			get
			{
				return vlanId;
			}
			set	
			{
				vlanId = value;
				DictionaryUtil.Add(QueryParameters, "VlanId", value);
			}
		}

		public string SpotInterruptionBehavior
		{
			get
			{
				return spotInterruptionBehavior;
			}
			set	
			{
				spotInterruptionBehavior = value;
				DictionaryUtil.Add(QueryParameters, "SpotInterruptionBehavior", value);
			}
		}

		public string IoOptimized
		{
			get
			{
				return ioOptimized;
			}
			set	
			{
				ioOptimized = value;
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value);
			}
		}

		public string SecurityGroupId
		{
			get
			{
				return securityGroupId;
			}
			set	
			{
				securityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SecurityGroupId", value);
			}
		}

		public int? InternetMaxBandwidthOut
		{
			get
			{
				return internetMaxBandwidthOut;
			}
			set	
			{
				internetMaxBandwidthOut = value;
				DictionaryUtil.Add(QueryParameters, "InternetMaxBandwidthOut", value.ToString());
			}
		}

		public bool? HibernationOptionsConfigured
		{
			get
			{
				return hibernationOptionsConfigured;
			}
			set	
			{
				hibernationOptionsConfigured = value;
				DictionaryUtil.Add(QueryParameters, "HibernationOptions.Configured", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string SystemDiskCategory
		{
			get
			{
				return systemDiskCategory;
			}
			set	
			{
				systemDiskCategory = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Category", value);
			}
		}

		public string SystemDiskPerformanceLevel
		{
			get
			{
				return systemDiskPerformanceLevel;
			}
			set	
			{
				systemDiskPerformanceLevel = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.PerformanceLevel", value);
			}
		}

		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		public bool? PasswordInherit
		{
			get
			{
				return passwordInherit;
			}
			set	
			{
				passwordInherit = value;
				DictionaryUtil.Add(QueryParameters, "PasswordInherit", value.ToString());
			}
		}

		public string HttpEndpoint
		{
			get
			{
				return httpEndpoint;
			}
			set	
			{
				httpEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "HttpEndpoint", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public List<string> Arns
		{
			get
			{
				return arns;
			}

			set
			{
				arns = value;
				if(arns != null)
				{
					for (int depth1 = 0; depth1 < arns.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Arn." + (depth1 + 1), arns[depth1]);
						DictionaryUtil.Add(QueryParameters,"Arn." + (depth1 + 1), arns[depth1]);
						DictionaryUtil.Add(QueryParameters,"Arn." + (depth1 + 1), arns[depth1]);
					}
				}
			}
		}

		public string InstanceChargeType
		{
			get
			{
				return instanceChargeType;
			}
			set	
			{
				instanceChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceChargeType", value);
			}
		}

		public string DeploymentSetId
		{
			get
			{
				return deploymentSetId;
			}
			set	
			{
				deploymentSetId = value;
				DictionaryUtil.Add(QueryParameters, "DeploymentSetId", value);
			}
		}

		public string InnerIpAddress
		{
			get
			{
				return innerIpAddress;
			}
			set	
			{
				innerIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "InnerIpAddress", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public string Tenancy
		{
			get
			{
				return tenancy;
			}
			set	
			{
				tenancy = value;
				DictionaryUtil.Add(QueryParameters, "Tenancy", value);
			}
		}

		public string SystemDiskDiskName
		{
			get
			{
				return systemDiskDiskName;
			}
			set	
			{
				systemDiskDiskName = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.DiskName", value);
			}
		}

		public string RamRoleName
		{
			get
			{
				return ramRoleName;
			}
			set	
			{
				ramRoleName = value;
				DictionaryUtil.Add(QueryParameters, "RamRoleName", value);
			}
		}

		public string DedicatedHostId
		{
			get
			{
				return dedicatedHostId;
			}
			set	
			{
				dedicatedHostId = value;
				DictionaryUtil.Add(QueryParameters, "DedicatedHostId", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string CreditSpecification
		{
			get
			{
				return creditSpecification;
			}
			set	
			{
				creditSpecification = value;
				DictionaryUtil.Add(QueryParameters, "CreditSpecification", value);
			}
		}

		public int? SpotDuration
		{
			get
			{
				return spotDuration;
			}
			set	
			{
				spotDuration = value;
				DictionaryUtil.Add(QueryParameters, "SpotDuration", value.ToString());
			}
		}

		public List<string> DataDisks
		{
			get
			{
				return dataDisks;
			}

			set
			{
				dataDisks = value;
				if(dataDisks != null)
				{
					for (int depth1 = 0; depth1 < dataDisks.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
						DictionaryUtil.Add(QueryParameters,"DataDisk." + (depth1 + 1), dataDisks[depth1]);
					}
				}
			}
		}

		public string StorageSetId
		{
			get
			{
				return storageSetId;
			}
			set	
			{
				storageSetId = value;
				DictionaryUtil.Add(QueryParameters, "StorageSetId", value);
			}
		}

		public int? SystemDiskSize
		{
			get
			{
				return systemDiskSize;
			}
			set	
			{
				systemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Size", value.ToString());
			}
		}

		public string ImageFamily
		{
			get
			{
				return imageFamily;
			}
			set	
			{
				imageFamily = value;
				DictionaryUtil.Add(QueryParameters, "ImageFamily", value);
			}
		}

		public string HttpTokens
		{
			get
			{
				return httpTokens;
			}
			set	
			{
				httpTokens = value;
				DictionaryUtil.Add(QueryParameters, "HttpTokens", value);
			}
		}

		public string SystemDiskDescription
		{
			get
			{
				return systemDiskDescription;
			}
			set	
			{
				systemDiskDescription = value;
				DictionaryUtil.Add(QueryParameters, "SystemDisk.Description", value);
			}
		}

		public class SystemDisk
		{

			private string storageClusterId;

			public string StorageClusterId
			{
				get
				{
					return storageClusterId;
				}
				set	
				{
					storageClusterId = value;
				}
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

		public class Arn
		{

			private string rolearn;

			private string roleType;

			private long? assumeRoleFor;

			public string Rolearn
			{
				get
				{
					return rolearn;
				}
				set	
				{
					rolearn = value;
				}
			}

			public string RoleType
			{
				get
				{
					return roleType;
				}
				set	
				{
					roleType = value;
				}
			}

			public long? AssumeRoleFor
			{
				get
				{
					return assumeRoleFor;
				}
				set	
				{
					assumeRoleFor = value;
				}
			}
		}

		public class DataDisk
		{

			private string diskName;

			private string snapshotId;

			private int? size;

			private bool? encrypted;

			private string performanceLevel;

			private string encryptAlgorithm;

			private string description;

			private string storageClusterId;

			private string category;

			private string kMSKeyId;

			private string device;

			private bool? deleteWithInstance;

			public string DiskName
			{
				get
				{
					return diskName;
				}
				set	
				{
					diskName = value;
				}
			}

			public string SnapshotId
			{
				get
				{
					return snapshotId;
				}
				set	
				{
					snapshotId = value;
				}
			}

			public int? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public bool? Encrypted
			{
				get
				{
					return encrypted;
				}
				set	
				{
					encrypted = value;
				}
			}

			public string PerformanceLevel
			{
				get
				{
					return performanceLevel;
				}
				set	
				{
					performanceLevel = value;
				}
			}

			public string EncryptAlgorithm
			{
				get
				{
					return encryptAlgorithm;
				}
				set	
				{
					encryptAlgorithm = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string StorageClusterId
			{
				get
				{
					return storageClusterId;
				}
				set	
				{
					storageClusterId = value;
				}
			}

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public string KMSKeyId
			{
				get
				{
					return kMSKeyId;
				}
				set	
				{
					kMSKeyId = value;
				}
			}

			public string Device
			{
				get
				{
					return device;
				}
				set	
				{
					device = value;
				}
			}

			public bool? DeleteWithInstance
			{
				get
				{
					return deleteWithInstance;
				}
				set	
				{
					deleteWithInstance = value;
				}
			}
		}

        public override CreateInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
