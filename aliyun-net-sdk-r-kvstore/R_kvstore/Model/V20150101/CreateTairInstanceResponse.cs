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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class CreateTairInstanceResponse : AcsResponse
	{

		private long? bandwidth;

		private string chargeType;

		private string config;

		private string connectionDomain;

		private long? connections;

		private string instanceId;

		private string instanceName;

		private string instanceStatus;

		private int? port;

		private long? qPS;

		private string regionId;

		private string requestId;

		private string taskId;

		private string zoneId;

		public long? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
			}
		}

		public string Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
			}
		}

		public string ConnectionDomain
		{
			get
			{
				return connectionDomain;
			}
			set	
			{
				connectionDomain = value;
			}
		}

		public long? Connections
		{
			get
			{
				return connections;
			}
			set	
			{
				connections = value;
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
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
			}
		}

		public string InstanceStatus
		{
			get
			{
				return instanceStatus;
			}
			set	
			{
				instanceStatus = value;
			}
		}

		public int? Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
			}
		}

		public long? QPS
		{
			get
			{
				return qPS;
			}
			set	
			{
				qPS = value;
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

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
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
	}
}
