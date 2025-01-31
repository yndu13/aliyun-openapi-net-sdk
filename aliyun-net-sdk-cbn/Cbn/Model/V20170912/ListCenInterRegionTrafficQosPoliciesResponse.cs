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

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class ListCenInterRegionTrafficQosPoliciesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? totalCount;

		private int? maxResults;

		private List<ListCenInterRegionTrafficQosPolicies_TrafficQosPolicy> trafficQosPolicies;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public List<ListCenInterRegionTrafficQosPolicies_TrafficQosPolicy> TrafficQosPolicies
		{
			get
			{
				return trafficQosPolicies;
			}
			set	
			{
				trafficQosPolicies = value;
			}
		}

		public class ListCenInterRegionTrafficQosPolicies_TrafficQosPolicy
		{

			private string trafficQosPolicyName;

			private string trafficQosPolicyStatus;

			private string trafficQosPolicyId;

			private string trafficQosPolicyDescription;

			private List<ListCenInterRegionTrafficQosPolicies_TrafficQosQueue> trafficQosQueues;

			public string TrafficQosPolicyName
			{
				get
				{
					return trafficQosPolicyName;
				}
				set	
				{
					trafficQosPolicyName = value;
				}
			}

			public string TrafficQosPolicyStatus
			{
				get
				{
					return trafficQosPolicyStatus;
				}
				set	
				{
					trafficQosPolicyStatus = value;
				}
			}

			public string TrafficQosPolicyId
			{
				get
				{
					return trafficQosPolicyId;
				}
				set	
				{
					trafficQosPolicyId = value;
				}
			}

			public string TrafficQosPolicyDescription
			{
				get
				{
					return trafficQosPolicyDescription;
				}
				set	
				{
					trafficQosPolicyDescription = value;
				}
			}

			public List<ListCenInterRegionTrafficQosPolicies_TrafficQosQueue> TrafficQosQueues
			{
				get
				{
					return trafficQosQueues;
				}
				set	
				{
					trafficQosQueues = value;
				}
			}

			public class ListCenInterRegionTrafficQosPolicies_TrafficQosQueue
			{

				private string qosQueueName;

				private int? remainBandwidthPercent;

				private string qosQueueId;

				private string qosQueueDescription;

				private List<string> dscps;

				public string QosQueueName
				{
					get
					{
						return qosQueueName;
					}
					set	
					{
						qosQueueName = value;
					}
				}

				public int? RemainBandwidthPercent
				{
					get
					{
						return remainBandwidthPercent;
					}
					set	
					{
						remainBandwidthPercent = value;
					}
				}

				public string QosQueueId
				{
					get
					{
						return qosQueueId;
					}
					set	
					{
						qosQueueId = value;
					}
				}

				public string QosQueueDescription
				{
					get
					{
						return qosQueueDescription;
					}
					set	
					{
						qosQueueDescription = value;
					}
				}

				public List<string> Dscps
				{
					get
					{
						return dscps;
					}
					set	
					{
						dscps = value;
					}
				}
			}
		}
	}
}
