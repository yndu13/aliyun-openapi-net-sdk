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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class ModifyDiskAttributeRequest : RpcAcsRequest<ModifyDiskAttributeResponse>
    {
        public ModifyDiskAttributeRequest()
            : base("Ecs", "2014-05-26", "ModifyDiskAttribute", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string description;

		private string diskName;

		private bool? deleteAutoSnapshot;

		private List<string> diskIdss = new List<string>(){ };

		private string diskId;

		private bool? deleteWithInstance;

		private bool? enableAutoSnapshot;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "DiskName")]
		public string DiskName
		{
			get
			{
				return diskName;
			}
			set	
			{
				diskName = value;
				DictionaryUtil.Add(QueryParameters, "DiskName", value);
			}
		}

		[JsonProperty(PropertyName = "DeleteAutoSnapshot")]
		public bool? DeleteAutoSnapshot
		{
			get
			{
				return deleteAutoSnapshot;
			}
			set	
			{
				deleteAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "DeleteAutoSnapshot", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "DiskIds")]
		public List<string> DiskIdss
		{
			get
			{
				return diskIdss;
			}

			set
			{
				diskIdss = value;
			}
		}

		[JsonProperty(PropertyName = "DiskId")]
		public string DiskId
		{
			get
			{
				return diskId;
			}
			set	
			{
				diskId = value;
				DictionaryUtil.Add(QueryParameters, "DiskId", value);
			}
		}

		[JsonProperty(PropertyName = "DeleteWithInstance")]
		public bool? DeleteWithInstance
		{
			get
			{
				return deleteWithInstance;
			}
			set	
			{
				deleteWithInstance = value;
				DictionaryUtil.Add(QueryParameters, "DeleteWithInstance", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "EnableAutoSnapshot")]
		public bool? EnableAutoSnapshot
		{
			get
			{
				return enableAutoSnapshot;
			}
			set	
			{
				enableAutoSnapshot = value;
				DictionaryUtil.Add(QueryParameters, "EnableAutoSnapshot", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerId")]
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

        public override ModifyDiskAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDiskAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
