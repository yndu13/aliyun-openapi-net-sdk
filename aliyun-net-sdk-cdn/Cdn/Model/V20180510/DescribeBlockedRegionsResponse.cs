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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeBlockedRegionsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeBlockedRegions_InfoItem> infoList;

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

		public List<DescribeBlockedRegions_InfoItem> InfoList
		{
			get
			{
				return infoList;
			}
			set	
			{
				infoList = value;
			}
		}

		public class DescribeBlockedRegions_InfoItem
		{

			private string countriesAndRegions;

			private string countriesAndRegionsName;

			private string continent;

			public string CountriesAndRegions
			{
				get
				{
					return countriesAndRegions;
				}
				set	
				{
					countriesAndRegions = value;
				}
			}

			public string CountriesAndRegionsName
			{
				get
				{
					return countriesAndRegionsName;
				}
				set	
				{
					countriesAndRegionsName = value;
				}
			}

			public string Continent
			{
				get
				{
					return continent;
				}
				set	
				{
					continent = value;
				}
			}
		}
	}
}
