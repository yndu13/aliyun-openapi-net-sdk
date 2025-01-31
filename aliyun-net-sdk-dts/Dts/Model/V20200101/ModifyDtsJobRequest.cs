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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Dts.Transform;
using Aliyun.Acs.Dts.Transform.V20200101;

namespace Aliyun.Acs.Dts.Model.V20200101
{
    public class ModifyDtsJobRequest : RpcAcsRequest<ModifyDtsJobResponse>
    {
        public ModifyDtsJobRequest()
            : base("Dts", "2020-01-01", "ModifyDtsJob", "dts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dbList;

		private string clientToken;

		private string etlOperatorColumnReference;

		private string dtsInstanceId;

		private string synchronizationDirection;

		public string DbList
		{
			get
			{
				return dbList;
			}
			set	
			{
				dbList = value;
				DictionaryUtil.Add(BodyParameters, "DbList", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string EtlOperatorColumnReference
		{
			get
			{
				return etlOperatorColumnReference;
			}
			set	
			{
				etlOperatorColumnReference = value;
				DictionaryUtil.Add(BodyParameters, "EtlOperatorColumnReference", value);
			}
		}

		public string DtsInstanceId
		{
			get
			{
				return dtsInstanceId;
			}
			set	
			{
				dtsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DtsInstanceId", value);
			}
		}

		public string SynchronizationDirection
		{
			get
			{
				return synchronizationDirection;
			}
			set	
			{
				synchronizationDirection = value;
				DictionaryUtil.Add(QueryParameters, "SynchronizationDirection", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyDtsJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDtsJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
