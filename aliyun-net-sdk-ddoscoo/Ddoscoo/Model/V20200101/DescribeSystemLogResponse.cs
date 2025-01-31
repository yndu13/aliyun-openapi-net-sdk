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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeSystemLogResponse : AcsResponse
	{

		private string requestId;

		private long? total;

		private List<DescribeSystemLog_SystemLogItem> systemLog;

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

		public List<DescribeSystemLog_SystemLogItem> SystemLog
		{
			get
			{
				return systemLog;
			}
			set	
			{
				systemLog = value;
			}
		}

		public class DescribeSystemLog_SystemLogItem
		{

			private long? gmtCreate;

			private long? gmtModified;

			private int? entityType;

			private string entityObject;

			private int? opAction;

			private string opAccount;

			private string opDesc;

			private int? status;

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public int? EntityType
			{
				get
				{
					return entityType;
				}
				set	
				{
					entityType = value;
				}
			}

			public string EntityObject
			{
				get
				{
					return entityObject;
				}
				set	
				{
					entityObject = value;
				}
			}

			public int? OpAction
			{
				get
				{
					return opAction;
				}
				set	
				{
					opAction = value;
				}
			}

			public string OpAccount
			{
				get
				{
					return opAccount;
				}
				set	
				{
					opAccount = value;
				}
			}

			public string OpDesc
			{
				get
				{
					return opDesc;
				}
				set	
				{
					opDesc = value;
				}
			}

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
		}
	}
}
