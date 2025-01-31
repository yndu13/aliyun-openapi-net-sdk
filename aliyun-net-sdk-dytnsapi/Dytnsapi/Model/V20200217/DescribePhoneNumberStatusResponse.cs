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

namespace Aliyun.Acs.Dytnsapi.Model.V20200217
{
	public class DescribePhoneNumberStatusResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private DescribePhoneNumberStatus_PhoneStatus phoneStatus;

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

		public DescribePhoneNumberStatus_PhoneStatus PhoneStatus
		{
			get
			{
				return phoneStatus;
			}
			set	
			{
				phoneStatus = value;
			}
		}

		public class DescribePhoneNumberStatus_PhoneStatus
		{

			private string status;

			private string serialId;

			private string carrier;

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

			public string SerialId
			{
				get
				{
					return serialId;
				}
				set	
				{
					serialId = value;
				}
			}

			public string Carrier
			{
				get
				{
					return carrier;
				}
				set	
				{
					carrier = value;
				}
			}
		}
	}
}
