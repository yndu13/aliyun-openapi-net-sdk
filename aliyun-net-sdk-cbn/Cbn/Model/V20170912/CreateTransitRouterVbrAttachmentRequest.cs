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
    public class CreateTransitRouterVbrAttachmentRequest : RpcAcsRequest<CreateTransitRouterVbrAttachmentResponse>
    {
        public CreateTransitRouterVbrAttachmentRequest()
            : base("Cbn", "2017-09-12", "CreateTransitRouterVbrAttachment", "cbn", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string cenId;

		private string vbrId;

		private string transitRouterAttachmentName;

		private bool? autoPublishRouteEnabled;

		private bool? dryRun;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string transitRouterId;

		private string transitRouterAttachmentDescription;

		private long? vbrOwnerId;

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

		public string CenId
		{
			get
			{
				return cenId;
			}
			set	
			{
				cenId = value;
				DictionaryUtil.Add(QueryParameters, "CenId", value);
			}
		}

		public string VbrId
		{
			get
			{
				return vbrId;
			}
			set	
			{
				vbrId = value;
				DictionaryUtil.Add(QueryParameters, "VbrId", value);
			}
		}

		public string TransitRouterAttachmentName
		{
			get
			{
				return transitRouterAttachmentName;
			}
			set	
			{
				transitRouterAttachmentName = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterAttachmentName", value);
			}
		}

		public bool? AutoPublishRouteEnabled
		{
			get
			{
				return autoPublishRouteEnabled;
			}
			set	
			{
				autoPublishRouteEnabled = value;
				DictionaryUtil.Add(QueryParameters, "AutoPublishRouteEnabled", value.ToString());
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
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

		public string TransitRouterId
		{
			get
			{
				return transitRouterId;
			}
			set	
			{
				transitRouterId = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterId", value);
			}
		}

		public string TransitRouterAttachmentDescription
		{
			get
			{
				return transitRouterAttachmentDescription;
			}
			set	
			{
				transitRouterAttachmentDescription = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterAttachmentDescription", value);
			}
		}

		public long? VbrOwnerId
		{
			get
			{
				return vbrOwnerId;
			}
			set	
			{
				vbrOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "VbrOwnerId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTransitRouterVbrAttachmentResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTransitRouterVbrAttachmentResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
