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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstancesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private string nextToken;

		private List<DescribeDBInstances_DBInstance> items;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<DescribeDBInstances_DBInstance> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeDBInstances_DBInstance
		{

			private string vpcId;

			private string dedicatedHostIdForLog;

			private string createTime;

			private string payType;

			private string dedicatedHostNameForLog;

			private bool? mutriORsignle;

			private string dedicatedHostGroupName;

			private string engineVersion;

			private string dedicatedHostGroupId;

			private string vpcName;

			private string dedicatedHostZoneIdForMaster;

			private int? insId;

			private string connectionString;

			private string instanceNetworkType;

			private string masterInstanceId;

			private string autoUpgradeMinorVersion;

			private string expireTime;

			private string destroyTime;

			private string guardDBInstanceId;

			private string dedicatedHostNameForMaster;

			private string zoneId;

			private int? tipsLevel;

			private string dBInstanceId;

			private string dedicatedHostIdForMaster;

			private string replicateId;

			private string tempDBInstanceId;

			private string dBInstanceStorageType;

			private string connectionMode;

			private string lockMode;

			private string generalGroupName;

			private string vpcCloudInstanceId;

			private string dedicatedHostZoneIdForSlave;

			private string tips;

			private string dedicatedHostZoneIdForLog;

			private string dedicatedHostNameForSlave;

			private string dBInstanceDescription;

			private string dBInstanceNetType;

			private string dBInstanceType;

			private string lockReason;

			private string dBInstanceStatus;

			private string regionId;

			private string vSwitchId;

			private string dedicatedHostIdForSlave;

			private string resourceGroupId;

			private string category;

			private string engine;

			private string dBInstanceClass;

			private int? switchWeight;

			private List<DescribeDBInstances_ReadOnlyDBInstanceId> readOnlyDBInstanceIds;

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string DedicatedHostIdForLog
			{
				get
				{
					return dedicatedHostIdForLog;
				}
				set	
				{
					dedicatedHostIdForLog = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public string DedicatedHostNameForLog
			{
				get
				{
					return dedicatedHostNameForLog;
				}
				set	
				{
					dedicatedHostNameForLog = value;
				}
			}

			public bool? MutriORsignle
			{
				get
				{
					return mutriORsignle;
				}
				set	
				{
					mutriORsignle = value;
				}
			}

			public string DedicatedHostGroupName
			{
				get
				{
					return dedicatedHostGroupName;
				}
				set	
				{
					dedicatedHostGroupName = value;
				}
			}

			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			public string DedicatedHostGroupId
			{
				get
				{
					return dedicatedHostGroupId;
				}
				set	
				{
					dedicatedHostGroupId = value;
				}
			}

			public string VpcName
			{
				get
				{
					return vpcName;
				}
				set	
				{
					vpcName = value;
				}
			}

			public string DedicatedHostZoneIdForMaster
			{
				get
				{
					return dedicatedHostZoneIdForMaster;
				}
				set	
				{
					dedicatedHostZoneIdForMaster = value;
				}
			}

			public int? InsId
			{
				get
				{
					return insId;
				}
				set	
				{
					insId = value;
				}
			}

			public string ConnectionString
			{
				get
				{
					return connectionString;
				}
				set	
				{
					connectionString = value;
				}
			}

			public string InstanceNetworkType
			{
				get
				{
					return instanceNetworkType;
				}
				set	
				{
					instanceNetworkType = value;
				}
			}

			public string MasterInstanceId
			{
				get
				{
					return masterInstanceId;
				}
				set	
				{
					masterInstanceId = value;
				}
			}

			public string AutoUpgradeMinorVersion
			{
				get
				{
					return autoUpgradeMinorVersion;
				}
				set	
				{
					autoUpgradeMinorVersion = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public string DestroyTime
			{
				get
				{
					return destroyTime;
				}
				set	
				{
					destroyTime = value;
				}
			}

			public string GuardDBInstanceId
			{
				get
				{
					return guardDBInstanceId;
				}
				set	
				{
					guardDBInstanceId = value;
				}
			}

			public string DedicatedHostNameForMaster
			{
				get
				{
					return dedicatedHostNameForMaster;
				}
				set	
				{
					dedicatedHostNameForMaster = value;
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
				}
			}

			public int? TipsLevel
			{
				get
				{
					return tipsLevel;
				}
				set	
				{
					tipsLevel = value;
				}
			}

			public string DBInstanceId
			{
				get
				{
					return dBInstanceId;
				}
				set	
				{
					dBInstanceId = value;
				}
			}

			public string DedicatedHostIdForMaster
			{
				get
				{
					return dedicatedHostIdForMaster;
				}
				set	
				{
					dedicatedHostIdForMaster = value;
				}
			}

			public string ReplicateId
			{
				get
				{
					return replicateId;
				}
				set	
				{
					replicateId = value;
				}
			}

			public string TempDBInstanceId
			{
				get
				{
					return tempDBInstanceId;
				}
				set	
				{
					tempDBInstanceId = value;
				}
			}

			public string DBInstanceStorageType
			{
				get
				{
					return dBInstanceStorageType;
				}
				set	
				{
					dBInstanceStorageType = value;
				}
			}

			public string ConnectionMode
			{
				get
				{
					return connectionMode;
				}
				set	
				{
					connectionMode = value;
				}
			}

			public string LockMode
			{
				get
				{
					return lockMode;
				}
				set	
				{
					lockMode = value;
				}
			}

			public string GeneralGroupName
			{
				get
				{
					return generalGroupName;
				}
				set	
				{
					generalGroupName = value;
				}
			}

			public string VpcCloudInstanceId
			{
				get
				{
					return vpcCloudInstanceId;
				}
				set	
				{
					vpcCloudInstanceId = value;
				}
			}

			public string DedicatedHostZoneIdForSlave
			{
				get
				{
					return dedicatedHostZoneIdForSlave;
				}
				set	
				{
					dedicatedHostZoneIdForSlave = value;
				}
			}

			public string Tips
			{
				get
				{
					return tips;
				}
				set	
				{
					tips = value;
				}
			}

			public string DedicatedHostZoneIdForLog
			{
				get
				{
					return dedicatedHostZoneIdForLog;
				}
				set	
				{
					dedicatedHostZoneIdForLog = value;
				}
			}

			public string DedicatedHostNameForSlave
			{
				get
				{
					return dedicatedHostNameForSlave;
				}
				set	
				{
					dedicatedHostNameForSlave = value;
				}
			}

			public string DBInstanceDescription
			{
				get
				{
					return dBInstanceDescription;
				}
				set	
				{
					dBInstanceDescription = value;
				}
			}

			public string DBInstanceNetType
			{
				get
				{
					return dBInstanceNetType;
				}
				set	
				{
					dBInstanceNetType = value;
				}
			}

			public string DBInstanceType
			{
				get
				{
					return dBInstanceType;
				}
				set	
				{
					dBInstanceType = value;
				}
			}

			public string LockReason
			{
				get
				{
					return lockReason;
				}
				set	
				{
					lockReason = value;
				}
			}

			public string DBInstanceStatus
			{
				get
				{
					return dBInstanceStatus;
				}
				set	
				{
					dBInstanceStatus = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
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
				}
			}

			public string DedicatedHostIdForSlave
			{
				get
				{
					return dedicatedHostIdForSlave;
				}
				set	
				{
					dedicatedHostIdForSlave = value;
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

			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			public string DBInstanceClass
			{
				get
				{
					return dBInstanceClass;
				}
				set	
				{
					dBInstanceClass = value;
				}
			}

			public int? SwitchWeight
			{
				get
				{
					return switchWeight;
				}
				set	
				{
					switchWeight = value;
				}
			}

			public List<DescribeDBInstances_ReadOnlyDBInstanceId> ReadOnlyDBInstanceIds
			{
				get
				{
					return readOnlyDBInstanceIds;
				}
				set	
				{
					readOnlyDBInstanceIds = value;
				}
			}

			public class DescribeDBInstances_ReadOnlyDBInstanceId
			{

				private string dBInstanceId;

				public string DBInstanceId
				{
					get
					{
						return dBInstanceId;
					}
					set	
					{
						dBInstanceId = value;
					}
				}
			}
		}
	}
}
