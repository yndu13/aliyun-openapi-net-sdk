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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class ListDataSetTaskResponse : AcsResponse
	{

		private int? currentPage;

		private int? dataSize;

		private string requestId;

		private bool? success;

		private string code;

		private int? isAllcomplete;

		private string message;

		private int? pageSize;

		private int? totalCount;

		private List<ListDataSetTask_PageTaskInfo> data;

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
			}
		}

		public int? DataSize
		{
			get
			{
				return dataSize;
			}
			set	
			{
				dataSize = value;
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

		public int? IsAllcomplete
		{
			get
			{
				return isAllcomplete;
			}
			set	
			{
				isAllcomplete = value;
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

		public List<ListDataSetTask_PageTaskInfo> Data
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

		public class ListDataSetTask_PageTaskInfo
		{

			private int? status;

			private bool? isTaskComplete;

			private float? scheduleRatio;

			private bool? taskComplete;

			private int? dataSetSize;

			private int? ruleSize;

			private string jobName;

			private string taskId;

			private List<ListDataSetTask_RuleNameInfo> ruleNameInfoList;

			private List<string> dataSets;

			public int? Status
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

			public bool? IsTaskComplete
			{
				get
				{
					return isTaskComplete;
				}
				set	
				{
					isTaskComplete = value;
				}
			}

			public float? ScheduleRatio
			{
				get
				{
					return scheduleRatio;
				}
				set	
				{
					scheduleRatio = value;
				}
			}

			public bool? TaskComplete
			{
				get
				{
					return taskComplete;
				}
				set	
				{
					taskComplete = value;
				}
			}

			public int? DataSetSize
			{
				get
				{
					return dataSetSize;
				}
				set	
				{
					dataSetSize = value;
				}
			}

			public int? RuleSize
			{
				get
				{
					return ruleSize;
				}
				set	
				{
					ruleSize = value;
				}
			}

			public string JobName
			{
				get
				{
					return jobName;
				}
				set	
				{
					jobName = value;
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

			public List<ListDataSetTask_RuleNameInfo> RuleNameInfoList
			{
				get
				{
					return ruleNameInfoList;
				}
				set	
				{
					ruleNameInfoList = value;
				}
			}

			public List<string> DataSets
			{
				get
				{
					return dataSets;
				}
				set	
				{
					dataSets = value;
				}
			}

			public class ListDataSetTask_RuleNameInfo
			{

				private string ruleName;

				private int? rid;

				public string RuleName
				{
					get
					{
						return ruleName;
					}
					set	
					{
						ruleName = value;
					}
				}

				public int? Rid
				{
					get
					{
						return rid;
					}
					set	
					{
						rid = value;
					}
				}
			}
		}
	}
}
