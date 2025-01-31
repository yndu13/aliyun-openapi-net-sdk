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
    public class ListTransitRouterRouteTableAssociationsResponseUnmarshaller
    {
        public static ListTransitRouterRouteTableAssociationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterRouteTableAssociationsResponse listTransitRouterRouteTableAssociationsResponse = new ListTransitRouterRouteTableAssociationsResponse();

			listTransitRouterRouteTableAssociationsResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterRouteTableAssociationsResponse.RequestId = _ctx.StringValue("ListTransitRouterRouteTableAssociations.RequestId");
			listTransitRouterRouteTableAssociationsResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterRouteTableAssociations.TotalCount");
			listTransitRouterRouteTableAssociationsResponse.MaxResults = _ctx.IntegerValue("ListTransitRouterRouteTableAssociations.MaxResults");
			listTransitRouterRouteTableAssociationsResponse.NextToken = _ctx.StringValue("ListTransitRouterRouteTableAssociations.NextToken");

			List<ListTransitRouterRouteTableAssociationsResponse.ListTransitRouterRouteTableAssociations_TransitRouterAssociation> listTransitRouterRouteTableAssociationsResponse_transitRouterAssociations = new List<ListTransitRouterRouteTableAssociationsResponse.ListTransitRouterRouteTableAssociations_TransitRouterAssociation>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterRouteTableAssociations.TransitRouterAssociations.Length"); i++) {
				ListTransitRouterRouteTableAssociationsResponse.ListTransitRouterRouteTableAssociations_TransitRouterAssociation transitRouterAssociation = new ListTransitRouterRouteTableAssociationsResponse.ListTransitRouterRouteTableAssociations_TransitRouterAssociation();
				transitRouterAssociation.Status = _ctx.StringValue("ListTransitRouterRouteTableAssociations.TransitRouterAssociations["+ i +"].Status");
				transitRouterAssociation.TransitRouterAttachmentId = _ctx.StringValue("ListTransitRouterRouteTableAssociations.TransitRouterAssociations["+ i +"].TransitRouterAttachmentId");
				transitRouterAssociation.TransitRouterRouteTableId = _ctx.StringValue("ListTransitRouterRouteTableAssociations.TransitRouterAssociations["+ i +"].TransitRouterRouteTableId");
				transitRouterAssociation.ResourceId = _ctx.StringValue("ListTransitRouterRouteTableAssociations.TransitRouterAssociations["+ i +"].ResourceId");
				transitRouterAssociation.ResourceType = _ctx.StringValue("ListTransitRouterRouteTableAssociations.TransitRouterAssociations["+ i +"].ResourceType");

				listTransitRouterRouteTableAssociationsResponse_transitRouterAssociations.Add(transitRouterAssociation);
			}
			listTransitRouterRouteTableAssociationsResponse.TransitRouterAssociations = listTransitRouterRouteTableAssociationsResponse_transitRouterAssociations;
        
			return listTransitRouterRouteTableAssociationsResponse;
        }
    }
}
