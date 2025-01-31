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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeEngineVersionResponse : AcsResponse
	{

		private string requestId;

		private string engine;

		private bool? isLatestVersion;

		private string minorVersion;

		private bool? enableUpgradeMinorVersion;

		private string majorVersion;

		private bool? enableUpgradeMajorVersion;

		private string proxyMinorVersion;

		private string dBVersionRelease;

		private string proxyVersionRelease;

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

		public string Engine
		{
			get
			{
				return engine;
			}
			set	
			{
				engine = value;
			}
		}

		public bool? IsLatestVersion
		{
			get
			{
				return isLatestVersion;
			}
			set	
			{
				isLatestVersion = value;
			}
		}

		public string MinorVersion
		{
			get
			{
				return minorVersion;
			}
			set	
			{
				minorVersion = value;
			}
		}

		public bool? EnableUpgradeMinorVersion
		{
			get
			{
				return enableUpgradeMinorVersion;
			}
			set	
			{
				enableUpgradeMinorVersion = value;
			}
		}

		public string MajorVersion
		{
			get
			{
				return majorVersion;
			}
			set	
			{
				majorVersion = value;
			}
		}

		public bool? EnableUpgradeMajorVersion
		{
			get
			{
				return enableUpgradeMajorVersion;
			}
			set	
			{
				enableUpgradeMajorVersion = value;
			}
		}

		public string ProxyMinorVersion
		{
			get
			{
				return proxyMinorVersion;
			}
			set	
			{
				proxyMinorVersion = value;
			}
		}

		public string DBVersionRelease
		{
			get
			{
				return dBVersionRelease;
			}
			set	
			{
				dBVersionRelease = value;
			}
		}

		public string ProxyVersionRelease
		{
			get
			{
				return proxyVersionRelease;
			}
			set	
			{
				proxyVersionRelease = value;
			}
		}
	}
}
