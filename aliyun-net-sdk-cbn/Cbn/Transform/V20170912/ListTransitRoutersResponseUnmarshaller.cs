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
    public class ListTransitRoutersResponseUnmarshaller
    {
        public static ListTransitRoutersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRoutersResponse listTransitRoutersResponse = new ListTransitRoutersResponse();

			listTransitRoutersResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRoutersResponse.RequestId = _ctx.StringValue("ListTransitRouters.RequestId");
			listTransitRoutersResponse.TotalCount = _ctx.IntegerValue("ListTransitRouters.TotalCount");
			listTransitRoutersResponse.PageNumber = _ctx.IntegerValue("ListTransitRouters.PageNumber");
			listTransitRoutersResponse.PageSize = _ctx.IntegerValue("ListTransitRouters.PageSize");

			List<ListTransitRoutersResponse.ListTransitRouters_TransitRouter> listTransitRoutersResponse_transitRouters = new List<ListTransitRoutersResponse.ListTransitRouters_TransitRouter>();
			for (int i = 0; i < _ctx.Length("ListTransitRouters.TransitRouters.Length"); i++) {
				ListTransitRoutersResponse.ListTransitRouters_TransitRouter transitRouter = new ListTransitRoutersResponse.ListTransitRouters_TransitRouter();
				transitRouter.TransitRouterId = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].TransitRouterId");
				transitRouter.Status = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].Status");
				transitRouter.CenId = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].CenId");
				transitRouter.RegionId = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].RegionId");
				transitRouter.AliUid = _ctx.LongValue("ListTransitRouters.TransitRouters["+ i +"].AliUid");
				transitRouter.Type = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].Type");
				transitRouter.CreationTime = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].CreationTime");
				transitRouter.TransitRouterName = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].TransitRouterName");
				transitRouter.TransitRouterDescription = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].TransitRouterDescription");

				listTransitRoutersResponse_transitRouters.Add(transitRouter);
			}
			listTransitRoutersResponse.TransitRouters = listTransitRoutersResponse_transitRouters;
        
			return listTransitRoutersResponse;
        }
    }
}
