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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetDataCorrectTaskDetailResponseUnmarshaller
    {
        public static GetDataCorrectTaskDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataCorrectTaskDetailResponse getDataCorrectTaskDetailResponse = new GetDataCorrectTaskDetailResponse();

			getDataCorrectTaskDetailResponse.HttpResponse = _ctx.HttpResponse;
			getDataCorrectTaskDetailResponse.RequestId = _ctx.StringValue("GetDataCorrectTaskDetail.RequestId");
			getDataCorrectTaskDetailResponse.ErrorCode = _ctx.StringValue("GetDataCorrectTaskDetail.ErrorCode");
			getDataCorrectTaskDetailResponse.ErrorMessage = _ctx.StringValue("GetDataCorrectTaskDetail.ErrorMessage");
			getDataCorrectTaskDetailResponse.Success = _ctx.BooleanValue("GetDataCorrectTaskDetail.Success");

			GetDataCorrectTaskDetailResponse.GetDataCorrectTaskDetail_DataCorrectTaskDetail dataCorrectTaskDetail = new GetDataCorrectTaskDetailResponse.GetDataCorrectTaskDetail_DataCorrectTaskDetail();
			dataCorrectTaskDetail.JobStatus = _ctx.StringValue("GetDataCorrectTaskDetail.DataCorrectTaskDetail.jobStatus");
			dataCorrectTaskDetail.CreateTime = _ctx.StringValue("GetDataCorrectTaskDetail.DataCorrectTaskDetail.CreateTime");
			dataCorrectTaskDetail.ActualAffectRows = _ctx.LongValue("GetDataCorrectTaskDetail.DataCorrectTaskDetail.ActualAffectRows");
			dataCorrectTaskDetail.DBTaskGroupId = _ctx.LongValue("GetDataCorrectTaskDetail.DataCorrectTaskDetail.DBTaskGroupId");
			getDataCorrectTaskDetailResponse.DataCorrectTaskDetail = dataCorrectTaskDetail;
        
			return getDataCorrectTaskDetailResponse;
        }
    }
}
