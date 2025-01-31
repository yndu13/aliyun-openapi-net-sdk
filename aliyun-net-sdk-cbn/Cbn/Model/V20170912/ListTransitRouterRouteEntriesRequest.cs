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
using Aliyun.Acs.Cbn.Transform;
using Aliyun.Acs.Cbn.Transform.V20170912;

namespace Aliyun.Acs.Cbn.Model.V20170912
{
    public class ListTransitRouterRouteEntriesRequest : RpcAcsRequest<ListTransitRouterRouteEntriesResponse>
    {
        public ListTransitRouterRouteEntriesRequest()
            : base("Cbn", "2017-09-12", "ListTransitRouterRouteEntries", "cbn", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string transitRouterRouteEntryDestinationCidrBlock;

		private string transitRouterRouteTableId;

		private string nextToken;

		private string transitRouterRouteEntryStatus;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private List<string> transitRouterRouteEntryNamess = new List<string>(){ };

		private List<string> transitRouterRouteEntryIdss = new List<string>(){ };

		private long? ownerId;

		private int? maxResults;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string TransitRouterRouteEntryDestinationCidrBlock
		{
			get
			{
				return transitRouterRouteEntryDestinationCidrBlock;
			}
			set	
			{
				transitRouterRouteEntryDestinationCidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterRouteEntryDestinationCidrBlock", value);
			}
		}

		public string TransitRouterRouteTableId
		{
			get
			{
				return transitRouterRouteTableId;
			}
			set	
			{
				transitRouterRouteTableId = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterRouteTableId", value);
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		public string TransitRouterRouteEntryStatus
		{
			get
			{
				return transitRouterRouteEntryStatus;
			}
			set	
			{
				transitRouterRouteEntryStatus = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterRouteEntryStatus", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public List<string> TransitRouterRouteEntryNamess
		{
			get
			{
				return transitRouterRouteEntryNamess;
			}

			set
			{
				transitRouterRouteEntryNamess = value;
				for (int i = 0; i < transitRouterRouteEntryNamess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TransitRouterRouteEntryNames." + (i + 1) , transitRouterRouteEntryNamess[i]);
				}
			}
		}

		public List<string> TransitRouterRouteEntryIdss
		{
			get
			{
				return transitRouterRouteEntryIdss;
			}

			set
			{
				transitRouterRouteEntryIdss = value;
				for (int i = 0; i < transitRouterRouteEntryIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TransitRouterRouteEntryIds." + (i + 1) , transitRouterRouteEntryIdss[i]);
				}
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListTransitRouterRouteEntriesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListTransitRouterRouteEntriesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
