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
	public class DescribeAvailableMetricsResponse : AcsResponse
	{

		private int? totalRecordCount;

		private string requestId;

		private List<DescribeAvailableMetrics_Metrics> items;

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

		public List<DescribeAvailableMetrics_Metrics> Items
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

		public class DescribeAvailableMetrics_Metrics
		{

			private string groupKey;

			private int? sortRule;

			private string description;

			private string unit;

			private string dbType;

			private string metricsKey;

			private string groupKeyType;

			private string metricsKeyAlias;

			private string method;

			private string dimension;

			public string GroupKey
			{
				get
				{
					return groupKey;
				}
				set	
				{
					groupKey = value;
				}
			}

			public int? SortRule
			{
				get
				{
					return sortRule;
				}
				set	
				{
					sortRule = value;
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

			public string Unit
			{
				get
				{
					return unit;
				}
				set	
				{
					unit = value;
				}
			}

			public string DbType
			{
				get
				{
					return dbType;
				}
				set	
				{
					dbType = value;
				}
			}

			public string MetricsKey
			{
				get
				{
					return metricsKey;
				}
				set	
				{
					metricsKey = value;
				}
			}

			public string GroupKeyType
			{
				get
				{
					return groupKeyType;
				}
				set	
				{
					groupKeyType = value;
				}
			}

			public string MetricsKeyAlias
			{
				get
				{
					return metricsKeyAlias;
				}
				set	
				{
					metricsKeyAlias = value;
				}
			}

			public string Method
			{
				get
				{
					return method;
				}
				set	
				{
					method = value;
				}
			}

			public string Dimension
			{
				get
				{
					return dimension;
				}
				set	
				{
					dimension = value;
				}
			}
		}
	}
}
