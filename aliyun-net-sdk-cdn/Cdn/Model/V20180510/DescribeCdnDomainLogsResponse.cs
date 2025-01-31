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
	public class DescribeCdnDomainLogsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeCdnDomainLogs_DomainLogDetail> domainLogDetails;

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

		public List<DescribeCdnDomainLogs_DomainLogDetail> DomainLogDetails
		{
			get
			{
				return domainLogDetails;
			}
			set	
			{
				domainLogDetails = value;
			}
		}

		public class DescribeCdnDomainLogs_DomainLogDetail
		{

			private string domainName;

			private long? logCount;

			private List<DescribeCdnDomainLogs_LogInfoDetail> logInfos;

			private DescribeCdnDomainLogs_PageInfos pageInfos;

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public long? LogCount
			{
				get
				{
					return logCount;
				}
				set	
				{
					logCount = value;
				}
			}

			public List<DescribeCdnDomainLogs_LogInfoDetail> LogInfos
			{
				get
				{
					return logInfos;
				}
				set	
				{
					logInfos = value;
				}
			}

			public DescribeCdnDomainLogs_PageInfos PageInfos
			{
				get
				{
					return pageInfos;
				}
				set	
				{
					pageInfos = value;
				}
			}

			public class DescribeCdnDomainLogs_LogInfoDetail
			{

				private string logName;

				private string logPath;

				private long? logSize;

				private string startTime;

				private string endTime;

				public string LogName
				{
					get
					{
						return logName;
					}
					set	
					{
						logName = value;
					}
				}

				public string LogPath
				{
					get
					{
						return logPath;
					}
					set	
					{
						logPath = value;
					}
				}

				public long? LogSize
				{
					get
					{
						return logSize;
					}
					set	
					{
						logSize = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}
			}

			public class DescribeCdnDomainLogs_PageInfos
			{

				private long? pageIndex;

				private long? pageSize;

				private long? total;

				public long? PageIndex
				{
					get
					{
						return pageIndex;
					}
					set	
					{
						pageIndex = value;
					}
				}

				public long? PageSize
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

				public long? Total
				{
					get
					{
						return total;
					}
					set	
					{
						total = value;
					}
				}
			}
		}
	}
}
