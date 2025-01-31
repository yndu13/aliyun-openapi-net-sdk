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

namespace Aliyun.Acs.Dypnsapi.Model.V20170525
{
	public class GetCertifyResultResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private List<GetCertifyResult_DataItem> data;

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

		public List<GetCertifyResult_DataItem> Data
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

		public class GetCertifyResult_DataItem
		{

			private string materialInfo;

			private string identityInfo;

			private string verifyDesc;

			private string verifyResult;

			private string deviceToken;

			public string MaterialInfo
			{
				get
				{
					return materialInfo;
				}
				set	
				{
					materialInfo = value;
				}
			}

			public string IdentityInfo
			{
				get
				{
					return identityInfo;
				}
				set	
				{
					identityInfo = value;
				}
			}

			public string VerifyDesc
			{
				get
				{
					return verifyDesc;
				}
				set	
				{
					verifyDesc = value;
				}
			}

			public string VerifyResult
			{
				get
				{
					return verifyResult;
				}
				set	
				{
					verifyResult = value;
				}
			}

			public string DeviceToken
			{
				get
				{
					return deviceToken;
				}
				set	
				{
					deviceToken = value;
				}
			}
		}
	}
}
