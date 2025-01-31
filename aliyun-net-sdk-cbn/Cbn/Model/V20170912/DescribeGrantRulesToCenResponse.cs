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
	public class DescribeGrantRulesToCenResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeGrantRulesToCen_GrantRule> grantRules;

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

		public List<DescribeGrantRulesToCen_GrantRule> GrantRules
		{
			get
			{
				return grantRules;
			}
			set	
			{
				grantRules = value;
			}
		}

		public class DescribeGrantRulesToCen_GrantRule
		{

			private string childInstanceType;

			private string childInstanceRegionId;

			private long? childInstanceOwnerId;

			private string childInstanceId;

			private string cenId;

			private string orderType;

			public string ChildInstanceType
			{
				get
				{
					return childInstanceType;
				}
				set	
				{
					childInstanceType = value;
				}
			}

			public string ChildInstanceRegionId
			{
				get
				{
					return childInstanceRegionId;
				}
				set	
				{
					childInstanceRegionId = value;
				}
			}

			public long? ChildInstanceOwnerId
			{
				get
				{
					return childInstanceOwnerId;
				}
				set	
				{
					childInstanceOwnerId = value;
				}
			}

			public string ChildInstanceId
			{
				get
				{
					return childInstanceId;
				}
				set	
				{
					childInstanceId = value;
				}
			}

			public string CenId
			{
				get
				{
					return cenId;
				}
				set	
				{
					cenId = value;
				}
			}

			public string OrderType
			{
				get
				{
					return orderType;
				}
				set	
				{
					orderType = value;
				}
			}
		}
	}
}
