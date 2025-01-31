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
	public class DescribeCenInterRegionBandwidthLimitsResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeCenInterRegionBandwidthLimits_CenInterRegionBandwidthLimit> cenInterRegionBandwidthLimits;

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
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

		public List<DescribeCenInterRegionBandwidthLimits_CenInterRegionBandwidthLimit> CenInterRegionBandwidthLimits
		{
			get
			{
				return cenInterRegionBandwidthLimits;
			}
			set	
			{
				cenInterRegionBandwidthLimits = value;
			}
		}

		public class DescribeCenInterRegionBandwidthLimits_CenInterRegionBandwidthLimit
		{

			private string transitRouterAttachmentId;

			private string status;

			private string bandwidthPackageId;

			private string oppositeRegionId;

			private string geographicSpanId;

			private string cenId;

			private string localRegionId;

			private long? bandwidthLimit;

			public string TransitRouterAttachmentId
			{
				get
				{
					return transitRouterAttachmentId;
				}
				set	
				{
					transitRouterAttachmentId = value;
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

			public string BandwidthPackageId
			{
				get
				{
					return bandwidthPackageId;
				}
				set	
				{
					bandwidthPackageId = value;
				}
			}

			public string OppositeRegionId
			{
				get
				{
					return oppositeRegionId;
				}
				set	
				{
					oppositeRegionId = value;
				}
			}

			public string GeographicSpanId
			{
				get
				{
					return geographicSpanId;
				}
				set	
				{
					geographicSpanId = value;
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

			public string LocalRegionId
			{
				get
				{
					return localRegionId;
				}
				set	
				{
					localRegionId = value;
				}
			}

			public long? BandwidthLimit
			{
				get
				{
					return bandwidthLimit;
				}
				set	
				{
					bandwidthLimit = value;
				}
			}
		}
	}
}
