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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class SubscribeTopicResponseUnmarshaller
    {
        public static SubscribeTopicResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubscribeTopicResponse subscribeTopicResponse = new SubscribeTopicResponse();

			subscribeTopicResponse.HttpResponse = _ctx.HttpResponse;
			subscribeTopicResponse.RequestId = _ctx.StringValue("SubscribeTopic.RequestId");
			subscribeTopicResponse.Success = _ctx.BooleanValue("SubscribeTopic.Success");
			subscribeTopicResponse.Code = _ctx.StringValue("SubscribeTopic.Code");
			subscribeTopicResponse.ErrorMessage = _ctx.StringValue("SubscribeTopic.ErrorMessage");

			List<string> subscribeTopicResponse_failureTopics = new List<string>();
			for (int i = 0; i < _ctx.Length("SubscribeTopic.FailureTopics.Length"); i++) {
				subscribeTopicResponse_failureTopics.Add(_ctx.StringValue("SubscribeTopic.FailureTopics["+ i +"]"));
			}
			subscribeTopicResponse.FailureTopics = subscribeTopicResponse_failureTopics;
        
			return subscribeTopicResponse;
        }
    }
}
