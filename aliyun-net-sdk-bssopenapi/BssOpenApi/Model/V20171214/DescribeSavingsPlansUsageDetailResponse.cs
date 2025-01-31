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
	public class DescribeSavingsPlansUsageDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private DescribeSavingsPlansUsageDetail_Data data;

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

		public DescribeSavingsPlansUsageDetail_Data Data
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

		public class DescribeSavingsPlansUsageDetail_Data
		{

			private int? totalCount;

			private string nextToken;

			private List<DescribeSavingsPlansUsageDetail_Item> items;

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

			public List<DescribeSavingsPlansUsageDetail_Item> Items
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

			public class DescribeSavingsPlansUsageDetail_Item
			{

				private long? userId;

				private string userName;

				private string instanceId;

				private string startPeriod;

				private string endPeriod;

				private string status;

				private string type;

				private float? usagePercentage;

				private float? poolValue;

				private float? deductValue;

				private float? postpaidCost;

				private float? savedCost;

				private string currency;

				public long? UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
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

				public string StartPeriod
				{
					get
					{
						return startPeriod;
					}
					set	
					{
						startPeriod = value;
					}
				}

				public string EndPeriod
				{
					get
					{
						return endPeriod;
					}
					set	
					{
						endPeriod = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

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

				public float? DeductValue
				{
					get
					{
						return deductValue;
					}
					set	
					{
						deductValue = value;
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

				public string Currency
				{
					get
					{
						return currency;
					}
					set	
					{
						currency = value;
					}
				}
			}
		}
	}
}
