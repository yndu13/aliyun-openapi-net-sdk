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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class DescribeSavingsPlansUsageTotalResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private DescribeSavingsPlansUsageTotal_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public DescribeSavingsPlansUsageTotal_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeSavingsPlansUsageTotal_Data
		{

			private List<DescribeSavingsPlansUsageTotal_Item> periodCoverage;

			private DescribeSavingsPlansUsageTotal_TotalUsage totalUsage;

			public List<DescribeSavingsPlansUsageTotal_Item> PeriodCoverage
			{
				get
				{
					return periodCoverage;
				}
				set	
				{
					periodCoverage = value;
				}
			}

			public DescribeSavingsPlansUsageTotal_TotalUsage TotalUsage
			{
				get
				{
					return totalUsage;
				}
				set	
				{
					totalUsage = value;
				}
			}

			public class DescribeSavingsPlansUsageTotal_Item
			{

				private string period;

				private float? percentage;

				public string Period
				{
					get
					{
						return period;
					}
					set	
					{
						period = value;
					}
				}

				public float? Percentage
				{
					get
					{
						return percentage;
					}
					set	
					{
						percentage = value;
					}
				}
			}

			public class DescribeSavingsPlansUsageTotal_TotalUsage
			{

				private float? usagePercentage;

				private float? postpaidCost;

				private float? poolValue;

				private float? savedCost;

				public float? UsagePercentage
				{
					get
					{
						return usagePercentage;
					}
					set	
					{
						usagePercentage = value;
					}
				}

				public float? PostpaidCost
				{
					get
					{
						return postpaidCost;
					}
					set	
					{
						postpaidCost = value;
					}
				}

				public float? PoolValue
				{
					get
					{
						return poolValue;
					}
					set	
					{
						poolValue = value;
					}
				}

				public float? SavedCost
				{
					get
					{
						return savedCost;
					}
					set	
					{
						savedCost = value;
					}
				}
			}
		}
	}
}
