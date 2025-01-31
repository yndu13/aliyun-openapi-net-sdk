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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeConfigGroupDetailResponseUnmarshaller
    {
        public static DescribeConfigGroupDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeConfigGroupDetailResponse describeConfigGroupDetailResponse = new DescribeConfigGroupDetailResponse();

			describeConfigGroupDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeConfigGroupDetailResponse.RequestId = _ctx.StringValue("DescribeConfigGroupDetail.RequestId");
			describeConfigGroupDetailResponse.ConfigGroupId = _ctx.StringValue("DescribeConfigGroupDetail.ConfigGroupId");
			describeConfigGroupDetailResponse.ConfigGroupName = _ctx.StringValue("DescribeConfigGroupDetail.ConfigGroupName");
			describeConfigGroupDetailResponse.Description = _ctx.StringValue("DescribeConfigGroupDetail.Description");
			describeConfigGroupDetailResponse.BizName = _ctx.StringValue("DescribeConfigGroupDetail.BizName");
			describeConfigGroupDetailResponse.CreateTime = _ctx.StringValue("DescribeConfigGroupDetail.CreateTime");
			describeConfigGroupDetailResponse.UpdateTime = _ctx.StringValue("DescribeConfigGroupDetail.UpdateTime");
        
			return describeConfigGroupDetailResponse;
        }
    }
}
