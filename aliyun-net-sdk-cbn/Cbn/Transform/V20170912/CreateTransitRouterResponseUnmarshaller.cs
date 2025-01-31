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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class CreateTransitRouterResponseUnmarshaller
    {
        public static CreateTransitRouterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTransitRouterResponse createTransitRouterResponse = new CreateTransitRouterResponse();

			createTransitRouterResponse.HttpResponse = _ctx.HttpResponse;
			createTransitRouterResponse.RequestId = _ctx.StringValue("CreateTransitRouter.RequestId");
			createTransitRouterResponse.TransitRouterId = _ctx.StringValue("CreateTransitRouter.TransitRouterId");
        
			return createTransitRouterResponse;
        }
    }
}
