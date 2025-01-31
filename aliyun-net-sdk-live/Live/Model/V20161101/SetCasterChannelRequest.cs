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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class SetCasterChannelRequest : RpcAcsRequest<SetCasterChannelResponse>
    {
        public SetCasterChannelRequest()
            : base("live", "2016-11-01", "SetCasterChannel", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string faceBeauty;

		private int? seekOffset;

		private int? playStatus;

		private string resourceId;

		private string casterId;

		private long? ownerId;

		private string channelId;

		public string FaceBeauty
		{
			get
			{
				return faceBeauty;
			}
			set	
			{
				faceBeauty = value;
				DictionaryUtil.Add(QueryParameters, "FaceBeauty", value);
			}
		}

		public int? SeekOffset
		{
			get
			{
				return seekOffset;
			}
			set	
			{
				seekOffset = value;
				DictionaryUtil.Add(QueryParameters, "SeekOffset", value.ToString());
			}
		}

		public int? PlayStatus
		{
			get
			{
				return playStatus;
			}
			set	
			{
				playStatus = value;
				DictionaryUtil.Add(QueryParameters, "PlayStatus", value.ToString());
			}
		}

		public string ResourceId
		{
			get
			{
				return resourceId;
			}
			set	
			{
				resourceId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId", value);
			}
		}

		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
				DictionaryUtil.Add(QueryParameters, "CasterId", value);
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

		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(QueryParameters, "ChannelId", value);
			}
		}

        public override SetCasterChannelResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetCasterChannelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
