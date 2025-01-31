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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class BatchSetScdnDomainConfigsResponseUnmarshaller
    {
        public static BatchSetScdnDomainConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchSetScdnDomainConfigsResponse batchSetScdnDomainConfigsResponse = new BatchSetScdnDomainConfigsResponse();

			batchSetScdnDomainConfigsResponse.HttpResponse = _ctx.HttpResponse;
			batchSetScdnDomainConfigsResponse.RequestId = _ctx.StringValue("BatchSetScdnDomainConfigs.RequestId");

			List<BatchSetScdnDomainConfigsResponse.BatchSetScdnDomainConfigs_DomainConfigModel> batchSetScdnDomainConfigsResponse_domainConfigList = new List<BatchSetScdnDomainConfigsResponse.BatchSetScdnDomainConfigs_DomainConfigModel>();
			for (int i = 0; i < _ctx.Length("BatchSetScdnDomainConfigs.DomainConfigList.Length"); i++) {
				BatchSetScdnDomainConfigsResponse.BatchSetScdnDomainConfigs_DomainConfigModel domainConfigModel = new BatchSetScdnDomainConfigsResponse.BatchSetScdnDomainConfigs_DomainConfigModel();
				domainConfigModel.DomainName = _ctx.StringValue("BatchSetScdnDomainConfigs.DomainConfigList["+ i +"].DomainName");
				domainConfigModel.ConfigId = _ctx.LongValue("BatchSetScdnDomainConfigs.DomainConfigList["+ i +"].ConfigId");
				domainConfigModel.FunctionName = _ctx.StringValue("BatchSetScdnDomainConfigs.DomainConfigList["+ i +"].FunctionName");

				batchSetScdnDomainConfigsResponse_domainConfigList.Add(domainConfigModel);
			}
			batchSetScdnDomainConfigsResponse.DomainConfigList = batchSetScdnDomainConfigsResponse_domainConfigList;
        
			return batchSetScdnDomainConfigsResponse;
        }
    }
}
