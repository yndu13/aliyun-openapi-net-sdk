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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class SaveWebRtcInfoResponseUnmarshaller
    {
        public static SaveWebRtcInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SaveWebRtcInfoResponse saveWebRtcInfoResponse = new SaveWebRtcInfoResponse();

			saveWebRtcInfoResponse.HttpResponse = _ctx.HttpResponse;
			saveWebRtcInfoResponse.Code = _ctx.StringValue("SaveWebRtcInfo.Code");
			saveWebRtcInfoResponse.HttpStatusCode = _ctx.LongValue("SaveWebRtcInfo.HttpStatusCode");
			saveWebRtcInfoResponse.Message = _ctx.StringValue("SaveWebRtcInfo.Message");
			saveWebRtcInfoResponse.RequestId = _ctx.StringValue("SaveWebRtcInfo.RequestId");
			saveWebRtcInfoResponse.RowCount = _ctx.LongValue("SaveWebRtcInfo.RowCount");
			saveWebRtcInfoResponse.Success = _ctx.BooleanValue("SaveWebRtcInfo.Success");
			saveWebRtcInfoResponse.TimeStamp = _ctx.LongValue("SaveWebRtcInfo.TimeStamp");
        
			return saveWebRtcInfoResponse;
        }
    }
}
